namespace CashCrusaders.App
{
    public partial class CaptureQuantity : Form
    {
        public event EventHandler QtyUpdated;
        public CaptureQuantity()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            var result = int.TryParse(tbQty.Text, out int qty);

            if (result == false || qty == 0)
            {
                MessageBox.Show("Please enter a valid quantity", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (qty > 0)
            {
                Close();
                QtyUpdated?.Invoke(qty, EventArgs.Empty);
                Dispose();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }            
        }

        private void CaptureQuantity_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = int.TryParse(tbQty.Text, out int qty);

            if (result == false || qty == 0)
            {
                QtyUpdated?.Invoke(qty, EventArgs.Empty);
            }
        }
    }
}
