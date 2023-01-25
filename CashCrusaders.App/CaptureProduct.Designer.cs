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
            this.gbCaptureProduct.Location = new System.Drawing.Point(19, 9);
            this.gbCaptureProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCaptureProduct.Name = "gbCaptureProduct";
            this.gbCaptureProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCaptureProduct.Size = new System.Drawing.Size(536, 274);
            this.gbCaptureProduct.TabIndex = 0;
            this.gbCaptureProduct.TabStop = false;
            this.gbCaptureProduct.Text = "Caputure | Save Product";
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(152, 172);
            this.tbQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(75, 23);
            this.tbQty.TabIndex = 3;
            this.tbQty.Text = "0,00";
            // 
            // lQty
            // 
            this.lQty.AutoSize = true;
            this.lQty.Location = new System.Drawing.Point(14, 175);
            this.lQty.Name = "lQty";
            this.lQty.Size = new System.Drawing.Size(29, 15);
            this.lQty.TabIndex = 5;
            this.lQty.Text = "Qty:";
            // 
            // lProductCodeDesc
            // 
            this.lProductCodeDesc.AutoSize = true;
            this.lProductCodeDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lProductCodeDesc.Location = new System.Drawing.Point(152, 147);
            this.lProductCodeDesc.Name = "lProductCodeDesc";
            this.lProductCodeDesc.Size = new System.Drawing.Size(0, 15);
            this.lProductCodeDesc.TabIndex = 4;
            // 
            // lProductCode
            // 
            this.lProductCode.AutoSize = true;
            this.lProductCode.Location = new System.Drawing.Point(14, 147);
            this.lProductCode.Name = "lProductCode";
            this.lProductCode.Size = new System.Drawing.Size(38, 15);
            this.lProductCode.TabIndex = 3;
            this.lProductCode.Text = "Code:";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(14, 38);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(70, 15);
            this.lDescription.TabIndex = 1;
            this.lDescription.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(152, 38);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescription.MaxLength = 150;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(308, 98);
            this.tbDescription.TabIndex = 2;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(152, 217);
            this.bSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(114, 22);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // CaptureProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 299);
            this.Controls.Add(this.gbCaptureProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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