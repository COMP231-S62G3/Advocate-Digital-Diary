namespace advocate
{
    partial class frmHearings
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
            this.dtpHearings = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssLabelHearing = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvHearings = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStatement = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHearings)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpHearings
            // 
            this.dtpHearings.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHearings.Location = new System.Drawing.Point(68, 12);
            this.dtpHearings.Name = "dtpHearings";
            this.dtpHearings.Size = new System.Drawing.Size(265, 20);
            this.dtpHearings.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(68, 38);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 75);
            this.txtDescription.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(257, 119);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLabelHearing});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(345, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssLabelHearing
            // 
            this.ssLabelHearing.Name = "ssLabelHearing";
            this.ssLabelHearing.Size = new System.Drawing.Size(16, 17);
            this.ssLabelHearing.Text = "...";
            // 
            // dgvHearings
            // 
            this.dgvHearings.AllowUserToAddRows = false;
            this.dgvHearings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHearings.Location = new System.Drawing.Point(12, 152);
            this.dgvHearings.MultiSelect = false;
            this.dgvHearings.Name = "dgvHearings";
            this.dgvHearings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHearings.Size = new System.Drawing.Size(321, 175);
            this.dgvHearings.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(259, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStatement
            // 
            this.btnStatement.Location = new System.Drawing.Point(151, 337);
            this.btnStatement.Name = "btnStatement";
            this.btnStatement.Size = new System.Drawing.Size(102, 23);
            this.btnStatement.TabIndex = 9;
            this.btnStatement.Text = "Add Statement";
            this.btnStatement.UseVisualStyleBackColor = true;
            this.btnStatement.Click += new System.EventHandler(this.btnStatement_Click);
            // 
            // frmHearings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 387);
            this.Controls.Add(this.btnStatement);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvHearings);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHearings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHearings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hearings";
            this.Load += new System.EventHandler(this.frmHearings_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHearings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHearings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssLabelHearing;
        private System.Windows.Forms.DataGridView dgvHearings;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStatement;
    }
}