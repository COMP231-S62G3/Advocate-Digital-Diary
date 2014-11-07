namespace AdvocateDigitalDiary
{
    partial class frmJudge
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
            this.gbJudgeGender = new System.Windows.Forms.GroupBox();
            this.rdbJudgeFemale = new System.Windows.Forms.RadioButton();
            this.rdbJudgeMale = new System.Windows.Forms.RadioButton();
            this.txtjudgeaddress = new System.Windows.Forms.TextBox();
            this.lbljudgeaddress = new System.Windows.Forms.Label();
            this.txtJudgeName = new System.Windows.Forms.TextBox();
            this.lblJudgeName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelJudge = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancelJudge = new System.Windows.Forms.Button();
            this.btnSaveJudge = new System.Windows.Forms.Button();
            this.txtJudgePhone = new System.Windows.Forms.TextBox();
            this.lblJudgePhone = new System.Windows.Forms.Label();
            this.gbJudgeGender.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbJudgeGender
            // 
            this.gbJudgeGender.Controls.Add(this.rdbJudgeFemale);
            this.gbJudgeGender.Controls.Add(this.rdbJudgeMale);
            this.gbJudgeGender.Location = new System.Drawing.Point(48, 90);
            this.gbJudgeGender.Margin = new System.Windows.Forms.Padding(4);
            this.gbJudgeGender.Name = "gbJudgeGender";
            this.gbJudgeGender.Padding = new System.Windows.Forms.Padding(4);
            this.gbJudgeGender.Size = new System.Drawing.Size(316, 108);
            this.gbJudgeGender.TabIndex = 13;
            this.gbJudgeGender.TabStop = false;
            this.gbJudgeGender.Text = "Gender";
            this.gbJudgeGender.Enter += new System.EventHandler(this.gbJudgeGender_Enter);
            // 
            // rdbJudgeFemale
            // 
            this.rdbJudgeFemale.AutoSize = true;
            this.rdbJudgeFemale.Location = new System.Drawing.Point(108, 63);
            this.rdbJudgeFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbJudgeFemale.Name = "rdbJudgeFemale";
            this.rdbJudgeFemale.Size = new System.Drawing.Size(75, 21);
            this.rdbJudgeFemale.TabIndex = 3;
            this.rdbJudgeFemale.Text = "Female";
            this.rdbJudgeFemale.UseVisualStyleBackColor = true;
            this.rdbJudgeFemale.CheckedChanged += new System.EventHandler(this.rdbJudgeFemale_CheckedChanged);
            // 
            // rdbJudgeMale
            // 
            this.rdbJudgeMale.AutoSize = true;
            this.rdbJudgeMale.Checked = true;
            this.rdbJudgeMale.Location = new System.Drawing.Point(108, 34);
            this.rdbJudgeMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbJudgeMale.Name = "rdbJudgeMale";
            this.rdbJudgeMale.Size = new System.Drawing.Size(59, 21);
            this.rdbJudgeMale.TabIndex = 2;
            this.rdbJudgeMale.TabStop = true;
            this.rdbJudgeMale.Text = "Male";
            this.rdbJudgeMale.UseVisualStyleBackColor = true;
            this.rdbJudgeMale.CheckedChanged += new System.EventHandler(this.rdbJudgeMale_CheckedChanged);
            // 
            // txtjudgeaddress
            // 
            this.txtjudgeaddress.Location = new System.Drawing.Point(112, 47);
            this.txtjudgeaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtjudgeaddress.Name = "txtjudgeaddress";
            this.txtjudgeaddress.Size = new System.Drawing.Size(251, 22);
            this.txtjudgeaddress.TabIndex = 11;
            this.txtjudgeaddress.TextChanged += new System.EventHandler(this.txtjudgeaddress_TextChanged);
            // 
            // lbljudgeaddress
            // 
            this.lbljudgeaddress.AutoSize = true;
            this.lbljudgeaddress.Location = new System.Drawing.Point(44, 50);
            this.lbljudgeaddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbljudgeaddress.Name = "lbljudgeaddress";
            this.lbljudgeaddress.Size = new System.Drawing.Size(60, 17);
            this.lbljudgeaddress.TabIndex = 12;
            this.lbljudgeaddress.Text = "Address";
            this.lbljudgeaddress.Click += new System.EventHandler(this.lbljudgeaddress_Click);
            // 
            // txtJudgeName
            // 
            this.txtJudgeName.Location = new System.Drawing.Point(112, 15);
            this.txtJudgeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtJudgeName.Name = "txtJudgeName";
            this.txtJudgeName.Size = new System.Drawing.Size(251, 22);
            this.txtJudgeName.TabIndex = 8;
            this.txtJudgeName.TextChanged += new System.EventHandler(this.txtJudgeName_TextChanged);
            // 
            // lblJudgeName
            // 
            this.lblJudgeName.AutoSize = true;
            this.lblJudgeName.Location = new System.Drawing.Point(57, 18);
            this.lblJudgeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudgeName.Name = "lblJudgeName";
            this.lblJudgeName.Size = new System.Drawing.Size(45, 17);
            this.lblJudgeName.TabIndex = 9;
            this.lblJudgeName.Text = "Name";
            this.lblJudgeName.Click += new System.EventHandler(this.lblJudgeName_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelJudge});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(429, 25);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // sslabelJudge
            // 
            this.sslabelJudge.Name = "sslabelJudge";
            this.sslabelJudge.Size = new System.Drawing.Size(18, 20);
            this.sslabelJudge.Text = "...";
            // 
            // btnCancelJudge
            // 
            this.btnCancelJudge.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelJudge.Location = new System.Drawing.Point(264, 266);
            this.btnCancelJudge.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelJudge.Name = "btnCancelJudge";
            this.btnCancelJudge.Size = new System.Drawing.Size(100, 28);
            this.btnCancelJudge.TabIndex = 16;
            this.btnCancelJudge.Text = "Close";
            this.btnCancelJudge.UseVisualStyleBackColor = true;
            this.btnCancelJudge.Click += new System.EventHandler(this.btnCancelJudge_Click);
            // 
            // btnSaveJudge
            // 
            this.btnSaveJudge.Location = new System.Drawing.Point(156, 266);
            this.btnSaveJudge.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveJudge.Name = "btnSaveJudge";
            this.btnSaveJudge.Size = new System.Drawing.Size(100, 28);
            this.btnSaveJudge.TabIndex = 15;
            this.btnSaveJudge.Text = "Save";
            this.btnSaveJudge.UseVisualStyleBackColor = true;
            this.btnSaveJudge.Click += new System.EventHandler(this.btnSaveJudge_Click);
            // 
            // txtJudgePhone
            // 
            this.txtJudgePhone.Location = new System.Drawing.Point(116, 219);
            this.txtJudgePhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtJudgePhone.Name = "txtJudgePhone";
            this.txtJudgePhone.Size = new System.Drawing.Size(247, 22);
            this.txtJudgePhone.TabIndex = 14;
            this.txtJudgePhone.TextChanged += new System.EventHandler(this.txtJudgePhone_TextChanged);
            // 
            // lblJudgePhone
            // 
            this.lblJudgePhone.AutoSize = true;
            this.lblJudgePhone.Location = new System.Drawing.Point(57, 223);
            this.lblJudgePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudgePhone.Name = "lblJudgePhone";
            this.lblJudgePhone.Size = new System.Drawing.Size(49, 17);
            this.lblJudgePhone.TabIndex = 10;
            this.lblJudgePhone.Text = "Phone";
            this.lblJudgePhone.Click += new System.EventHandler(this.lblJudgePhone_Click);
            // 
            // frmJudge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 370);
            this.Controls.Add(this.gbJudgeGender);
            this.Controls.Add(this.txtjudgeaddress);
            this.Controls.Add(this.lbljudgeaddress);
            this.Controls.Add(this.txtJudgeName);
            this.Controls.Add(this.lblJudgeName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancelJudge);
            this.Controls.Add(this.btnSaveJudge);
            this.Controls.Add(this.txtJudgePhone);
            this.Controls.Add(this.lblJudgePhone);
            this.Name = "frmJudge";
            this.Text = "Judge";
            this.Load += new System.EventHandler(this.frmJudge_Load);
            this.gbJudgeGender.ResumeLayout(false);
            this.gbJudgeGender.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbJudgeGender;
        private System.Windows.Forms.RadioButton rdbJudgeFemale;
        private System.Windows.Forms.RadioButton rdbJudgeMale;
        private System.Windows.Forms.TextBox txtjudgeaddress;
        private System.Windows.Forms.Label lbljudgeaddress;
        private System.Windows.Forms.TextBox txtJudgeName;
        private System.Windows.Forms.Label lblJudgeName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelJudge;
        private System.Windows.Forms.Button btnCancelJudge;
        private System.Windows.Forms.Button btnSaveJudge;
        private System.Windows.Forms.TextBox txtJudgePhone;
        private System.Windows.Forms.Label lblJudgePhone;
    }
}