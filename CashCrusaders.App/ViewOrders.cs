using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;

namespace CashCrusaders.App
{
    public partial class ViewOrders : Form
    {
        private readonly IOrdersService _orderService;
        public ViewOrders(IOrdersService ordersService)
        {
            InitializeComponent();
            _orderService = ordersService;
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private async void LoadOrders()
        {
            Cursor.Current = Cursors.WaitCursor;
            var result = await _orderService.GetAll();
            if (result != null)
            {
                result.Sort(DoOdersSort);
                lvOrders.Items.Clear();
                lvOrders.Visible = false;

                var list = new List<ListViewItem>();

                foreach (var item in result)
                {
                    var backColor = Color.White;
                    var order = new ListViewItem { Text = item.Number, Tag = item, BackColor = backColor };

                    order.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"date", Text = item.Date.ToString("ddd, dd, MMM, yyy HH:mm") });
                    order.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"tax", Text = item.Tax.ToString() });
                    order.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"grandTotal", Text = $"R{item.GrandTotal}" });
                    order.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"code", Text = item.SupplierCode });
                    order.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"name", Text = item.SupplierName });

                    list.Add(order);
                }

                lvOrders.Items.AddRange(list.ToArray());
                if (list.Count != 0) { lvOrders.Enabled = true; }
                AutoResizeColumns(lvOrders);
                lvOrders.Visible = true;
            }
            Cursor.Current = Cursors.Default;
        }

        private int DoOdersSort(Order x, Order y)
        {
            return -x.Date.CompareTo(y.Date);
        }

        #region Helper Methods
        private static void AutoResizeColumns(ListView listview)
        {
            listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion

        private void lvOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var order = (Order)lvOrders.Items[e.ItemIndex].Tag;
            if (order != null)
            {
                PopulateLines(order);
            }
        }

        private void PopulateLines(Order order)
        {
            lvOrderLines.Items.Clear();
            lvOrderLines.Visible = false;

            var list = new List<ListViewItem>();

            foreach (var item in order.Lines)
            {
                var backColor = Color.White;
                var line = new ListViewItem { Text = item.Qty.ToString(), Tag = item, BackColor = backColor };

                line.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"subTotal", Text = $"R{item.SubTotal}" });
                line.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"description", Text = item.Description });
                line.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"code", Text = item.Code });
                line.SubItems.Add(new ListViewItem.ListViewSubItem { Name = @"price", Text = item.Price.ToString() });

                list.Add(line);
            }

            lvOrderLines.Items.AddRange(list.ToArray());
            if (list.Count != 0) { lvOrderLines.Enabled = true; }
            AutoResizeColumns(lvOrderLines);
            lvOrderLines.Visible = true;
        }
    }
}
