namespace AdvocateDigitalDiary
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelCaseType = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCaeTypeDescription = new System.Windows.Forms.TextBox();
            this.btnCaseTypeCancle = new System.Windows.Forms.Button();
            this.btnSaveCaseType = new System.Windows.Forms.Button();
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
<<<<<<< HEAD
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(455, 22);
            this.statusStrip1.TabIndex = 11;
=======
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(612, 25);
            this.statusStrip1.TabIndex = 18;
>>>>>>> origin/Design-Master-page
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // sslabelCaseType
            // 
            this.sslabelCaseType.Name = "sslabelCaseType";
            this.sslabelCaseType.Size = new System.Drawing.Size(18, 20);
            this.sslabelCaseType.Text = "...";
            // 
            // txtCaeTypeDescription
            // 
            this.txtCaeTypeDescription.Location = new System.Drawing.Point(96, 37);
            this.txtCaeTypeDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaeTypeDescription.MaxLength = 100;
            this.txtCaeTypeDescription.Multiline = true;
            this.txtCaeTypeDescription.Name = "txtCaeTypeDescription";
            this.txtCaeTypeDescription.Size = new System.Drawing.Size(383, 198);
            this.txtCaeTypeDescription.TabIndex = 14;
            // 
            // btnCaseTypeCancle
            // 
            this.btnCaseTypeCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCaseTypeCancle.Location = new System.Drawing.Point(380, 257);
            this.btnCaseTypeCancle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaseTypeCancle.Name = "btnCaseTypeCancle";
            this.btnCaseTypeCancle.Size = new System.Drawing.Size(100, 28);
            this.btnCaseTypeCancle.TabIndex = 17;
            this.btnCaseTypeCancle.Text = "Close";
            this.btnCaseTypeCancle.UseVisualStyleBackColor = true;
            this.btnCaseTypeCancle.Click += new System.EventHandler(this.btnCaseTypeCancle_Click);
            // 
            // btnSaveCaseType
            // 
            this.btnSaveCaseType.Location = new System.Drawing.Point(272, 257);
            this.btnSaveCaseType.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCaseType.Name = "btnSaveCaseType";
            this.btnSaveCaseType.Size = new System.Drawing.Size(100, 28);
            this.btnSaveCaseType.TabIndex = 15;
            this.btnSaveCaseType.Text = "Save";
            this.btnSaveCaseType.UseVisualStyleBackColor = true;
            this.btnSaveCaseType.Click += new System.EventHandler(this.btnSaveCaseType_Click);
            // 
<<<<<<< HEAD
            // txtCaeTypeDescription
            // 
            this.txtCaeTypeDescription.Location = new System.Drawing.Point(72, 34);
            this.txtCaeTypeDescription.MaxLength = 100;
            this.txtCaeTypeDescription.Multiline = true;
            this.txtCaeTypeDescription.Name = "txtCaeTypeDescription";
            this.txtCaeTypeDescription.Size = new System.Drawing.Size(288, 162);
            this.txtCaeTypeDescription.TabIndex = 7;
            this.txtCaeTypeDescription.TextChanged += new System.EventHandler(this.txtCaeTypeDescription_TextChanged);
            // 
=======
>>>>>>> origin/Design-Master-page
            // lblCaseTypeDescription
            // 
            this.lblCaseTypeDescription.AutoSize = true;
            this.lblCaseTypeDescription.Location = new System.Drawing.Point(8, 41);
            this.lblCaseTypeDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaseTypeDescription.Name = "lblCaseTypeDescription";
            this.lblCaseTypeDescription.Size = new System.Drawing.Size(79, 17);
            this.lblCaseTypeDescription.TabIndex = 16;
            this.lblCaseTypeDescription.Text = "Description";
            this.lblCaseTypeDescription.Click += new System.EventHandler(this.lblCaseTypeDescription_Click);
            // 
            // txtCaseTypeName
            // 
            this.txtCaseTypeName.Location = new System.Drawing.Point(96, 5);
            this.txtCaseTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaseTypeName.MaxLength = 30;
            this.txtCaseTypeName.Name = "txtCaseTypeName";
<<<<<<< HEAD
            this.txtCaseTypeName.Size = new System.Drawing.Size(288, 20);
            this.txtCaseTypeName.TabIndex = 5;
            this.txtCaseTypeName.TextChanged += new System.EventHandler(this.txtCaseTypeName_TextChanged);
=======
            this.txtCaseTypeName.Size = new System.Drawing.Size(383, 22);
            this.txtCaseTypeName.TabIndex = 12;
>>>>>>> origin/Design-Master-page
            // 
            // lblCaseTypeName
            // 
            this.lblCaseTypeName.AutoSize = true;
            this.lblCaseTypeName.Location = new System.Drawing.Point(41, 9);
            this.lblCaseTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaseTypeName.Name = "lblCaseTypeName";
            this.lblCaseTypeName.Size = new System.Drawing.Size(45, 17);
            this.lblCaseTypeName.TabIndex = 13;
            this.lblCaseTypeName.Text = "Name";
            this.lblCaseTypeName.Click += new System.EventHandler(this.lblCaseTypeName_Click);
            // 
            // frmCaseType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(455, 292);
=======
            this.ClientSize = new System.Drawing.Size(612, 511);
>>>>>>> origin/Design-Master-page
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtCaeTypeDescription);
            this.Controls.Add(this.btnCaseTypeCancle);
            this.Controls.Add(this.btnSaveCaseType);
            this.Controls.Add(this.lblCaseTypeDescription);
            this.Controls.Add(this.txtCaseTypeName);
            this.Controls.Add(this.lblCaseTypeName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCaseType";
<<<<<<< HEAD
            this.Text = "Case Types";
=======
            this.Text = "Case Type";
            this.Load += new System.EventHandler(this.frmCaseType_Load);
>>>>>>> origin/Design-Master-page
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelCaseType;
        private System.Windows.Forms.TextBox txtCaeTypeDescription;
        private System.Windows.Forms.Button btnCaseTypeCancle;
        private System.Windows.Forms.Button btnSaveCaseType;
        private System.Windows.Forms.Label lblCaseTypeDescription;
        private System.Windows.Forms.TextBox txtCaseTypeName;
        private System.Windows.Forms.Label lblCaseTypeName;


    }
}