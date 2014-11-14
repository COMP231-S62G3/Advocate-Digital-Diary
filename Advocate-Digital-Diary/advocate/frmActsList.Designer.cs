namespace AdvocateDigitalDiary
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelShowActs = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnActsClose = new System.Windows.Forms.Button();
            this.btnActsDelete = new System.Windows.Forms.Button();
            this.btnActsEdit = new System.Windows.Forms.Button();
            this.dgvActs = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActs)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelShowActs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(581, 25);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // sslabelShowActs
            // 
            this.sslabelShowActs.Name = "sslabelShowActs";
            this.sslabelShowActs.Size = new System.Drawing.Size(18, 20);
            this.sslabelShowActs.Text = "...";
            // 
            // btnActsClose
            // 
            this.btnActsClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnActsClose.Location = new System.Drawing.Point(393, 271);
            this.btnActsClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnActsClose.Name = "btnActsClose";
            this.btnActsClose.Size = new System.Drawing.Size(100, 28);
            this.btnActsClose.TabIndex = 8;
            this.btnActsClose.Text = "Close";
            this.btnActsClose.UseVisualStyleBackColor = true;
            this.btnActsClose.Click += new System.EventHandler(this.btnActsClose_Click);
            // 
            // btnActsDelete
            // 
            this.btnActsDelete.Location = new System.Drawing.Point(283, 271);
            this.btnActsDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnActsDelete.Name = "btnActsDelete";
            this.btnActsDelete.Size = new System.Drawing.Size(103, 28);
            this.btnActsDelete.TabIndex = 7;
            this.btnActsDelete.Text = "Delete";
            this.btnActsDelete.UseVisualStyleBackColor = true;
            this.btnActsDelete.Click += new System.EventHandler(this.btnActsDelete_Click);
            // 
            // btnActsEdit
            // 
            this.btnActsEdit.Location = new System.Drawing.Point(175, 271);
            this.btnActsEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnActsEdit.Name = "btnActsEdit";
            this.btnActsEdit.Size = new System.Drawing.Size(100, 28);
            this.btnActsEdit.TabIndex = 6;
            this.btnActsEdit.Text = "Edit";
            this.btnActsEdit.UseVisualStyleBackColor = true;
            this.btnActsEdit.Click += new System.EventHandler(this.btnActsEdit_Click);
            // 
            // dgvActs
            // 
            this.dgvActs.AllowUserToAddRows = false;
            this.dgvActs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActs.Location = new System.Drawing.Point(20, 7);
            this.dgvActs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActs.MultiSelect = false;
            this.dgvActs.Name = "dgvActs";
            this.dgvActs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActs.Size = new System.Drawing.Size(473, 245);
            this.dgvActs.TabIndex = 5;
            this.dgvActs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActs_CellContentClick);
            // 
            // frmActsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 356);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnActsClose);
            this.Controls.Add(this.btnActsDelete);
            this.Controls.Add(this.btnActsEdit);
            this.Controls.Add(this.dgvActs);
            this.Name = "frmActsList";
            this.Text = "Acts List";
            this.Load += new System.EventHandler(this.frmActsList_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelShowActs;
        private System.Windows.Forms.Button btnActsClose;
        private System.Windows.Forms.Button btnActsDelete;
        private System.Windows.Forms.Button btnActsEdit;
        private System.Windows.Forms.DataGridView dgvActs;
    }
}