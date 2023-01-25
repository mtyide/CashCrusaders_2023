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
            this.bViewProducts = new System.Windows.Forms.Button();
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
            this.gbSupplierDetails.Controls.Add(this.bViewProducts);
            this.gbSupplierDetails.Controls.Add(this.lSupplierList);
            this.gbSupplierDetails.Controls.Add(this.cbSupplierList);
            this.gbSupplierDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSupplierDetails.Location = new System.Drawing.Point(0, 0);
            this.gbSupplierDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSupplierDetails.Name = "gbSupplierDetails";
            this.gbSupplierDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSupplierDetails.Size = new System.Drawing.Size(700, 98);
            this.gbSupplierDetails.TabIndex = 0;
            this.gbSupplierDetails.TabStop = false;
            this.gbSupplierDetails.Text = "Supplier Details";
            // 
            // bCaptureNewSupplier
            // 
            this.bCaptureNewSupplier.Location = new System.Drawing.Point(545, 62);
            this.bCaptureNewSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCaptureNewSupplier.Name = "bCaptureNewSupplier";
            this.bCaptureNewSupplier.Size = new System.Drawing.Size(144, 22);
            this.bCaptureNewSupplier.TabIndex = 4;
            this.bCaptureNewSupplier.Text = "Capture New Supplier";
            this.bCaptureNewSupplier.UseVisualStyleBackColor = true;
            this.bCaptureNewSupplier.Click += new System.EventHandler(this.bCaptureNewSupplier_Click);
            // 
            // bCaptureNewProduct
            // 
            this.bCaptureNewProduct.Location = new System.Drawing.Point(545, 36);
            this.bCaptureNewProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCaptureNewProduct.Name = "bCaptureNewProduct";
            this.bCaptureNewProduct.Size = new System.Drawing.Size(144, 22);
            this.bCaptureNewProduct.TabIndex = 3;
            this.bCaptureNewProduct.Text = "Capture New Product";
            this.bCaptureNewProduct.UseVisualStyleBackColor = true;
            this.bCaptureNewProduct.Click += new System.EventHandler(this.bCaptureNewProduct_Click);
            // 
            // bViewProducts
            // 
            this.bViewProducts.Location = new System.Drawing.Point(409, 36);
            this.bViewProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bViewProducts.Name = "bViewProducts";
            this.bViewProducts.Size = new System.Drawing.Size(131, 22);
            this.bViewProducts.TabIndex = 3;
            this.bViewProducts.Text = "View Products";
            this.bViewProducts.UseVisualStyleBackColor = true;
            this.bViewProducts.Click += new System.EventHandler(this.bViewProducts_Click);
            // 
            // lSupplierList
            // 
            this.lSupplierList.AutoSize = true;
            this.lSupplierList.Location = new System.Drawing.Point(5, 43);
            this.lSupplierList.Name = "lSupplierList";
            this.lSupplierList.Size = new System.Drawing.Size(71, 15);
            this.lSupplierList.TabIndex = 1;
            this.lSupplierList.Text = "Supplier List";
            // 
            // cbSupplierList
            // 
            this.cbSupplierList.DataSource = this.supplierBindingSource;
            this.cbSupplierList.DisplayMember = "Name";
            this.cbSupplierList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierList.FormattingEnabled = true;
            this.cbSupplierList.Location = new System.Drawing.Point(95, 36);
            this.cbSupplierList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSupplierList.Name = "cbSupplierList";
            this.cbSupplierList.Size = new System.Drawing.Size(308, 23);
            this.cbSupplierList.TabIndex = 2;
            this.cbSupplierList.ValueMember = "Id";
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
            this.lvProducts.GridLines = true;
            this.lvProducts.Location = new System.Drawing.Point(0, 98);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(700, 454);
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
            this.pCreateOrder.Location = new System.Drawing.Point(0, 477);
            this.pCreateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pCreateOrder.Name = "pCreateOrder";
            this.pCreateOrder.Size = new System.Drawing.Size(700, 75);
            this.pCreateOrder.TabIndex = 2;
            // 
            // lSubTotal
            // 
            this.lSubTotal.AutoSize = true;
            this.lSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lSubTotal.Location = new System.Drawing.Point(21, 14);
            this.lSubTotal.Name = "lSubTotal";
            this.lSubTotal.Size = new System.Drawing.Size(0, 15);
            this.lSubTotal.TabIndex = 6;
            // 
            // bViewOrders
            // 
            this.bViewOrders.Enabled = false;
            this.bViewOrders.Location = new System.Drawing.Point(171, 40);
            this.bViewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bViewOrders.Name = "bViewOrders";
            this.bViewOrders.Size = new System.Drawing.Size(144, 22);
            this.bViewOrders.TabIndex = 5;
            this.bViewOrders.Text = "View Orders";
            this.bViewOrders.UseVisualStyleBackColor = true;
            // 
            // bCreateNewOrder
            // 
            this.bCreateNewOrder.Enabled = false;
            this.bCreateNewOrder.Location = new System.Drawing.Point(21, 40);
            this.bCreateNewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCreateNewOrder.Name = "bCreateNewOrder";
            this.bCreateNewOrder.Size = new System.Drawing.Size(144, 22);
            this.bCreateNewOrder.TabIndex = 4;
            this.bCreateNewOrder.Text = "Create New Order";
            this.bCreateNewOrder.UseVisualStyleBackColor = true;
            this.bCreateNewOrder.Click += new System.EventHandler(this.bCreateNewOrder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 552);
            this.Controls.Add(this.pCreateOrder);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.gbSupplierDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Button bViewProducts;
        private Button bCaptureNewSupplier;
        private Button bCaptureNewProduct;
        private Button bViewOrders;
        private Button bCreateNewOrder;
        private ColumnHeader chQty;
        private Label lSubTotal;
    }
}