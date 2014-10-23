namespace AdvocateDigitalDiary
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.TSJudges = new System.Windows.Forms.ToolStripMenuItem();
            this.TSAddJudge = new System.Windows.Forms.ToolStripMenuItem();
            this.TSShowJudge = new System.Windows.Forms.ToolStripMenuItem();
            this.TSCourts = new System.Windows.Forms.ToolStripMenuItem();
            this.TSAddCourt = new System.Windows.Forms.ToolStripMenuItem();
            this.TSShowCourt = new System.Windows.Forms.ToolStripMenuItem();
            this.TSCaseType = new System.Windows.Forms.ToolStripMenuItem();
            this.TSAddCaseType = new System.Windows.Forms.ToolStripMenuItem();
            this.TSShowCaseType = new System.Windows.Forms.ToolStripMenuItem();
            this.TSActs = new System.Windows.Forms.ToolStripMenuItem();
            this.TSAddAct = new System.Windows.Forms.ToolStripMenuItem();
            this.TSShowActs = new System.Windows.Forms.ToolStripMenuItem();
            this.TSReports = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reportToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.actsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSUser = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSAdvocate = new System.Windows.Forms.MenuStrip();
            this.btnAddCase = new System.Windows.Forms.Button();
            this.btnListCase = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MSAdvocate.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(12, 36);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 89);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(359, 36);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 89);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // TSJudges
            // 
            this.TSJudges.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSAddJudge,
            this.TSShowJudge});
            this.TSJudges.Image = ((System.Drawing.Image)(resources.GetObject("TSJudges.Image")));
            this.TSJudges.Name = "TSJudges";
            this.TSJudges.Size = new System.Drawing.Size(76, 20);
            this.TSJudges.Text = "&Judge";
            // 
            // TSAddJudge
            // 
            this.TSAddJudge.Image = ((System.Drawing.Image)(resources.GetObject("TSAddJudge.Image")));
            this.TSAddJudge.Name = "TSAddJudge";
            this.TSAddJudge.Size = new System.Drawing.Size(140, 22);
            this.TSAddJudge.Text = "&Add";
            this.TSAddJudge.Click += new System.EventHandler(this.TSAddJudge_Click);
            // 
            // TSShowJudge
            // 
            this.TSShowJudge.Image = ((System.Drawing.Image)(resources.GetObject("TSShowJudge.Image")));
            this.TSShowJudge.Name = "TSShowJudge";
            this.TSShowJudge.Size = new System.Drawing.Size(140, 22);
            this.TSShowJudge.Text = "List All";
            this.TSShowJudge.Click += new System.EventHandler(this.TSShowJudge_Click);
            // 
            // TSCourts
            // 
            this.TSCourts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSAddCourt,
            this.TSShowCourt});
            this.TSCourts.Image = ((System.Drawing.Image)(resources.GetObject("TSCourts.Image")));
            this.TSCourts.Name = "TSCourts";
            this.TSCourts.Size = new System.Drawing.Size(76, 20);
            this.TSCourts.Text = "&Court";
            // 
            // TSAddCourt
            // 
            this.TSAddCourt.Image = ((System.Drawing.Image)(resources.GetObject("TSAddCourt.Image")));
            this.TSAddCourt.Name = "TSAddCourt";
            this.TSAddCourt.Size = new System.Drawing.Size(140, 22);
            this.TSAddCourt.Text = "&Add";
            this.TSAddCourt.Click += new System.EventHandler(this.TSAddCourt_Click);
            // 
            // TSShowCourt
            // 
            this.TSShowCourt.Image = ((System.Drawing.Image)(resources.GetObject("TSShowCourt.Image")));
            this.TSShowCourt.Name = "TSShowCourt";
            this.TSShowCourt.Size = new System.Drawing.Size(140, 22);
            this.TSShowCourt.Text = "List All";
            this.TSShowCourt.Click += new System.EventHandler(this.TSShowCourt_Click);
            // 
            // TSCaseType
            // 
            this.TSCaseType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSAddCaseType,
            this.TSShowCaseType});
            this.TSCaseType.Image = ((System.Drawing.Image)(resources.GetObject("TSCaseType.Image")));
            this.TSCaseType.Name = "TSCaseType";
            this.TSCaseType.Size = new System.Drawing.Size(108, 20);
            this.TSCaseType.Text = "Case &Type";
            // 
            // TSAddCaseType
            // 
            this.TSAddCaseType.Image = ((System.Drawing.Image)(resources.GetObject("TSAddCaseType.Image")));
            this.TSAddCaseType.Name = "TSAddCaseType";
            this.TSAddCaseType.Size = new System.Drawing.Size(140, 22);
            this.TSAddCaseType.Text = "&Add";
            this.TSAddCaseType.Click += new System.EventHandler(this.TSAddCaseType_Click);
            // 
            // TSShowCaseType
            // 
            this.TSShowCaseType.Image = ((System.Drawing.Image)(resources.GetObject("TSShowCaseType.Image")));
            this.TSShowCaseType.Name = "TSShowCaseType";
            this.TSShowCaseType.Size = new System.Drawing.Size(140, 22);
            this.TSShowCaseType.Text = "List All";
            this.TSShowCaseType.Click += new System.EventHandler(this.TSShowCaseType_Click);
            // 
            // TSActs
            // 
            this.TSActs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSAddAct,
            this.TSShowActs});
            this.TSActs.Image = ((System.Drawing.Image)(resources.GetObject("TSActs.Image")));
            this.TSActs.Name = "TSActs";
            this.TSActs.Size = new System.Drawing.Size(68, 20);
            this.TSActs.Text = "&Acts";
            // 
            // TSAddAct
            // 
            this.TSAddAct.Image = ((System.Drawing.Image)(resources.GetObject("TSAddAct.Image")));
            this.TSAddAct.Name = "TSAddAct";
            this.TSAddAct.Size = new System.Drawing.Size(140, 22);
            this.TSAddAct.Text = "&Add";
            this.TSAddAct.Click += new System.EventHandler(this.TSAddAct_Click);
            // 
            // TSShowActs
            // 
            this.TSShowActs.Image = ((System.Drawing.Image)(resources.GetObject("TSShowActs.Image")));
            this.TSShowActs.Name = "TSShowActs";
            this.TSShowActs.Size = new System.Drawing.Size(140, 22);
            this.TSShowActs.Text = "List All";
            this.TSShowActs.Click += new System.EventHandler(this.TSShowActs_Click);
            // 
            // TSReports
            // 
            this.TSReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.showAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.reportToolStripMenuItem4,
            this.toolStripSeparator2,
            this.actsToolStripMenuItem,
            this.caseTypesToolStripMenuItem});
            this.TSReports.Image = ((System.Drawing.Image)(resources.GetObject("TSReports.Image")));
            this.TSReports.Name = "TSReports";
            this.TSReports.Size = new System.Drawing.Size(92, 20);
            this.TSReports.Text = "Reports";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem.Image")));
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aToolStripMenuItem.Text = "Judges";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showAllToolStripMenuItem.Image")));
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showAllToolStripMenuItem.Text = "Courts";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // reportToolStripMenuItem4
            // 
            this.reportToolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem4.Image")));
            this.reportToolStripMenuItem4.Name = "reportToolStripMenuItem4";
            this.reportToolStripMenuItem4.Size = new System.Drawing.Size(156, 22);
            this.reportToolStripMenuItem4.Text = "Case";
            this.reportToolStripMenuItem4.Click += new System.EventHandler(this.reportToolStripMenuItem4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // actsToolStripMenuItem
            // 
            this.actsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actsToolStripMenuItem.Image")));
            this.actsToolStripMenuItem.Name = "actsToolStripMenuItem";
            this.actsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.actsToolStripMenuItem.Text = "Acts";
            this.actsToolStripMenuItem.Click += new System.EventHandler(this.actsToolStripMenuItem_Click_1);
            // 
            // caseTypesToolStripMenuItem
            // 
            this.caseTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("caseTypesToolStripMenuItem.Image")));
            this.caseTypesToolStripMenuItem.Name = "caseTypesToolStripMenuItem";
            this.caseTypesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.caseTypesToolStripMenuItem.Text = "Case Types";
            this.caseTypesToolStripMenuItem.Click += new System.EventHandler(this.caseTypesToolStripMenuItem_Click);
            // 
            // TSUser
            // 
            this.TSUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.userListToolStripMenuItem,
            this.databaseConfigurationToolStripMenuItem});
            this.TSUser.Image = ((System.Drawing.Image)(resources.GetObject("TSUser.Image")));
            this.TSUser.Name = "TSUser";
            this.TSUser.Size = new System.Drawing.Size(140, 20);
            this.TSUser.Text = "User Settings";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.userListToolStripMenuItem.Text = "User List";
            this.userListToolStripMenuItem.Click += new System.EventHandler(this.userListToolStripMenuItem_Click);
            // 
            // databaseConfigurationToolStripMenuItem
            // 
            this.databaseConfigurationToolStripMenuItem.Name = "databaseConfigurationToolStripMenuItem";
            this.databaseConfigurationToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.databaseConfigurationToolStripMenuItem.Text = "Database Configuration";
            this.databaseConfigurationToolStripMenuItem.Click += new System.EventHandler(this.databaseConfigurationToolStripMenuItem_Click);
            // 
            // MSAdvocate
            // 
            this.MSAdvocate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MSAdvocate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSAdvocate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSJudges,
            this.TSCourts,
            this.TSCaseType,
            this.TSActs,
            this.TSReports,
            this.TSUser});
            this.MSAdvocate.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MSAdvocate.Location = new System.Drawing.Point(0, 0);
            this.MSAdvocate.Name = "MSAdvocate";
            this.MSAdvocate.Size = new System.Drawing.Size(579, 24);
            this.MSAdvocate.TabIndex = 6;
            this.MSAdvocate.Text = "menuStrip2";
            // 
            // btnAddCase
            // 
            this.btnAddCase.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCase.Image")));
            this.btnAddCase.Location = new System.Drawing.Point(127, 36);
            this.btnAddCase.Name = "btnAddCase";
            this.btnAddCase.Size = new System.Drawing.Size(93, 89);
            this.btnAddCase.TabIndex = 9;
            this.btnAddCase.Text = "Add New Case";
            this.btnAddCase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCase.UseVisualStyleBackColor = true;
            this.btnAddCase.Click += new System.EventHandler(this.btnAddCase_Click);
            // 
            // btnListCase
            // 
            this.btnListCase.Image = ((System.Drawing.Image)(resources.GetObject("btnListCase.Image")));
            this.btnListCase.Location = new System.Drawing.Point(242, 36);
            this.btnListCase.Name = "btnListCase";
            this.btnListCase.Size = new System.Drawing.Size(93, 89);
            this.btnListCase.TabIndex = 10;
            this.btnListCase.Text = "List All Cases";
            this.btnListCase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListCase.UseVisualStyleBackColor = true;
            this.btnListCase.Click += new System.EventHandler(this.btnListCase_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(579, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssl
            // 
            this.ssl.Name = "ssl";
            this.ssl.Size = new System.Drawing.Size(16, 17);
            this.ssl.Text = "...";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(472, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 89);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 136);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Upcoming Case Dates";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnLogin;
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(579, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnListCase);
            this.Controls.Add(this.btnAddCase);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.MSAdvocate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advocate\'s Digital Diary";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MSAdvocate.ResumeLayout(false);
            this.MSAdvocate.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem TSJudges;
        private System.Windows.Forms.ToolStripMenuItem TSAddJudge;
        private System.Windows.Forms.ToolStripMenuItem TSShowJudge;
        private System.Windows.Forms.ToolStripMenuItem TSCourts;
        private System.Windows.Forms.ToolStripMenuItem TSAddCourt;
        private System.Windows.Forms.ToolStripMenuItem TSShowCourt;
        private System.Windows.Forms.ToolStripMenuItem TSCaseType;
        private System.Windows.Forms.ToolStripMenuItem TSAddCaseType;
        private System.Windows.Forms.ToolStripMenuItem TSShowCaseType;
        private System.Windows.Forms.ToolStripMenuItem TSActs;
        private System.Windows.Forms.ToolStripMenuItem TSAddAct;
        private System.Windows.Forms.ToolStripMenuItem TSShowActs;
        private System.Windows.Forms.ToolStripMenuItem TSReports;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem TSUser;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MSAdvocate;
        private System.Windows.Forms.Button btnAddCase;
        private System.Windows.Forms.Button btnListCase;
        private System.Windows.Forms.ToolStripMenuItem actsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem databaseConfigurationToolStripMenuItem;
    }
}