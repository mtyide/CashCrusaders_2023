using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;

namespace CashCrusaders.App
{
    public partial class CaptureProduct : Form
    {
        public int SupplierID { get; set; }
        public event EventHandler ProductCreated;
        private readonly IProductsService _productService;
        public CaptureProduct(IProductsService productsService)
        {
            InitializeComponent();
            _productService = productsService;
        }

        private void CaptureProduct_Load(object sender, EventArgs e)
        {
            lProductCodeDesc.Text = string.Format("PROD-{0}", Guid.NewGuid().ToString().ToUpperInvariant().Split('-')[0][..3]);
        }

        private async void bSave_Click(object sender, EventArgs e)
        {
            #region Validation
            var res = decimal.TryParse(tbPrice.Text, out decimal productPrice);
            if (res == false)
            {
                MessageBox.Show("Please enter a valid price","Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (productPrice == 0)
            {
                MessageBox.Show("Please enter a valid price", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                MessageBox.Show("Please enter a product description", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            var price = productPrice;
            var description = tbDescription.Text;
            var code = lProductCodeDesc.Text;
            var product = new Product
            {
                Description = description,
                Price = price,
                ProductCode = code,
                SupplierID = SupplierID
            };

            Cursor = Cursors.WaitCursor;
            bSave.Enabled = false;
            var result = await _productService.Insert(product);
            Cursor = Cursors.Default;
            if (result != null)
            {
                var button = MessageBox.Show("Product has been successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (button == DialogResult.OK)
                {
                    Close();
                    ProductCreated?.Invoke(result, EventArgs.Empty);
                    Dispose();
                }
            }
            else
            {
                bSave.Enabled = true;
                MessageBox.Show("Please check your inputs and try again", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
