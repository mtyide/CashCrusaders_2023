namespace CashCrusaders.App
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.lvOrders = new System.Windows.Forms.ListView();
            this.chNumber = new System.Windows.Forms.ColumnHeader();
            this.chDate = new System.Windows.Forms.ColumnHeader();
            this.chTax = new System.Windows.Forms.ColumnHeader();
            this.chGrandTotal = new System.Windows.Forms.ColumnHeader();
            this.chSupplierCode = new System.Windows.Forms.ColumnHeader();
            this.chSupplierName = new System.Windows.Forms.ColumnHeader();
            this.lvOrderLines = new System.Windows.Forms.ListView();
            this.chQty = new System.Windows.Forms.ColumnHeader();
            this.chSubTotal = new System.Windows.Forms.ColumnHeader();
            this.chDescription = new System.Windows.Forms.ColumnHeader();
            this.chCode = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumber,
            this.chDate,
            this.chTax,
            this.chGrandTotal,
            this.chSupplierCode,
            this.chSupplierName});
            this.lvOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvOrders.Enabled = false;
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.GridLines = true;
            this.lvOrders.Location = new System.Drawing.Point(0, 0);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(800, 171);
            this.lvOrders.TabIndex = 0;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            this.lvOrders.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvOrders_ItemSelectionChanged);
            // 
            // chNumber
            // 
            this.chNumber.Text = "Number";
            this.chNumber.Width = 56;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 36;
            // 
            // chTax
            // 
            this.chTax.Text = "Tax";
            this.chTax.Width = 30;
            // 
            // chGrandTotal
            // 
            this.chGrandTotal.Text = "Grand Total";
            this.chGrandTotal.Width = 73;
            // 
            // chSupplierCode
            // 
            this.chSupplierCode.Text = "Supplier Code";
            this.chSupplierCode.Width = 86;
            // 
            // chSupplierName
            // 
            this.chSupplierName.Text = "Supplier Name";
            this.chSupplierName.Width = 515;
            // 
            // lvOrderLines
            // 
            this.lvOrderLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chQty,
            this.chSubTotal,
            this.chDescription,
            this.chCode,
            this.chPrice});
            this.lvOrderLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOrderLines.Enabled = false;
            this.lvOrderLines.FullRowSelect = true;
            this.lvOrderLines.GridLines = true;
            this.lvOrderLines.Location = new System.Drawing.Point(0, 171);
            this.lvOrderLines.Name = "lvOrderLines";
            this.lvOrderLines.Size = new System.Drawing.Size(800, 353);
            this.lvOrderLines.TabIndex = 1;
            this.lvOrderLines.UseCompatibleStateImageBehavior = false;
            this.lvOrderLines.View = System.Windows.Forms.View.Details;
            // 
            // chQty
            // 
            this.chQty.Text = "Qty";
            this.chQty.Width = 31;
            // 
            // chSubTotal
            // 
            this.chSubTotal.Text = "Sub-Total";
            this.chSubTotal.Width = 63;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 72;
            // 
            // chCode
            // 
            this.chCode.Text = "Code";
            this.chCode.Width = 40;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 590;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.lvOrderLines);
            this.Controls.Add(this.lvOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Orders";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvOrders;
        private ListView lvOrderLines;
        private ColumnHeader chNumber;
        private ColumnHeader chDate;
        private ColumnHeader chTax;
        private ColumnHeader chGrandTotal;
        private ColumnHeader chSupplierCode;
        private ColumnHeader chSupplierName;
        private ColumnHeader chQty;
        private ColumnHeader chSubTotal;
        private ColumnHeader chDescription;
        private ColumnHeader chCode;
        private ColumnHeader chPrice;
    }
}