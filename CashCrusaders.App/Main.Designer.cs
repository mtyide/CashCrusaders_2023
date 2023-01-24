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
            this.cbSupplierList = new System.Windows.Forms.ComboBox();
            this.lSupplierList = new System.Windows.Forms.Label();
            this.suppliersRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbSupplierDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSupplierDetails
            // 
            this.gbSupplierDetails.Controls.Add(this.lSupplierList);
            this.gbSupplierDetails.Controls.Add(this.cbSupplierList);
            this.gbSupplierDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSupplierDetails.Location = new System.Drawing.Point(0, 0);
            this.gbSupplierDetails.Name = "gbSupplierDetails";
            this.gbSupplierDetails.Size = new System.Drawing.Size(800, 101);
            this.gbSupplierDetails.TabIndex = 0;
            this.gbSupplierDetails.TabStop = false;
            this.gbSupplierDetails.Text = "Supplier Details";
            // 
            // cbSupplierList
            // 
            this.cbSupplierList.DataSource = this.supplierBindingSource;
            this.cbSupplierList.DisplayMember = "Name";
            this.cbSupplierList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierList.FormattingEnabled = true;
            this.cbSupplierList.Location = new System.Drawing.Point(108, 42);
            this.cbSupplierList.Name = "cbSupplierList";
            this.cbSupplierList.Size = new System.Drawing.Size(660, 28);
            this.cbSupplierList.TabIndex = 0;
            // 
            // lSupplierList
            // 
            this.lSupplierList.AutoSize = true;
            this.lSupplierList.Location = new System.Drawing.Point(12, 50);
            this.lSupplierList.Name = "lSupplierList";
            this.lSupplierList.Size = new System.Drawing.Size(90, 20);
            this.lSupplierList.TabIndex = 1;
            this.lSupplierList.Text = "Supplier List";
            // 
            // suppliersRepositoryBindingSource
            // 
            this.suppliersRepositoryBindingSource.DataSource = typeof(CashCrusaders.Data.Repositories.SuppliersRepository);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(CashCrusaders.Domain.Models.Supplier);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 736);
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
            ((System.ComponentModel.ISupportInitialize)(this.suppliersRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbSupplierDetails;
        private Label lSupplierList;
        private ComboBox cbSupplierList;
        private BindingSource supplierBindingSource;
        private BindingSource suppliersRepositoryBindingSource;
    }
}