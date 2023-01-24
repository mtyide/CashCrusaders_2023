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
            this.chDescription = new System.Windows.Forms.ColumnHeader();
            this.pCreateOrder = new System.Windows.Forms.Panel();
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
            this.gbSupplierDetails.Name = "gbSupplierDetails";
            this.gbSupplierDetails.Size = new System.Drawing.Size(800, 130);
            this.gbSupplierDetails.TabIndex = 0;
            this.gbSupplierDetails.TabStop = false;
            this.gbSupplierDetails.Text = "Supplier Details";
            // 
            // bCaptureNewSupplier
            // 
            this.bCaptureNewSupplier.Location = new System.Drawing.Point(623, 83);
            this.bCaptureNewSupplier.Name = "bCaptureNewSupplier";
            this.bCaptureNewSupplier.Size = new System.Drawing.Size(165, 29);
            this.bCaptureNewSupplier.TabIndex = 4;
            this.bCaptureNewSupplier.Text = "Capture New Supplier";
            this.bCaptureNewSupplier.UseVisualStyleBackColor = true;
            // 
            // bCaptureNewProduct
            // 
            this.bCaptureNewProduct.Location = new System.Drawing.Point(623, 48);
            this.bCaptureNewProduct.Name = "bCaptureNewProduct";
            this.bCaptureNewProduct.Size = new System.Drawing.Size(165, 29);
            this.bCaptureNewProduct.TabIndex = 3;
            this.bCaptureNewProduct.Text = "Capture New Product";
            this.bCaptureNewProduct.UseVisualStyleBackColor = true;
            // 
            // bViewProducts
            // 
            this.bViewProducts.Location = new System.Drawing.Point(467, 48);
            this.bViewProducts.Name = "bViewProducts";
            this.bViewProducts.Size = new System.Drawing.Size(150, 29);
            this.bViewProducts.TabIndex = 2;
            this.bViewProducts.Text = "View Products";
            this.bViewProducts.UseVisualStyleBackColor = true;
            this.bViewProducts.Click += new System.EventHandler(this.bViewProducts_Click);
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
            this.cbSupplierList.Size = new System.Drawing.Size(352, 28);
            this.cbSupplierList.TabIndex = 0;
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
            this.chDescription});
            this.lvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProducts.GridLines = true;
            this.lvProducts.Location = new System.Drawing.Point(0, 130);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(800, 606);
            this.lvProducts.TabIndex = 1;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
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
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 539;
            // 
            // pCreateOrder
            // 
            this.pCreateOrder.Controls.Add(this.bViewOrders);
            this.pCreateOrder.Controls.Add(this.bCreateNewOrder);
            this.pCreateOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCreateOrder.Location = new System.Drawing.Point(0, 647);
            this.pCreateOrder.Name = "pCreateOrder";
            this.pCreateOrder.Size = new System.Drawing.Size(800, 89);
            this.pCreateOrder.TabIndex = 2;
            // 
            // bViewOrders
            // 
            this.bViewOrders.Location = new System.Drawing.Point(401, 22);
            this.bViewOrders.Name = "bViewOrders";
            this.bViewOrders.Size = new System.Drawing.Size(165, 29);
            this.bViewOrders.TabIndex = 5;
            this.bViewOrders.Text = "View Orders";
            this.bViewOrders.UseVisualStyleBackColor = true;
            // 
            // bCreateNewOrder
            // 
            this.bCreateNewOrder.Location = new System.Drawing.Point(230, 22);
            this.bCreateNewOrder.Name = "bCreateNewOrder";
            this.bCreateNewOrder.Size = new System.Drawing.Size(165, 29);
            this.bCreateNewOrder.TabIndex = 4;
            this.bCreateNewOrder.Text = "Create New Order";
            this.bCreateNewOrder.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 736);
            this.Controls.Add(this.pCreateOrder);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.gbSupplierDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Purchase Order Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbSupplierDetails.ResumeLayout(false);
            this.gbSupplierDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersRepositoryBindingSource)).EndInit();
            this.pCreateOrder.ResumeLayout(false);
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
    }
}