namespace advocate
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
            this.lblJudgeName = new System.Windows.Forms.Label();
            this.txtJudgeName = new System.Windows.Forms.TextBox();
            this.txtjudgeaddress = new System.Windows.Forms.TextBox();
            this.lbljudgeaddress = new System.Windows.Forms.Label();
            this.gbJudgeGender = new System.Windows.Forms.GroupBox();
            this.rdbJudgeFemale = new System.Windows.Forms.RadioButton();
            this.rdbJudgeMale = new System.Windows.Forms.RadioButton();
            this.lblJudgePhone = new System.Windows.Forms.Label();
            this.txtJudgePhone = new System.Windows.Forms.TextBox();
            this.btnSaveJudge = new System.Windows.Forms.Button();
            this.btnCancelJudge = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelJudge = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbJudgeGender.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJudgeName
            // 
            this.lblJudgeName.AutoSize = true;
            this.lblJudgeName.Location = new System.Drawing.Point(43, 27);
            this.lblJudgeName.Name = "lblJudgeName";
            this.lblJudgeName.Size = new System.Drawing.Size(35, 13);
            this.lblJudgeName.TabIndex = 0;
            this.lblJudgeName.Text = "Name";
            // 
            // txtJudgeName
            // 
            this.txtJudgeName.Location = new System.Drawing.Point(84, 24);
            this.txtJudgeName.Name = "txtJudgeName";
            this.txtJudgeName.Size = new System.Drawing.Size(189, 20);
            this.txtJudgeName.TabIndex = 0;
            // 
            // txtjudgeaddress
            // 
            this.txtjudgeaddress.Location = new System.Drawing.Point(84, 50);
            this.txtjudgeaddress.Name = "txtjudgeaddress";
            this.txtjudgeaddress.Size = new System.Drawing.Size(189, 20);
            this.txtjudgeaddress.TabIndex = 1;
            // 
            // lbljudgeaddress
            // 
            this.lbljudgeaddress.AutoSize = true;
            this.lbljudgeaddress.Location = new System.Drawing.Point(33, 53);
            this.lbljudgeaddress.Name = "lbljudgeaddress";
            this.lbljudgeaddress.Size = new System.Drawing.Size(45, 13);
            this.lbljudgeaddress.TabIndex = 2;
            this.lbljudgeaddress.Text = "Address";
            // 
            // gbJudgeGender
            // 
            this.gbJudgeGender.Controls.Add(this.rdbJudgeFemale);
            this.gbJudgeGender.Controls.Add(this.rdbJudgeMale);
            this.gbJudgeGender.Location = new System.Drawing.Point(36, 85);
            this.gbJudgeGender.Name = "gbJudgeGender";
            this.gbJudgeGender.Size = new System.Drawing.Size(237, 88);
            this.gbJudgeGender.TabIndex = 4;
            this.gbJudgeGender.TabStop = false;
            this.gbJudgeGender.Text = "Gender";
            // 
            // rdbJudgeFemale
            // 
            this.rdbJudgeFemale.AutoSize = true;
            this.rdbJudgeFemale.Location = new System.Drawing.Point(81, 51);
            this.rdbJudgeFemale.Name = "rdbJudgeFemale";
            this.rdbJudgeFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbJudgeFemale.TabIndex = 3;
            this.rdbJudgeFemale.Text = "Female";
            this.rdbJudgeFemale.UseVisualStyleBackColor = true;
            // 
            // rdbJudgeMale
            // 
            this.rdbJudgeMale.AutoSize = true;
            this.rdbJudgeMale.Checked = true;
            this.rdbJudgeMale.Location = new System.Drawing.Point(81, 28);
            this.rdbJudgeMale.Name = "rdbJudgeMale";
            this.rdbJudgeMale.Size = new System.Drawing.Size(48, 17);
            this.rdbJudgeMale.TabIndex = 2;
            this.rdbJudgeMale.TabStop = true;
            this.rdbJudgeMale.Text = "Male";
            this.rdbJudgeMale.UseVisualStyleBackColor = true;
            // 
            // lblJudgePhone
            // 
            this.lblJudgePhone.AutoSize = true;
            this.lblJudgePhone.Location = new System.Drawing.Point(43, 193);
            this.lblJudgePhone.Name = "lblJudgePhone";
            this.lblJudgePhone.Size = new System.Drawing.Size(38, 13);
            this.lblJudgePhone.TabIndex = 0;
            this.lblJudgePhone.Text = "Phone";
            // 
            // txtJudgePhone
            // 
            this.txtJudgePhone.Location = new System.Drawing.Point(87, 190);
            this.txtJudgePhone.Name = "txtJudgePhone";
            this.txtJudgePhone.Size = new System.Drawing.Size(186, 20);
            this.txtJudgePhone.TabIndex = 4;
            this.txtJudgePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJudgePhone_KeyPress);
            // 
            // btnSaveJudge
            // 
            this.btnSaveJudge.Location = new System.Drawing.Point(117, 228);
            this.btnSaveJudge.Name = "btnSaveJudge";
            this.btnSaveJudge.Size = new System.Drawing.Size(75, 23);
            this.btnSaveJudge.TabIndex = 5;
            this.btnSaveJudge.Text = "Save";
            this.btnSaveJudge.UseVisualStyleBackColor = true;
            this.btnSaveJudge.Click += new System.EventHandler(this.btnSaveJudge_Click);
            // 
            // btnCancelJudge
            // 
            this.btnCancelJudge.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelJudge.Location = new System.Drawing.Point(198, 228);
            this.btnCancelJudge.Name = "btnCancelJudge";
            this.btnCancelJudge.Size = new System.Drawing.Size(75, 23);
            this.btnCancelJudge.TabIndex = 6;
            this.btnCancelJudge.Text = "Close";
            this.btnCancelJudge.UseVisualStyleBackColor = true;
            this.btnCancelJudge.Click += new System.EventHandler(this.btnCancelJudge_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelJudge});
            this.statusStrip1.Location = new System.Drawing.Point(0, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(304, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslabelJudge
            // 
            this.sslabelJudge.Name = "sslabelJudge";
            this.sslabelJudge.Size = new System.Drawing.Size(16, 17);
            this.sslabelJudge.Text = "...";
            // 
            // frmJudge
            // 
            this.AcceptButton = this.btnSaveJudge;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelJudge;
            this.ClientSize = new System.Drawing.Size(304, 285);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancelJudge);
            this.Controls.Add(this.btnSaveJudge);
            this.Controls.Add(this.gbJudgeGender);
            this.Controls.Add(this.txtjudgeaddress);
            this.Controls.Add(this.lbljudgeaddress);
            this.Controls.Add(this.txtJudgePhone);
            this.Controls.Add(this.lblJudgePhone);
            this.Controls.Add(this.txtJudgeName);
            this.Controls.Add(this.lblJudgeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJudge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Judge";
            this.Load += new System.EventHandler(this.frmjudge_Load);
            this.gbJudgeGender.ResumeLayout(false);
            this.gbJudgeGender.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudgeName;
        private System.Windows.Forms.TextBox txtJudgeName;
        private System.Windows.Forms.TextBox txtjudgeaddress;
        private System.Windows.Forms.Label lbljudgeaddress;
        private System.Windows.Forms.GroupBox gbJudgeGender;
        private System.Windows.Forms.RadioButton rdbJudgeFemale;
        private System.Windows.Forms.RadioButton rdbJudgeMale;
        private System.Windows.Forms.Label lblJudgePhone;
        private System.Windows.Forms.TextBox txtJudgePhone;
        private System.Windows.Forms.Button btnSaveJudge;
        private System.Windows.Forms.Button btnCancelJudge;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelJudge;
    }
}