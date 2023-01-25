using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;

namespace CashCrusaders.App
{
    public partial class CaptureSupplier : Form
    {
        private readonly ISuppliersService _supplierService;
        public event EventHandler SupplierCreated;
        public CaptureSupplier(ISuppliersService suppliersService)
        {
            InitializeComponent();
            _supplierService = suppliersService;
        }

        private async void bSave_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please enter a valid supplier name", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            var name = tbName.Text;
            var code = lSupplierCodeDesc.Text;
            var supplier = new Supplier
            {
                SupplierCode = code,
                SupplierName = name
            };

            Cursor = Cursors.WaitCursor;
            bSave.Enabled = false;
            var result = await _supplierService.Insert(supplier);
            Cursor = Cursors.Default;
            if (result != null)
            {
                var button = MessageBox.Show("Supplier has been successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (button == DialogResult.OK)
                {
                    SupplierCreated?.Invoke(this, EventArgs.Empty);
                    Close();
                    Dispose();
                }
            }
            else
            {
                bSave.Enabled = true;
                MessageBox.Show("Please check your inputs and try again", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CaptureSupplier_Load(object sender, EventArgs e)
        {
            lSupplierCodeDesc.Text = string.Format("SUPP-{0}", Guid.NewGuid().ToString().ToUpperInvariant().Split('-')[0][..3]);
        }
    }
}
