namespace advocate
{
    partial class frmActsList
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
            this.btnActsClose = new System.Windows.Forms.Button();
            this.btnActsDelete = new System.Windows.Forms.Button();
            this.btnActsEdit = new System.Windows.Forms.Button();
            this.dgvActs = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelShowActs = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActs)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActsClose
            // 
            this.btnActsClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnActsClose.Location = new System.Drawing.Point(295, 227);
            this.btnActsClose.Name = "btnActsClose";
            this.btnActsClose.Size = new System.Drawing.Size(75, 23);
            this.btnActsClose.TabIndex = 3;
            this.btnActsClose.Text = "Close";
            this.btnActsClose.UseVisualStyleBackColor = true;
            this.btnActsClose.Click += new System.EventHandler(this.btnActsClose_Click);
            // 
            // btnActsDelete
            // 
            this.btnActsDelete.Location = new System.Drawing.Point(212, 227);
            this.btnActsDelete.Name = "btnActsDelete";
            this.btnActsDelete.Size = new System.Drawing.Size(77, 23);
            this.btnActsDelete.TabIndex = 2;
            this.btnActsDelete.Text = "Delete";
            this.btnActsDelete.UseVisualStyleBackColor = true;
            this.btnActsDelete.Click += new System.EventHandler(this.btnActsDelete_Click);
            // 
            // btnActsEdit
            // 
            this.btnActsEdit.Location = new System.Drawing.Point(131, 227);
            this.btnActsEdit.Name = "btnActsEdit";
            this.btnActsEdit.Size = new System.Drawing.Size(75, 23);
            this.btnActsEdit.TabIndex = 1;
            this.btnActsEdit.Text = "Edit";
            this.btnActsEdit.UseVisualStyleBackColor = true;
            this.btnActsEdit.Click += new System.EventHandler(this.btnActsEdit_Click);
            // 
            // dgvActs
            // 
            this.dgvActs.AllowUserToAddRows = false;
            this.dgvActs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActs.Location = new System.Drawing.Point(15, 12);
            this.dgvActs.MultiSelect = false;
            this.dgvActs.Name = "dgvActs";
            this.dgvActs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActs.Size = new System.Drawing.Size(355, 199);
            this.dgvActs.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelShowActs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(385, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslabelShowActs
            // 
            this.sslabelShowActs.Name = "sslabelShowActs";
            this.sslabelShowActs.Size = new System.Drawing.Size(16, 17);
            this.sslabelShowActs.Text = "...";
            // 
            // frmActsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnActsClose;
            this.ClientSize = new System.Drawing.Size(385, 285);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnActsClose);
            this.Controls.Add(this.btnActsDelete);
            this.Controls.Add(this.btnActsEdit);
            this.Controls.Add(this.dgvActs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acts";
            this.Load += new System.EventHandler(this.frmShowActs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActs)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActsClose;
        private System.Windows.Forms.Button btnActsDelete;
        private System.Windows.Forms.Button btnActsEdit;
        private System.Windows.Forms.DataGridView dgvActs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelShowActs;
    }
}