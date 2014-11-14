namespace advocate
{
    partial class frmCaseType
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
            this.lblCaseTypeName = new System.Windows.Forms.Label();
            this.txtCaseTypeName = new System.Windows.Forms.TextBox();
            this.lblCaseTypeDescription = new System.Windows.Forms.Label();
            this.txtCaeTypeDescription = new System.Windows.Forms.TextBox();
            this.btnSaveCaseType = new System.Windows.Forms.Button();
            this.btnCaseTypeCancle = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelCaseType = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaseTypeName
            // 
            this.lblCaseTypeName.AutoSize = true;
            this.lblCaseTypeName.Location = new System.Drawing.Point(31, 20);
            this.lblCaseTypeName.Name = "lblCaseTypeName";
            this.lblCaseTypeName.Size = new System.Drawing.Size(35, 13);
            this.lblCaseTypeName.TabIndex = 0;
            this.lblCaseTypeName.Text = "Name";
            // 
            // txtCaseTypeName
            // 
            this.txtCaseTypeName.Location = new System.Drawing.Point(72, 17);
            this.txtCaseTypeName.MaxLength = 30;
            this.txtCaseTypeName.Name = "txtCaseTypeName";
            this.txtCaseTypeName.Size = new System.Drawing.Size(288, 20);
            this.txtCaseTypeName.TabIndex = 0;
            // 
            // lblCaseTypeDescription
            // 
            this.lblCaseTypeDescription.AutoSize = true;
            this.lblCaseTypeDescription.Location = new System.Drawing.Point(6, 46);
            this.lblCaseTypeDescription.Name = "lblCaseTypeDescription";
            this.lblCaseTypeDescription.Size = new System.Drawing.Size(60, 13);
            this.lblCaseTypeDescription.TabIndex = 2;
            this.lblCaseTypeDescription.Text = "Description";
            // 
            // txtCaeTypeDescription
            // 
            this.txtCaeTypeDescription.Location = new System.Drawing.Point(72, 43);
            this.txtCaeTypeDescription.MaxLength = 100;
            this.txtCaeTypeDescription.Multiline = true;
            this.txtCaeTypeDescription.Name = "txtCaeTypeDescription";
            this.txtCaeTypeDescription.Size = new System.Drawing.Size(288, 162);
            this.txtCaeTypeDescription.TabIndex = 1;
            // 
            // btnSaveCaseType
            // 
            this.btnSaveCaseType.Location = new System.Drawing.Point(204, 222);
            this.btnSaveCaseType.Name = "btnSaveCaseType";
            this.btnSaveCaseType.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCaseType.TabIndex = 2;
            this.btnSaveCaseType.Text = "Save";
            this.btnSaveCaseType.UseVisualStyleBackColor = true;
            this.btnSaveCaseType.Click += new System.EventHandler(this.btnSaveCaseType_Click);
            // 
            // btnCaseTypeCancle
            // 
            this.btnCaseTypeCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCaseTypeCancle.Location = new System.Drawing.Point(285, 222);
            this.btnCaseTypeCancle.Name = "btnCaseTypeCancle";
            this.btnCaseTypeCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCaseTypeCancle.TabIndex = 3;
            this.btnCaseTypeCancle.Text = "Close";
            this.btnCaseTypeCancle.UseVisualStyleBackColor = true;
            this.btnCaseTypeCancle.Click += new System.EventHandler(this.btnCaseTypeCancle_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelCaseType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(385, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslabelCaseType
            // 
            this.sslabelCaseType.Name = "sslabelCaseType";
            this.sslabelCaseType.Size = new System.Drawing.Size(16, 17);
            this.sslabelCaseType.Text = "...";
            // 
            // frmCaseType
            // 
            this.AcceptButton = this.btnSaveCaseType;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCaseTypeCancle;
            this.ClientSize = new System.Drawing.Size(385, 282);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCaseTypeCancle);
            this.Controls.Add(this.btnSaveCaseType);
            this.Controls.Add(this.txtCaeTypeDescription);
            this.Controls.Add(this.lblCaseTypeDescription);
            this.Controls.Add(this.txtCaseTypeName);
            this.Controls.Add(this.lblCaseTypeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaseType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Case Type";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaseTypeName;
        private System.Windows.Forms.TextBox txtCaseTypeName;
        private System.Windows.Forms.Label lblCaseTypeDescription;
        private System.Windows.Forms.TextBox txtCaeTypeDescription;
        private System.Windows.Forms.Button btnSaveCaseType;
        private System.Windows.Forms.Button btnCaseTypeCancle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelCaseType;
    }
}