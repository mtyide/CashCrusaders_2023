using CashCrusaders.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashCrusaders.App
{
    public partial class Main : Form
    {
        private readonly ISuppliersService _suppliersService;
        public Main(ISuppliersService suppliersService)
        {
            InitializeComponent();
            _suppliersService = suppliersService;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private async void LoadSuppliers()
        {
            var list = await _suppliersService.GetAll();
            cbSupplierList.DataSource= list;
            cbSupplierList.DisplayMember = "SupplierName";
        }
    }
}
