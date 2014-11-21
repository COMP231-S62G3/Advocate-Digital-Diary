namespace advocate
{
    partial class frmJudgesList
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
            this.dgvShowJudge = new System.Windows.Forms.DataGridView();
            this.btnShowJudgeDelete = new System.Windows.Forms.Button();
            this.btnShowJudgeEdit = new System.Windows.Forms.Button();
            this.btnShowJudgeClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelShowJudge = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowJudge)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowJudge
            // 
            this.dgvShowJudge.AllowUserToAddRows = false;
            this.dgvShowJudge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowJudge.Location = new System.Drawing.Point(11, 12);
            this.dgvShowJudge.MultiSelect = false;
            this.dgvShowJudge.Name = "dgvShowJudge";
            this.dgvShowJudge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowJudge.Size = new System.Drawing.Size(370, 231);
            this.dgvShowJudge.TabIndex = 0;
            // 
            // btnShowJudgeDelete
            // 
            this.btnShowJudgeDelete.Location = new System.Drawing.Point(225, 257);
            this.btnShowJudgeDelete.Name = "btnShowJudgeDelete";
            this.btnShowJudgeDelete.Size = new System.Drawing.Size(75, 23);
            this.btnShowJudgeDelete.TabIndex = 2;
            this.btnShowJudgeDelete.Text = "Delete";
            this.btnShowJudgeDelete.UseVisualStyleBackColor = true;
            this.btnShowJudgeDelete.Click += new System.EventHandler(this.btnShowJudgeDelete_Click);
            // 
            // btnShowJudgeEdit
            // 
            this.btnShowJudgeEdit.Location = new System.Drawing.Point(144, 257);
            this.btnShowJudgeEdit.Name = "btnShowJudgeEdit";
            this.btnShowJudgeEdit.Size = new System.Drawing.Size(75, 23);
            this.btnShowJudgeEdit.TabIndex = 1;
            this.btnShowJudgeEdit.Text = "Edit";
            this.btnShowJudgeEdit.UseVisualStyleBackColor = true;
            this.btnShowJudgeEdit.Click += new System.EventHandler(this.btnShowJudgeEdit_Click);
            // 
            // btnShowJudgeClose
            // 
            this.btnShowJudgeClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowJudgeClose.Location = new System.Drawing.Point(306, 257);
            this.btnShowJudgeClose.Name = "btnShowJudgeClose";
            this.btnShowJudgeClose.Size = new System.Drawing.Size(75, 23);
            this.btnShowJudgeClose.TabIndex = 3;
            this.btnShowJudgeClose.Text = "Close";
            this.btnShowJudgeClose.UseVisualStyleBackColor = true;
            this.btnShowJudgeClose.Click += new System.EventHandler(this.btnShowJudgeClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelShowJudge});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(394, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslabelShowJudge
            // 
            this.sslabelShowJudge.Name = "sslabelShowJudge";
            this.sslabelShowJudge.Size = new System.Drawing.Size(16, 17);
            this.sslabelShowJudge.Text = "...";
            // 
            // frmJudgesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnShowJudgeClose;
            this.ClientSize = new System.Drawing.Size(394, 310);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnShowJudgeClose);
            this.Controls.Add(this.btnShowJudgeEdit);
            this.Controls.Add(this.btnShowJudgeDelete);
            this.Controls.Add(this.dgvShowJudge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJudgesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Judges";
            this.Load += new System.EventHandler(this.frmShowjudge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowJudge)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowJudge;
        private System.Windows.Forms.Button btnShowJudgeDelete;
        private System.Windows.Forms.Button btnShowJudgeEdit;
        private System.Windows.Forms.Button btnShowJudgeClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelShowJudge;
    }
}