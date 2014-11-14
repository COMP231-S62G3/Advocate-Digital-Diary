namespace AdvocateDigitalDiary
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
            this.ssActs = new System.Windows.Forms.StatusStrip();
            this.sslabelActs = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSaveAct = new System.Windows.Forms.Button();
            this.btnCancelAct = new System.Windows.Forms.Button();
            this.lblActDescription = new System.Windows.Forms.Label();
            this.lblActname = new System.Windows.Forms.Label();
            this.txtActDescription = new System.Windows.Forms.TextBox();
            this.txtActName = new System.Windows.Forms.TextBox();
            this.ssActs.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssActs
            // 
            this.ssActs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelActs});
            this.ssActs.Location = new System.Drawing.Point(0, 403);
            this.ssActs.Name = "ssActs";
            this.ssActs.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssActs.Size = new System.Drawing.Size(588, 25);
            this.ssActs.TabIndex = 11;
            this.ssActs.Text = "statusStrip1";
            this.ssActs.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssActs_ItemClicked);
            // 
            // sslabelActs
            // 
            this.sslabelActs.Name = "sslabelActs";
            this.sslabelActs.Size = new System.Drawing.Size(18, 20);
            this.sslabelActs.Text = "...";
            // 
            // btnSaveAct
            // 
            this.btnSaveAct.Location = new System.Drawing.Point(289, 267);
            this.btnSaveAct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAct.Name = "btnSaveAct";
            this.btnSaveAct.Size = new System.Drawing.Size(100, 28);
            this.btnSaveAct.TabIndex = 9;
            this.btnSaveAct.Text = "Save";
            this.btnSaveAct.UseVisualStyleBackColor = true;
            this.btnSaveAct.Click += new System.EventHandler(this.btnSaveAct_Click);
            // 
            // btnCancelAct
            // 
            this.btnCancelAct.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAct.Location = new System.Drawing.Point(397, 267);
            this.btnCancelAct.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelAct.Name = "btnCancelAct";
            this.btnCancelAct.Size = new System.Drawing.Size(100, 28);
            this.btnCancelAct.TabIndex = 10;
            this.btnCancelAct.Text = "Close";
            this.btnCancelAct.UseVisualStyleBackColor = true;
            this.btnCancelAct.Click += new System.EventHandler(this.btnCancelAct_Click);
            // 
            // lblActDescription
            // 
            this.lblActDescription.AutoSize = true;
            this.lblActDescription.Location = new System.Drawing.Point(9, 45);
            this.lblActDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActDescription.Name = "lblActDescription";
            this.lblActDescription.Size = new System.Drawing.Size(79, 17);
            this.lblActDescription.TabIndex = 6;
            this.lblActDescription.Text = "Description";
            this.lblActDescription.Click += new System.EventHandler(this.lblActDescription_Click);
            // 
            // lblActname
            // 
            this.lblActname.AutoSize = true;
            this.lblActname.Location = new System.Drawing.Point(44, 9);
            this.lblActname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActname.Name = "lblActname";
            this.lblActname.Size = new System.Drawing.Size(45, 17);
            this.lblActname.TabIndex = 7;
            this.lblActname.Text = "Name";
            this.lblActname.Click += new System.EventHandler(this.lblActname_Click);
            // 
            // txtActDescription
            // 
            this.txtActDescription.Location = new System.Drawing.Point(97, 41);
            this.txtActDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtActDescription.MaxLength = 100;
            this.txtActDescription.Multiline = true;
            this.txtActDescription.Name = "txtActDescription";
            this.txtActDescription.Size = new System.Drawing.Size(399, 205);
            this.txtActDescription.TabIndex = 8;
            this.txtActDescription.TextChanged += new System.EventHandler(this.txtActDescription_TextChanged);
            // 
            // txtActName
            // 
            this.txtActName.Location = new System.Drawing.Point(97, 9);
            this.txtActName.Margin = new System.Windows.Forms.Padding(4);
            this.txtActName.MaxLength = 20;
            this.txtActName.Name = "txtActName";
            this.txtActName.Size = new System.Drawing.Size(399, 22);
            this.txtActName.TabIndex = 5;
            this.txtActName.TextChanged += new System.EventHandler(this.txtActName_TextChanged);
            // 
            // frmActs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 428);
            this.Controls.Add(this.ssActs);
            this.Controls.Add(this.btnSaveAct);
            this.Controls.Add(this.btnCancelAct);
            this.Controls.Add(this.lblActDescription);
            this.Controls.Add(this.lblActname);
            this.Controls.Add(this.txtActDescription);
            this.Controls.Add(this.txtActName);
            this.Name = "frmActs";
            this.Text = "Acts";
            this.Load += new System.EventHandler(this.frmActs_Load);
            this.ssActs.ResumeLayout(false);
            this.ssActs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssActs;
        private System.Windows.Forms.ToolStripStatusLabel sslabelActs;
        private System.Windows.Forms.Button btnSaveAct;
        private System.Windows.Forms.Button btnCancelAct;
        private System.Windows.Forms.Label lblActDescription;
        private System.Windows.Forms.Label lblActname;
        private System.Windows.Forms.TextBox txtActDescription;
        private System.Windows.Forms.TextBox txtActName;
    }
}