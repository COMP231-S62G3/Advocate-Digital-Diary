namespace AdvocateDigitalDiary
{
    partial class frmCaseTypesList
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelCaseType = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCaseTypeCancle = new System.Windows.Forms.Button();
            this.btnSaveCaseType = new System.Windows.Forms.Button();
            this.txtCaeTypeDescription = new System.Windows.Forms.TextBox();
            this.lblCaseTypeDescription = new System.Windows.Forms.Label();
            this.txtCaseTypeName = new System.Windows.Forms.TextBox();
            this.lblCaseTypeName = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelCaseType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(463, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslabelCaseType
            // 
            this.sslabelCaseType.Name = "sslabelCaseType";
            this.sslabelCaseType.Size = new System.Drawing.Size(16, 17);
            this.sslabelCaseType.Text = "...";
            // 
            // btnCaseTypeCancle
            // 
            this.btnCaseTypeCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCaseTypeCancle.Location = new System.Drawing.Point(285, 214);
            this.btnCaseTypeCancle.Name = "btnCaseTypeCancle";
            this.btnCaseTypeCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCaseTypeCancle.TabIndex = 10;
            this.btnCaseTypeCancle.Text = "Close";
            this.btnCaseTypeCancle.UseVisualStyleBackColor = true;
            // 
            // btnSaveCaseType
            // 
            this.btnSaveCaseType.Location = new System.Drawing.Point(204, 214);
            this.btnSaveCaseType.Name = "btnSaveCaseType";
            this.btnSaveCaseType.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCaseType.TabIndex = 8;
            this.btnSaveCaseType.Text = "Save";
            this.btnSaveCaseType.UseVisualStyleBackColor = true;
            // 
            // txtCaeTypeDescription
            // 
            this.txtCaeTypeDescription.Location = new System.Drawing.Point(72, 35);
            this.txtCaeTypeDescription.MaxLength = 100;
            this.txtCaeTypeDescription.Multiline = true;
            this.txtCaeTypeDescription.Name = "txtCaeTypeDescription";
            this.txtCaeTypeDescription.Size = new System.Drawing.Size(288, 162);
            this.txtCaeTypeDescription.TabIndex = 7;
            // 
            // lblCaseTypeDescription
            // 
            this.lblCaseTypeDescription.AutoSize = true;
            this.lblCaseTypeDescription.Location = new System.Drawing.Point(6, 38);
            this.lblCaseTypeDescription.Name = "lblCaseTypeDescription";
            this.lblCaseTypeDescription.Size = new System.Drawing.Size(60, 13);
            this.lblCaseTypeDescription.TabIndex = 9;
            this.lblCaseTypeDescription.Text = "Description";
            // 
            // txtCaseTypeName
            // 
            this.txtCaseTypeName.Location = new System.Drawing.Point(72, 9);
            this.txtCaseTypeName.MaxLength = 30;
            this.txtCaseTypeName.Name = "txtCaseTypeName";
            this.txtCaseTypeName.Size = new System.Drawing.Size(288, 20);
            this.txtCaseTypeName.TabIndex = 5;
            // 
            // lblCaseTypeName
            // 
            this.lblCaseTypeName.AutoSize = true;
            this.lblCaseTypeName.Location = new System.Drawing.Point(31, 12);
            this.lblCaseTypeName.Name = "lblCaseTypeName";
            this.lblCaseTypeName.Size = new System.Drawing.Size(35, 13);
            this.lblCaseTypeName.TabIndex = 6;
            this.lblCaseTypeName.Text = "Name";
            // 
            // frmCaseTypesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 376);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCaseTypeCancle);
            this.Controls.Add(this.btnSaveCaseType);
            this.Controls.Add(this.txtCaeTypeDescription);
            this.Controls.Add(this.lblCaseTypeDescription);
            this.Controls.Add(this.txtCaseTypeName);
            this.Controls.Add(this.lblCaseTypeName);
            this.Name = "frmCaseTypesList";
            this.Text = "Case Type";
            this.Load += new System.EventHandler(this.frmCaseTypesList_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelCaseType;
        private System.Windows.Forms.Button btnCaseTypeCancle;
        private System.Windows.Forms.Button btnSaveCaseType;
        private System.Windows.Forms.TextBox txtCaeTypeDescription;
        private System.Windows.Forms.Label lblCaseTypeDescription;
        private System.Windows.Forms.TextBox txtCaseTypeName;
        private System.Windows.Forms.Label lblCaseTypeName;
    }
}