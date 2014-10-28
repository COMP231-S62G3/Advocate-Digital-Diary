﻿namespace AdvocateDigitalDiary
{
    partial class frmCaseList
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
            this.components = new System.ComponentModel.Container();
            this.hearingDatesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.witnessesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.witnessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hearingDatesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hearingDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ssCaseList = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.paymentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.witnessesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hearingDatesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvCaseList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaseList)).BeginInit();
            this.SuspendLayout();
            // 
            // hearingDatesToolStripMenuItem3
            // 
            this.hearingDatesToolStripMenuItem3.Name = "hearingDatesToolStripMenuItem3";
            this.hearingDatesToolStripMenuItem3.Size = new System.Drawing.Size(165, 24);
            this.hearingDatesToolStripMenuItem3.Text = "Hearing Dates";
            // 
            // paymentsToolStripMenuItem2
            // 
            this.paymentsToolStripMenuItem2.Name = "paymentsToolStripMenuItem2";
            this.paymentsToolStripMenuItem2.Size = new System.Drawing.Size(165, 24);
            this.paymentsToolStripMenuItem2.Text = "Payments";
            // 
            // witnessesToolStripMenuItem2
            // 
            this.witnessesToolStripMenuItem2.Name = "witnessesToolStripMenuItem2";
            this.witnessesToolStripMenuItem2.Size = new System.Drawing.Size(165, 24);
            this.witnessesToolStripMenuItem2.Text = "Witnesses";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.witnessesToolStripMenuItem2,
            this.paymentsToolStripMenuItem2,
            this.documentsToolStripMenuItem2,
            this.hearingDatesToolStripMenuItem3});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // documentsToolStripMenuItem2
            // 
            this.documentsToolStripMenuItem2.Name = "documentsToolStripMenuItem2";
            this.documentsToolStripMenuItem2.Size = new System.Drawing.Size(165, 24);
            this.documentsToolStripMenuItem2.Text = "Documents";
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.documentsToolStripMenuItem.Text = "&Documents";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.paymentsToolStripMenuItem.Text = "&Payments";
            // 
            // witnessesToolStripMenuItem
            // 
            this.witnessesToolStripMenuItem.Name = "witnessesToolStripMenuItem";
            this.witnessesToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.witnessesToolStripMenuItem.Text = "&Witnesses";
            // 
            // hearingDatesToolStripMenuItem1
            // 
            this.hearingDatesToolStripMenuItem1.Name = "hearingDatesToolStripMenuItem1";
            this.hearingDatesToolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
            this.hearingDatesToolStripMenuItem1.Text = "&Hearing Dates";
            // 
            // hearingDatesToolStripMenuItem
            // 
            this.hearingDatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hearingDatesToolStripMenuItem1,
            this.witnessesToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.documentsToolStripMenuItem});
            this.hearingDatesToolStripMenuItem.Name = "hearingDatesToolStripMenuItem";
            this.hearingDatesToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.hearingDatesToolStripMenuItem.Text = "&Details";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hearingDatesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ssCaseList
            // 
            this.ssCaseList.Name = "ssCaseList";
            this.ssCaseList.Size = new System.Drawing.Size(19, 17);
            this.ssCaseList.Text = "....";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssCaseList});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(481, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(400, 312);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(319, 312);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // paymentsToolStripMenuItem1
            // 
            this.paymentsToolStripMenuItem1.Name = "paymentsToolStripMenuItem1";
            this.paymentsToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.paymentsToolStripMenuItem1.Text = "Payments";
            // 
            // documentsToolStripMenuItem1
            // 
            this.documentsToolStripMenuItem1.Name = "documentsToolStripMenuItem1";
            this.documentsToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.documentsToolStripMenuItem1.Text = "Documents";
            // 
            // witnessesToolStripMenuItem1
            // 
            this.witnessesToolStripMenuItem1.Name = "witnessesToolStripMenuItem1";
            this.witnessesToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.witnessesToolStripMenuItem1.Text = "Witnesses";
            // 
            // hearingDatesToolStripMenuItem2
            // 
            this.hearingDatesToolStripMenuItem2.Name = "hearingDatesToolStripMenuItem2";
            this.hearingDatesToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.hearingDatesToolStripMenuItem2.Text = "Hearing Dates";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hearingDatesToolStripMenuItem2,
            this.witnessesToolStripMenuItem1,
            this.documentsToolStripMenuItem1,
            this.paymentsToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // dgvCaseList
            // 
            this.dgvCaseList.AllowUserToAddRows = false;
            this.dgvCaseList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaseList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCaseList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCaseList.Location = new System.Drawing.Point(11, 39);
            this.dgvCaseList.MultiSelect = false;
            this.dgvCaseList.Name = "dgvCaseList";
            this.dgvCaseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaseList.Size = new System.Drawing.Size(545, 267);
            this.dgvCaseList.TabIndex = 6;
            this.dgvCaseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaseList_CellContentClick);
            // 
            // frmCaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 483);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvCaseList);
            this.Name = "frmCaseList";
            this.Text = "Cases";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem hearingDatesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem witnessesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem witnessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hearingDatesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hearingDatesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssCaseList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem witnessesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hearingDatesToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvCaseList;
    }
}