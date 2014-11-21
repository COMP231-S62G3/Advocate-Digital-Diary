namespace advocate
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
            this.btnCaseTypeDelete = new System.Windows.Forms.Button();
            this.btnCaseTypeEdit = new System.Windows.Forms.Button();
            this.dgvCaseType = new System.Windows.Forms.DataGridView();
            this.btnShowCaseTypeClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelCaseType = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaseType)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCaseTypeDelete
            // 
            this.btnCaseTypeDelete.Location = new System.Drawing.Point(216, 228);
            this.btnCaseTypeDelete.Name = "btnCaseTypeDelete";
            this.btnCaseTypeDelete.Size = new System.Drawing.Size(77, 23);
            this.btnCaseTypeDelete.TabIndex = 2;
            this.btnCaseTypeDelete.Text = "Delete";
            this.btnCaseTypeDelete.UseVisualStyleBackColor = true;
            this.btnCaseTypeDelete.Click += new System.EventHandler(this.btnCaseTypeDelete_Click);
            // 
            // btnCaseTypeEdit
            // 
            this.btnCaseTypeEdit.Location = new System.Drawing.Point(135, 228);
            this.btnCaseTypeEdit.Name = "btnCaseTypeEdit";
            this.btnCaseTypeEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCaseTypeEdit.TabIndex = 1;
            this.btnCaseTypeEdit.Text = "Edit";
            this.btnCaseTypeEdit.UseVisualStyleBackColor = true;
            this.btnCaseTypeEdit.Click += new System.EventHandler(this.btnCaseTypeEdit_Click);
            // 
            // dgvCaseType
            // 
            this.dgvCaseType.AllowUserToAddRows = false;
            this.dgvCaseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaseType.Location = new System.Drawing.Point(10, 12);
            this.dgvCaseType.MultiSelect = false;
            this.dgvCaseType.Name = "dgvCaseType";
            this.dgvCaseType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaseType.Size = new System.Drawing.Size(363, 200);
            this.dgvCaseType.TabIndex = 0;
            // 
            // btnShowCaseTypeClose
            // 
            this.btnShowCaseTypeClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowCaseTypeClose.Location = new System.Drawing.Point(299, 228);
            this.btnShowCaseTypeClose.Name = "btnShowCaseTypeClose";
            this.btnShowCaseTypeClose.Size = new System.Drawing.Size(75, 23);
            this.btnShowCaseTypeClose.TabIndex = 3;
            this.btnShowCaseTypeClose.Text = "Close";
            this.btnShowCaseTypeClose.UseVisualStyleBackColor = true;
            this.btnShowCaseTypeClose.Click += new System.EventHandler(this.btnShowCaseTypeClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelCaseType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(385, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslabelCaseType
            // 
            this.sslabelCaseType.Name = "sslabelCaseType";
            this.sslabelCaseType.Size = new System.Drawing.Size(16, 17);
            this.sslabelCaseType.Text = "...";
            // 
            // frmCaseTypesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnShowCaseTypeClose;
            this.ClientSize = new System.Drawing.Size(385, 285);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnShowCaseTypeClose);
            this.Controls.Add(this.btnCaseTypeDelete);
            this.Controls.Add(this.btnCaseTypeEdit);
            this.Controls.Add(this.dgvCaseType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaseTypesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Case Types";
            this.Load += new System.EventHandler(this.frmshowcasetype_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaseType)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaseTypeDelete;
        private System.Windows.Forms.Button btnCaseTypeEdit;
        private System.Windows.Forms.DataGridView dgvCaseType;
        private System.Windows.Forms.Button btnShowCaseTypeClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelCaseType;


    }
}