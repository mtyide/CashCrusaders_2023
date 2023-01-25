namespace CashCrusaders.App
{
    partial class CaptureProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureProduct));
            this.gbCaptureProduct = new System.Windows.Forms.GroupBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.lQty = new System.Windows.Forms.Label();
            this.lProductCodeDesc = new System.Windows.Forms.Label();
            this.lProductCode = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.gbCaptureProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCaptureProduct
            // 
            this.gbCaptureProduct.Controls.Add(this.tbQty);
            this.gbCaptureProduct.Controls.Add(this.lQty);
            this.gbCaptureProduct.Controls.Add(this.lProductCodeDesc);
            this.gbCaptureProduct.Controls.Add(this.lProductCode);
            this.gbCaptureProduct.Controls.Add(this.lDescription);
            this.gbCaptureProduct.Controls.Add(this.tbDescription);
            this.gbCaptureProduct.Controls.Add(this.bSave);
            this.gbCaptureProduct.Location = new System.Drawing.Point(22, 12);
            this.gbCaptureProduct.Name = "gbCaptureProduct";
            this.gbCaptureProduct.Size = new System.Drawing.Size(613, 365);
            this.gbCaptureProduct.TabIndex = 0;
            this.gbCaptureProduct.TabStop = false;
            this.gbCaptureProduct.Text = "Capture | Save Product";
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(174, 229);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(85, 27);
            this.tbQty.TabIndex = 3;
            this.tbQty.Text = "0,00";
            // 
            // lQty
            // 
            this.lQty.AutoSize = true;
            this.lQty.Location = new System.Drawing.Point(16, 233);
            this.lQty.Name = "lQty";
            this.lQty.Size = new System.Drawing.Size(35, 20);
            this.lQty.TabIndex = 5;
            this.lQty.Text = "Qty:";
            // 
            // lProductCodeDesc
            // 
            this.lProductCodeDesc.AutoSize = true;
            this.lProductCodeDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lProductCodeDesc.Location = new System.Drawing.Point(174, 196);
            this.lProductCodeDesc.Name = "lProductCodeDesc";
            this.lProductCodeDesc.Size = new System.Drawing.Size(0, 20);
            this.lProductCodeDesc.TabIndex = 4;
            // 
            // lProductCode
            // 
            this.lProductCode.AutoSize = true;
            this.lProductCode.Location = new System.Drawing.Point(16, 196);
            this.lProductCode.Name = "lProductCode";
            this.lProductCode.Size = new System.Drawing.Size(47, 20);
            this.lProductCode.TabIndex = 3;
            this.lProductCode.Text = "Code:";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(16, 51);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(88, 20);
            this.lDescription.TabIndex = 1;
            this.lDescription.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(174, 51);
            this.tbDescription.MaxLength = 150;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(351, 129);
            this.tbDescription.TabIndex = 2;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(174, 289);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(130, 29);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // CaptureProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 399);
            this.Controls.Add(this.gbCaptureProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CaptureProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture New Product";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CaptureProduct_Load);
            this.gbCaptureProduct.ResumeLayout(false);
            this.gbCaptureProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbCaptureProduct;
        private Label lDescription;
        private TextBox tbDescription;
        private Button bSave;
        private Label lProductCode;
        private Label lProductCodeDesc;
        private TextBox tbQty;
        private Label lQty;
    }
}