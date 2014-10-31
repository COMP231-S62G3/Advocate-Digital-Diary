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
<<<<<<< HEAD
            this.statusStrip1.Location = new System.Drawing.Point(0, 291);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(456, 22);
=======
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(617, 25);
>>>>>>> origin/Design-Master-page
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // sslabelCaseType
            // 
            this.sslabelCaseType.Name = "sslabelCaseType";
            this.sslabelCaseType.Size = new System.Drawing.Size(18, 20);
            this.sslabelCaseType.Text = "...";
<<<<<<< HEAD
            this.sslabelCaseType.Click += new System.EventHandler(this.sslabelCaseType_Click);
=======
>>>>>>> origin/Design-Master-page
            // 
            // btnShowCaseTypeClose
            // 
            this.btnShowCaseTypeClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
<<<<<<< HEAD
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
=======
            this.btnShowCaseTypeClose.Location = new System.Drawing.Point(399, 273);
            this.btnShowCaseTypeClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCaseTypeClose.Name = "btnShowCaseTypeClose";
            this.btnShowCaseTypeClose.Size = new System.Drawing.Size(100, 28);
            this.btnShowCaseTypeClose.TabIndex = 8;
            this.btnShowCaseTypeClose.Text = "Close";
            this.btnShowCaseTypeClose.UseVisualStyleBackColor = true;
            // 
            // btnCaseTypeDelete
            // 
            this.btnCaseTypeDelete.Location = new System.Drawing.Point(288, 273);
            this.btnCaseTypeDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaseTypeDelete.Name = "btnCaseTypeDelete";
            this.btnCaseTypeDelete.Size = new System.Drawing.Size(103, 28);
            this.btnCaseTypeDelete.TabIndex = 7;
            this.btnCaseTypeDelete.Text = "Delete";
            this.btnCaseTypeDelete.UseVisualStyleBackColor = true;
            // 
            // btnCaseTypeEdit
            // 
            this.btnCaseTypeEdit.Location = new System.Drawing.Point(180, 273);
            this.btnCaseTypeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaseTypeEdit.Name = "btnCaseTypeEdit";
            this.btnCaseTypeEdit.Size = new System.Drawing.Size(100, 28);
            this.btnCaseTypeEdit.TabIndex = 6;
            this.btnCaseTypeEdit.Text = "Edit";
            this.btnCaseTypeEdit.UseVisualStyleBackColor = true;
>>>>>>> origin/Design-Master-page
            // 
            // dgvCaseType
            // 
            this.dgvCaseType.AllowUserToAddRows = false;
            this.dgvCaseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dgvCaseType.Location = new System.Drawing.Point(10, 6);
            this.dgvCaseType.MultiSelect = false;
            this.dgvCaseType.Name = "dgvCaseType";
            this.dgvCaseType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaseType.Size = new System.Drawing.Size(363, 200);
            this.dgvCaseType.TabIndex = 5;
            this.dgvCaseType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaseType_CellContentClick);
=======
            this.dgvCaseType.Location = new System.Drawing.Point(13, 7);
            this.dgvCaseType.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCaseType.MultiSelect = false;
            this.dgvCaseType.Name = "dgvCaseType";
            this.dgvCaseType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaseType.Size = new System.Drawing.Size(484, 246);
            this.dgvCaseType.TabIndex = 5;
>>>>>>> origin/Design-Master-page
            // 
            // frmCaseTypesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(456, 313);
=======
            this.ClientSize = new System.Drawing.Size(617, 463);
>>>>>>> origin/Design-Master-page
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnShowCaseTypeClose);
            this.Controls.Add(this.btnCaseTypeDelete);
            this.Controls.Add(this.btnCaseTypeEdit);
            this.Controls.Add(this.dgvCaseType);
<<<<<<< HEAD
=======
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> origin/Design-Master-page
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
<<<<<<< HEAD
=======
        private System.Windows.Forms.Button btnShowCaseTypeClose;
        private System.Windows.Forms.Button btnCaseTypeDelete;
        private System.Windows.Forms.Button btnCaseTypeEdit;
        private System.Windows.Forms.DataGridView dgvCaseType;

>>>>>>> origin/Design-Master-page
    }
}