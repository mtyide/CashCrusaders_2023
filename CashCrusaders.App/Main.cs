using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace CashCrusaders.App
{
    public partial class Main : Form
    {
        private readonly ISuppliersService _suppliersService;
        private readonly IProductsService _productsService;
        public Main(ISuppliersService suppliersService, IProductsService productsService)
        {
            InitializeComponent();
            _suppliersService = suppliersService;
            _productsService = productsService;
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
                        var backColor = System.Drawing.Color.White;
                        var product = new ListViewItem { Text = item.ProductCode, Tag = item, BackColor = backColor };

                        product.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"price", Text = item.Price.ToString() });
                        product.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"qty", Text = string.Empty });
                        product.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"description", Text = item.Description });

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
    }
}
