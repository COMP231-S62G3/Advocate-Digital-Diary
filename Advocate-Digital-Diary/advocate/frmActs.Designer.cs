namespace advocate
{
    partial class frmActs
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
            this.txtActName = new System.Windows.Forms.TextBox();
            this.lblActname = new System.Windows.Forms.Label();
            this.txtActDescription = new System.Windows.Forms.TextBox();
            this.lblActDescription = new System.Windows.Forms.Label();
            this.btnCancelAct = new System.Windows.Forms.Button();
            this.btnSaveAct = new System.Windows.Forms.Button();
            this.ssActs = new System.Windows.Forms.StatusStrip();
            this.sslabelActs = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssActs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtActName
            // 
            this.txtActName.Location = new System.Drawing.Point(73, 15);
            this.txtActName.MaxLength = 20;
            this.txtActName.Name = "txtActName";
            this.txtActName.Size = new System.Drawing.Size(300, 20);
            this.txtActName.TabIndex = 0;
            // 
            // lblActname
            // 
            this.lblActname.AutoSize = true;
            this.lblActname.Location = new System.Drawing.Point(33, 15);
            this.lblActname.Name = "lblActname";
            this.lblActname.Size = new System.Drawing.Size(35, 13);
            this.lblActname.TabIndex = 1;
            this.lblActname.Text = "Name";
            // 
            // txtActDescription
            // 
            this.txtActDescription.Location = new System.Drawing.Point(73, 41);
            this.txtActDescription.MaxLength = 100;
            this.txtActDescription.Multiline = true;
            this.txtActDescription.Name = "txtActDescription";
            this.txtActDescription.Size = new System.Drawing.Size(300, 167);
            this.txtActDescription.TabIndex = 1;
            // 
            // lblActDescription
            // 
            this.lblActDescription.AutoSize = true;
            this.lblActDescription.Location = new System.Drawing.Point(7, 44);
            this.lblActDescription.Name = "lblActDescription";
            this.lblActDescription.Size = new System.Drawing.Size(60, 13);
            this.lblActDescription.TabIndex = 1;
            this.lblActDescription.Text = "Description";
            // 
            // btnCancelAct
            // 
            this.btnCancelAct.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAct.Location = new System.Drawing.Point(298, 224);
            this.btnCancelAct.Name = "btnCancelAct";
            this.btnCancelAct.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAct.TabIndex = 3;
            this.btnCancelAct.Text = "Close";
            this.btnCancelAct.UseVisualStyleBackColor = true;
            this.btnCancelAct.Click += new System.EventHandler(this.btnCancelAct_Click);
            // 
            // btnSaveAct
            // 
            this.btnSaveAct.Location = new System.Drawing.Point(217, 224);
            this.btnSaveAct.Name = "btnSaveAct";
            this.btnSaveAct.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAct.TabIndex = 2;
            this.btnSaveAct.Text = "Save";
            this.btnSaveAct.UseVisualStyleBackColor = true;
            this.btnSaveAct.Click += new System.EventHandler(this.btnSaveAct_Click);
            // 
            // ssActs
            // 
            this.ssActs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelActs});
            this.ssActs.Location = new System.Drawing.Point(0, 263);
            this.ssActs.Name = "ssActs";
            this.ssActs.Size = new System.Drawing.Size(385, 22);
            this.ssActs.TabIndex = 4;
            this.ssActs.Text = "statusStrip1";
            // 
            // sslabelActs
            // 
            this.sslabelActs.Name = "sslabelActs";
            this.sslabelActs.Size = new System.Drawing.Size(16, 17);
            this.sslabelActs.Text = "...";
            // 
            // frmActs
            // 
            this.AcceptButton = this.btnSaveAct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelAct;
            this.ClientSize = new System.Drawing.Size(385, 285);
            this.Controls.Add(this.ssActs);
            this.Controls.Add(this.btnSaveAct);
            this.Controls.Add(this.btnCancelAct);
            this.Controls.Add(this.lblActDescription);
            this.Controls.Add(this.lblActname);
            this.Controls.Add(this.txtActDescription);
            this.Controls.Add(this.txtActName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acts";
            this.Load += new System.EventHandler(this.frmActs_Load);
            this.ssActs.ResumeLayout(false);
            this.ssActs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActName;
        private System.Windows.Forms.Label lblActname;
        private System.Windows.Forms.TextBox txtActDescription;
        private System.Windows.Forms.Label lblActDescription;
        private System.Windows.Forms.Button btnCancelAct;
        private System.Windows.Forms.Button btnSaveAct;
        private System.Windows.Forms.StatusStrip ssActs;
        private System.Windows.Forms.ToolStripStatusLabel sslabelActs;
    }
}