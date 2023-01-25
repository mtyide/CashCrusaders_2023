namespace CashCrusaders.App
{
    partial class CaptureSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureSupplier));
            this.gbCaptureSupplier = new System.Windows.Forms.GroupBox();
            this.lSupplierCodeDesc = new System.Windows.Forms.Label();
            this.lSupplierCode = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.gbCaptureSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCaptureSupplier
            // 
            this.gbCaptureSupplier.Controls.Add(this.lSupplierCodeDesc);
            this.gbCaptureSupplier.Controls.Add(this.lSupplierCode);
            this.gbCaptureSupplier.Controls.Add(this.lName);
            this.gbCaptureSupplier.Controls.Add(this.tbName);
            this.gbCaptureSupplier.Controls.Add(this.bSave);
            this.gbCaptureSupplier.Location = new System.Drawing.Point(17, 17);
            this.gbCaptureSupplier.Name = "gbCaptureSupplier";
            this.gbCaptureSupplier.Size = new System.Drawing.Size(612, 205);
            this.gbCaptureSupplier.TabIndex = 1;
            this.gbCaptureSupplier.TabStop = false;
            this.gbCaptureSupplier.Text = "Capture | Save Supplier";
            // 
            // lSupplierCodeDesc
            // 
            this.lSupplierCodeDesc.AutoSize = true;
            this.lSupplierCodeDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lSupplierCodeDesc.Location = new System.Drawing.Point(174, 96);
            this.lSupplierCodeDesc.Name = "lSupplierCodeDesc";
            this.lSupplierCodeDesc.Size = new System.Drawing.Size(0, 20);
            this.lSupplierCodeDesc.TabIndex = 4;
            // 
            // lSupplierCode
            // 
            this.lSupplierCode.AutoSize = true;
            this.lSupplierCode.Location = new System.Drawing.Point(16, 96);
            this.lSupplierCode.Name = "lSupplierCode";
            this.lSupplierCode.Size = new System.Drawing.Size(47, 20);
            this.lSupplierCode.TabIndex = 3;
            this.lSupplierCode.Text = "Code:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(16, 50);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(52, 20);
            this.lName.TabIndex = 1;
            this.lName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(174, 50);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(351, 27);
            this.tbName.TabIndex = 2;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(174, 138);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(130, 29);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // CaptureSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 244);
            this.Controls.Add(this.gbCaptureSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaptureSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture New Supplier";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CaptureSupplier_Load);
            this.gbCaptureSupplier.ResumeLayout(false);
            this.gbCaptureSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbCaptureSupplier;
        private Label lSupplierCodeDesc;
        private Label lSupplierCode;
        private Label lName;
        private TextBox tbName;
        private Button bSave;
    }
}