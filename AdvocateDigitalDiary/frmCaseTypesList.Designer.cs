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
            this.btnShowCaseTypeClose = new System.Windows.Forms.Button();
            this.btnCaseTypeDelete = new System.Windows.Forms.Button();
            this.btnCaseTypeEdit = new System.Windows.Forms.Button();
            this.dgvCaseType = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaseType)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelCaseType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 291);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(456, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // sslabelCaseType
            // 
            this.sslabelCaseType.Name = "sslabelCaseType";
            this.sslabelCaseType.Size = new System.Drawing.Size(16, 17);
            this.sslabelCaseType.Text = "...";
            this.sslabelCaseType.Click += new System.EventHandler(this.sslabelCaseType_Click);
            // 
            // btnShowCaseTypeClose
            // 
            this.btnShowCaseTypeClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowCaseTypeClose.Location = new System.Drawing.Point(299, 222);
            this.btnShowCaseTypeClose.Name = "btnShowCaseTypeClose";
            this.btnShowCaseTypeClose.Size = new System.Drawing.Size(75, 23);
            this.btnShowCaseTypeClose.TabIndex = 8;
            this.btnShowCaseTypeClose.Text = "Close";
            this.btnShowCaseTypeClose.UseVisualStyleBackColor = true;
            this.btnShowCaseTypeClose.Click += new System.EventHandler(this.btnShowCaseTypeClose_Click);
            // 
            // btnCaseTypeDelete
            // 
            this.btnCaseTypeDelete.Location = new System.Drawing.Point(216, 222);
            this.btnCaseTypeDelete.Name = "btnCaseTypeDelete";
            this.btnCaseTypeDelete.Size = new System.Drawing.Size(77, 23);
            this.btnCaseTypeDelete.TabIndex = 7;
            this.btnCaseTypeDelete.Text = "Delete";
            this.btnCaseTypeDelete.UseVisualStyleBackColor = true;
            this.btnCaseTypeDelete.Click += new System.EventHandler(this.btnCaseTypeDelete_Click);
            // 
            // btnCaseTypeEdit
            // 
            this.btnCaseTypeEdit.Location = new System.Drawing.Point(135, 222);
            this.btnCaseTypeEdit.Name = "btnCaseTypeEdit";
            this.btnCaseTypeEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCaseTypeEdit.TabIndex = 6;
            this.btnCaseTypeEdit.Text = "Edit";
            this.btnCaseTypeEdit.UseVisualStyleBackColor = true;
            this.btnCaseTypeEdit.Click += new System.EventHandler(this.btnCaseTypeEdit_Click);
            // 
            // dgvCaseType
            // 
            this.dgvCaseType.AllowUserToAddRows = false;
            this.dgvCaseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaseType.Location = new System.Drawing.Point(10, 6);
            this.dgvCaseType.MultiSelect = false;
            this.dgvCaseType.Name = "dgvCaseType";
            this.dgvCaseType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaseType.Size = new System.Drawing.Size(363, 200);
            this.dgvCaseType.TabIndex = 5;
            this.dgvCaseType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaseType_CellContentClick);
            // 
            // frmCaseTypesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 313);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnShowCaseTypeClose);
            this.Controls.Add(this.btnCaseTypeDelete);
            this.Controls.Add(this.btnCaseTypeEdit);
            this.Controls.Add(this.dgvCaseType);
            this.Name = "frmCaseTypesList";
            this.Text = "Case Types List";
            this.Load += new System.EventHandler(this.frmCaseTypesList_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaseType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnShowCaseTypeClose;
        private System.Windows.Forms.Button btnCaseTypeDelete;
        private System.Windows.Forms.Button btnCaseTypeEdit;
        private System.Windows.Forms.DataGridView dgvCaseType;
        private System.Windows.Forms.ToolStripStatusLabel sslabelCaseType;
    }
}