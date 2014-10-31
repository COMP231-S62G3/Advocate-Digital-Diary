namespace AdvocateDigitalDiary
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelShowJudge = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnShowJudgeClose = new System.Windows.Forms.Button();
            this.btnShowJudgeEdit = new System.Windows.Forms.Button();
            this.btnShowJudgeDelete = new System.Windows.Forms.Button();
            this.dgvShowJudge = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowJudge)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelShowJudge});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(564, 25);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // sslabelShowJudge
            // 
            this.sslabelShowJudge.Name = "sslabelShowJudge";
            this.sslabelShowJudge.Size = new System.Drawing.Size(18, 20);
            this.sslabelShowJudge.Text = "...";
            // 
            // btnShowJudgeClose
            // 
            this.btnShowJudgeClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowJudgeClose.Location = new System.Drawing.Point(408, 309);
            this.btnShowJudgeClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowJudgeClose.Name = "btnShowJudgeClose";
            this.btnShowJudgeClose.Size = new System.Drawing.Size(100, 28);
            this.btnShowJudgeClose.TabIndex = 8;
            this.btnShowJudgeClose.Text = "Close";
            this.btnShowJudgeClose.UseVisualStyleBackColor = true;
            this.btnShowJudgeClose.Click += new System.EventHandler(this.btnShowJudgeClose_Click);
            // 
            // btnShowJudgeEdit
            // 
            this.btnShowJudgeEdit.Location = new System.Drawing.Point(192, 309);
            this.btnShowJudgeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowJudgeEdit.Name = "btnShowJudgeEdit";
            this.btnShowJudgeEdit.Size = new System.Drawing.Size(100, 28);
            this.btnShowJudgeEdit.TabIndex = 6;
            this.btnShowJudgeEdit.Text = "Edit";
            this.btnShowJudgeEdit.UseVisualStyleBackColor = true;
            this.btnShowJudgeEdit.Click += new System.EventHandler(this.btnShowJudgeEdit_Click);
            // 
            // btnShowJudgeDelete
            // 
            this.btnShowJudgeDelete.Location = new System.Drawing.Point(300, 309);
            this.btnShowJudgeDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowJudgeDelete.Name = "btnShowJudgeDelete";
            this.btnShowJudgeDelete.Size = new System.Drawing.Size(100, 28);
            this.btnShowJudgeDelete.TabIndex = 7;
            this.btnShowJudgeDelete.Text = "Delete";
            this.btnShowJudgeDelete.UseVisualStyleBackColor = true;
            this.btnShowJudgeDelete.Click += new System.EventHandler(this.btnShowJudgeDelete_Click);
            // 
            // dgvShowJudge
            // 
            this.dgvShowJudge.AllowUserToAddRows = false;
            this.dgvShowJudge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowJudge.Location = new System.Drawing.Point(15, 8);
            this.dgvShowJudge.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowJudge.MultiSelect = false;
            this.dgvShowJudge.Name = "dgvShowJudge";
            this.dgvShowJudge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowJudge.Size = new System.Drawing.Size(493, 284);
            this.dgvShowJudge.TabIndex = 5;
            this.dgvShowJudge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowJudge_CellContentClick);
            // 
            // frmJudgesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 434);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnShowJudgeClose);
            this.Controls.Add(this.btnShowJudgeEdit);
            this.Controls.Add(this.btnShowJudgeDelete);
            this.Controls.Add(this.dgvShowJudge);
            this.Name = "frmJudgesList";
            this.Text = "Judges List";
            this.Load += new System.EventHandler(this.frmJudgesList_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowJudge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelShowJudge;
        private System.Windows.Forms.Button btnShowJudgeClose;
        private System.Windows.Forms.Button btnShowJudgeEdit;
        private System.Windows.Forms.Button btnShowJudgeDelete;
        private System.Windows.Forms.DataGridView dgvShowJudge;
    }
}