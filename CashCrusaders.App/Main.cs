using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;
using System.Resources;

namespace CashCrusaders.App
{
    public partial class Main : Form
    {
        private int holdPos = 0;
        private readonly ISuppliersService _suppliersService;
        private readonly IProductsService _productsService;
        private readonly IOrdersService _ordersService;
        private bool isLoading = true;
        public Main(ISuppliersService suppliersService, IProductsService productsService, IOrdersService ordersService)
        {
            InitializeComponent();
            _suppliersService = suppliersService;
            _productsService = productsService;
            _ordersService = ordersService;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private async void LoadSuppliers()
        {
            var list = await _suppliersService.GetAll();
            cbSupplierList.DataSource = list;
            cbSupplierList.DisplayMember = "SupplierName";
            cbSupplierList.SelectedIndex = 0;
            cbSupplierList.ValueMember = "Id";
            if (list.Count > 0) { bViewOrders.Enabled = true; }
            isLoading = false;
            await LoadProductsBySelectedSupplier();
        }

        private static int DoProductsSort(Product x, Product y)
        {
            return -x.ProductCode.CompareTo(y.ProductCode);
        }

        private async void bViewProducts_Click(object sender, EventArgs e)
        {
            await LoadProductsBySelectedSupplier();
        }

        private async Task LoadProductsBySelectedSupplier()
        {
            var supplierID = (int)cbSupplierList.SelectedValue;
            if (supplierID > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                var result = await _productsService.GetProductsBySupplierID(supplierID);
                if (result != null)
                {
                    result.Sort(DoProductsSort);
                    lvProducts.Items.Clear();
                    lvProducts.Visible = false;

                    var list = new List<ListViewItem>();

                    foreach (var item in result)
                    {
                        var backColor = Color.White;
                        var product = new ListViewItem { Text = item.ProductCode, Tag = item, BackColor = backColor };

                        product.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"price", Text = item.Price.ToString() });
                        product.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"qty", Text = string.Empty });
                        product.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"description", Text = item.Description });
                        product.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"code", Text = item.ProductCode });

                        list.Add(product);
                    }

                    lvProducts.Items.AddRange(list.ToArray());
                    if (list.Count != 0) { lvProducts.Enabled = true; }
                    AutoResizeColumns(lvProducts);
                    lvProducts.Visible = true;
                }
                Cursor.Current = Cursors.Default;
            }
        }

        #region Helper Methods
        private static void AutoResizeColumns(ListView listview)
        {
            listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        private void bCaptureNewProduct_Click(object sender, EventArgs e)
        {
            Application.DoEvents();

            Cursor = Cursors.WaitCursor;
            var product = new CaptureProduct(_productsService)
            {
                StartPosition = FormStartPosition.CenterScreen,
                SupplierID = (int)cbSupplierList.SelectedValue
            };
            product.ProductCreated += Product_ProductCreated;
            product.Show();
            product.WindowState = FormWindowState.Normal;
            Cursor = Cursors.Default;
        }

        private async void Product_ProductCreated(object sender, EventArgs e)
        {
            await LoadProductsBySelectedSupplier();
        }

        private void bCaptureNewSupplier_Click(object sender, EventArgs e)
        {
            Application.DoEvents();

            Cursor = Cursors.WaitCursor;
            var supplier = new CaptureSupplier(_suppliersService)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            supplier.SupplierCreated += Supplier_SupplierCreated; ;
            supplier.Show();
            supplier.WindowState = FormWindowState.Normal;
            Cursor = Cursors.Default;
        }

        private void Supplier_SupplierCreated(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void lvProducts_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            bCreateNewOrder.Enabled = false;
            var index = e.Item.Index;
            holdPos = index;
            if (e.Item.Checked)
            {
                if (index > 0) { holdPos++; }

                var product = (Product)lvProducts.Items[index].Tag;

                Application.DoEvents();

                Cursor = Cursors.WaitCursor;
                var quantity = new CaptureQuantity()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                quantity.QtyUpdated += Quantity_QtyUpdated;
                quantity.Show();
                quantity.WindowState = FormWindowState.Normal;

                bCreateNewOrder.Enabled = true;
                Cursor = Cursors.Default;
            }
            else
            {
                lvProducts.Items[holdPos].SubItems[2].Text = string.Empty;
                CalculateSubTotal();
            }
        }

        private void CalculateSubTotal()
        {
            var total = 0.0M;
            foreach (ListViewItem item in lvProducts.CheckedItems)
            {
                var price = decimal.Parse(item.SubItems[1].Text);
                var qty = int.Parse(item.SubItems[2].Text);
                total += (price * qty);
            }
            lSubTotal.Text = $"Sub-Total: R{total}";
        }

        private void Quantity_QtyUpdated(object sender, EventArgs e)
        {
            var qty = Convert.ToInt32(sender);
            if (qty == 0)
            {
                if (holdPos > 1) { holdPos--; }
                lvProducts.Items[holdPos].SubItems[2].Text = string.Empty;
                lvProducts.Items[holdPos].Checked = false;
            }
            else
            {
                if (holdPos > 1) { holdPos--; }
                lvProducts.Items[holdPos].SubItems[2].Text = Convert.ToString(sender);
                CalculateSubTotal();
            }
        }

        private async void bCreateNewOrder_Click(object sender, EventArgs e)
        {
            bCreateNewOrder.Enabled = false;
            const string resxFile = @".\CashCrusadersResource.resx";
            decimal tax = 00.00M;
            using (var resxSet = new ResXResourceSet(resxFile))
            {
                _ = decimal.TryParse(resxSet.GetString("tax"), out tax);
            }

            if (tax <= 0) { tax = 14.00M; }

            var lines = new List<OrderLine>();
            var total = 0.0M;
            foreach (ListViewItem item in lvProducts.CheckedItems)
            {
                var price = decimal.Parse(item.SubItems[1].Text);
                var qty = int.Parse(item.SubItems[2].Text);
                total += (price * qty);
                lines.Add(new OrderLine
                {
                    Price = price,
                    Qty = qty,
                    Code = item.SubItems[4].Text,
                    Description = item.SubItems[3].Text,
                    SubTotal = total
                });
            }
            var grandTotal = total + (decimal.Divide(tax, 100) * total);
            var number = string.Format("ORD-{0}", Guid.NewGuid().ToString().ToUpperInvariant().Split('-')[0][..3]);

            var id = (int)cbSupplierList.SelectedValue;
            var supplier = await _suppliersService.GetById(id);

            if (supplier != null)
            {
                var order = new Order
                {
                    Date = DateTime.UtcNow,
                    GrandTotal = grandTotal,
                    Lines = lines,
                    Tax = tax,
                    Number = number,
                    SupplierCode = supplier.SupplierCode,
                    SupplierName = cbSupplierList.Text
                };

                var result = await _ordersService.Insert(order);
                if (result != null)
                {
                    MessageBox.Show("Order has been successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadProductsBySelectedSupplier();
                }
            }
            else
            {
                MessageBox.Show("Please check your inputs and try again", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bCreateNewOrder.Enabled = true;
        }

        private void bViewOrders_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var viewOrders = new ViewOrders(_ordersService)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            viewOrders.Show();
            viewOrders.WindowState = FormWindowState.Normal;
            Cursor = Cursors.Default;
        }

        private async void cbSupplierList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isLoading == true) { return; }

            await LoadProductsBySelectedSupplier();
        }
    }
}
