namespace CashCrusaders.App
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gbSupplierDetails = new System.Windows.Forms.GroupBox();
            this.bCaptureNewSupplier = new System.Windows.Forms.Button();
            this.bCaptureNewProduct = new System.Windows.Forms.Button();
            this.lSupplierList = new System.Windows.Forms.Label();
            this.cbSupplierList = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvProducts = new System.Windows.Forms.ListView();
            this.chProductCode = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.chQty = new System.Windows.Forms.ColumnHeader();
            this.chDescription = new System.Windows.Forms.ColumnHeader();
            this.pCreateOrder = new System.Windows.Forms.Panel();
            this.lSubTotal = new System.Windows.Forms.Label();
            this.bViewOrders = new System.Windows.Forms.Button();
            this.bCreateNewOrder = new System.Windows.Forms.Button();
            this.gbSupplierDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersRepositoryBindingSource)).BeginInit();
            this.pCreateOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSupplierDetails
            // 
            this.gbSupplierDetails.Controls.Add(this.bCaptureNewSupplier);
            this.gbSupplierDetails.Controls.Add(this.bCaptureNewProduct);
            this.gbSupplierDetails.Controls.Add(this.lSupplierList);
            this.gbSupplierDetails.Controls.Add(this.cbSupplierList);
            this.gbSupplierDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSupplierDetails.Location = new System.Drawing.Point(0, 0);
            this.gbSupplierDetails.Name = "gbSupplierDetails";
            this.gbSupplierDetails.Size = new System.Drawing.Size(840, 131);
            this.gbSupplierDetails.TabIndex = 0;
            this.gbSupplierDetails.TabStop = false;
            this.gbSupplierDetails.Text = "Supplier Details";
            // 
            // bCaptureNewSupplier
            // 
            this.bCaptureNewSupplier.Location = new System.Drawing.Point(467, 49);
            this.bCaptureNewSupplier.Name = "bCaptureNewSupplier";
            this.bCaptureNewSupplier.Size = new System.Drawing.Size(179, 29);
            this.bCaptureNewSupplier.TabIndex = 4;
            this.bCaptureNewSupplier.Text = "Capture New Supplier";
            this.bCaptureNewSupplier.UseVisualStyleBackColor = true;
            this.bCaptureNewSupplier.Click += new System.EventHandler(this.bCaptureNewSupplier_Click);
            // 
            // bCaptureNewProduct
            // 
            this.bCaptureNewProduct.Location = new System.Drawing.Point(653, 49);
            this.bCaptureNewProduct.Name = "bCaptureNewProduct";
            this.bCaptureNewProduct.Size = new System.Drawing.Size(165, 29);
            this.bCaptureNewProduct.TabIndex = 3;
            this.bCaptureNewProduct.Text = "Capture New Product";
            this.bCaptureNewProduct.UseVisualStyleBackColor = true;
            this.bCaptureNewProduct.Click += new System.EventHandler(this.bCaptureNewProduct_Click);
            // 
            // lSupplierList
            // 
            this.lSupplierList.AutoSize = true;
            this.lSupplierList.Location = new System.Drawing.Point(6, 57);
            this.lSupplierList.Name = "lSupplierList";
            this.lSupplierList.Size = new System.Drawing.Size(90, 20);
            this.lSupplierList.TabIndex = 1;
            this.lSupplierList.Text = "Supplier List";
            // 
            // cbSupplierList
            // 
            this.cbSupplierList.DataSource = this.supplierBindingSource;
            this.cbSupplierList.DisplayMember = "Name";
            this.cbSupplierList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierList.FormattingEnabled = true;
            this.cbSupplierList.Location = new System.Drawing.Point(109, 48);
            this.cbSupplierList.Name = "cbSupplierList";
            this.cbSupplierList.Size = new System.Drawing.Size(351, 28);
            this.cbSupplierList.TabIndex = 2;
            this.cbSupplierList.ValueMember = "Id";
            this.cbSupplierList.SelectedValueChanged += new System.EventHandler(this.cbSupplierList_SelectedValueChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(CashCrusaders.Domain.Models.Supplier);
            // 
            // suppliersRepositoryBindingSource
            // 
            this.suppliersRepositoryBindingSource.DataSource = typeof(CashCrusaders.Data.Repositories.SuppliersRepository);
            // 
            // lvProducts
            // 
            this.lvProducts.CheckBoxes = true;
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProductCode,
            this.chPrice,
            this.chQty,
            this.chDescription});
            this.lvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProducts.Enabled = false;
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.Location = new System.Drawing.Point(0, 131);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(840, 605);
            this.lvProducts.TabIndex = 1;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvProducts_ItemChecked);
            // 
            // chProductCode
            // 
            this.chProductCode.Text = "Product Code";
            this.chProductCode.Width = 107;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 150;
            // 
            // chQty
            // 
            this.chQty.Text = "Qty";
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 539;
            // 
            // pCreateOrder
            // 
            this.pCreateOrder.Controls.Add(this.lSubTotal);
            this.pCreateOrder.Controls.Add(this.bViewOrders);
            this.pCreateOrder.Controls.Add(this.bCreateNewOrder);
            this.pCreateOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCreateOrder.Location = new System.Drawing.Point(0, 636);
            this.pCreateOrder.Name = "pCreateOrder";
            this.pCreateOrder.Size = new System.Drawing.Size(840, 100);
            this.pCreateOrder.TabIndex = 2;
            // 
            // lSubTotal
            // 
            this.lSubTotal.AutoSize = true;
            this.lSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lSubTotal.Location = new System.Drawing.Point(24, 19);
            this.lSubTotal.Name = "lSubTotal";
            this.lSubTotal.Size = new System.Drawing.Size(0, 20);
            this.lSubTotal.TabIndex = 6;
            // 
            // bViewOrders
            // 
            this.bViewOrders.Enabled = false;
            this.bViewOrders.Location = new System.Drawing.Point(195, 53);
            this.bViewOrders.Name = "bViewOrders";
            this.bViewOrders.Size = new System.Drawing.Size(165, 29);
            this.bViewOrders.TabIndex = 5;
            this.bViewOrders.Text = "View Orders";
            this.bViewOrders.UseVisualStyleBackColor = true;
            this.bViewOrders.Click += new System.EventHandler(this.bViewOrders_Click);
            // 
            // bCreateNewOrder
            // 
            this.bCreateNewOrder.Enabled = false;
            this.bCreateNewOrder.Location = new System.Drawing.Point(24, 53);
            this.bCreateNewOrder.Name = "bCreateNewOrder";
            this.bCreateNewOrder.Size = new System.Drawing.Size(165, 29);
            this.bCreateNewOrder.TabIndex = 4;
            this.bCreateNewOrder.Text = "Create New Order";
            this.bCreateNewOrder.UseVisualStyleBackColor = true;
            this.bCreateNewOrder.Click += new System.EventHandler(this.bCreateNewOrder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 736);
            this.Controls.Add(this.pCreateOrder);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.gbSupplierDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbSupplierDetails.ResumeLayout(false);
            this.gbSupplierDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersRepositoryBindingSource)).EndInit();
            this.pCreateOrder.ResumeLayout(false);
            this.pCreateOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbSupplierDetails;
        private Label lSupplierList;
        private ComboBox cbSupplierList;
        private BindingSource supplierBindingSource;
        private BindingSource suppliersRepositoryBindingSource;
        private ListView lvProducts;
        private ColumnHeader chProductCode;
        private ColumnHeader chPrice;
        private ColumnHeader chDescription;
        private Panel pCreateOrder;
        private Button bCaptureNewSupplier;
        private Button bCaptureNewProduct;
        private Button bViewOrders;
        private Button bCreateNewOrder;
        private ColumnHeader chQty;
        private Label lSubTotal;
    }
}