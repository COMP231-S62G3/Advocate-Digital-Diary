using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace advocate
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void courtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCourt obj = new frmCourt();
            obj.StartCourt(frmCourt.eTranType.NEW, 0);
        }

        private void judgeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            frmJudge obj = new frmJudge();
            obj.StartJudge(frmJudge.eTranType.NEW, 0);
            
        }

        private void TSAddJudge_Click(object sender, EventArgs e)
        {
            frmJudge obj = new frmJudge();
            obj.StartJudge(frmJudge.eTranType.NEW, 0);
        }

        private void TSAddCourt_Click(object sender, EventArgs e)
        {
            frmCourt obj = new frmCourt();
            obj.StartCourt(frmCourt.eTranType.NEW, 0);
        }

        private void TSAddCaseType_Click(object sender, EventArgs e)
        {
            frmCaseType obj = new frmCaseType();
            obj.StartCaseType(frmCaseType.eTranType.NEW, 0);
        }

        private void TSAddAct_Click(object sender, EventArgs e)
        {
            frmActs obj = new frmActs();
            obj.StartAct(frmActs.eTranType.NEW, 0);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptJudgeReport objRPT = new RptJudgeReport();
            DataTable tb = new MasterDataSet.DTJudgesDataTable();

            BLLjudge obj = new BLLjudge();
            tb = obj.GetAllJudges();

            objRPT.SetDataSource(tb);

            FrmReportViewer viewer = new FrmReportViewer();
            viewer.StartReport(objRPT);
        }

        private void TSShowJudge_Click(object sender, EventArgs e)
        {
            frmJudgesList obj = new frmJudgesList();
            obj.ShowDialog();
        }

        private void TSShowCourt_Click(object sender, EventArgs e)
        {
            frmCourtList obj = new frmCourtList();
            obj.ShowDialog();
        }

        private void TSShowCaseType_Click(object sender, EventArgs e)
        {
            frmCaseTypesList obj = new frmCaseTypesList();
            obj.ShowDialog();
        }

        private void TSShowActs_Click(object sender, EventArgs e)
        {
            frmActsList obj = new frmActsList();
            obj.ShowDialog();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptCourts objRPT = new RptCourts();
            DataTable tb = new MasterDataSet.DTCourtsDataTable();

            BLLcourt obj = new BLLcourt();
            tb = obj.GetAllCourt();

            objRPT.SetDataSource(tb);

            FrmReportViewer viewer = new FrmReportViewer();
            viewer.StartReport(objRPT);
        }

        private void reportToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            RptCase objRPT = new RptCase();
            DataTable tb = new MasterDataSet2.DTCaseDataTable();
            
            BLLCases obj = new BLLCases();
            tb = obj.GetAllCases();
            objRPT.SetDataSource(tb);

            FrmReportViewer viewer = new FrmReportViewer();
            viewer.StartReport(objRPT);

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser obj = new FrmUser();
            obj.StartUser(FrmUser.eTranType.NEW, 0);
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserList obj = new UserList();
            obj.ShowDialog();
        }

        private void btnAddCase_Click(object sender, EventArgs e)
        {

            frmCaseMaster obj = new frmCaseMaster();
            obj.StartCase(frmCaseMaster.eTranType.NEW, 0);
        }

        private void btnListCase_Click(object sender, EventArgs e)
        {
            frmCaseList obj = new frmCaseList();
            obj.ShowDialog();
        }

       
        private void actsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RptActs objRPT = new RptActs();
            DataTable tb = new MasterDataSet.DTActsDataTable();

            BLLActs obj = new BLLActs();
            tb = obj.GetActs();
            objRPT.SetDataSource(tb);

            FrmReportViewer viewer = new FrmReportViewer();
            viewer.StartReport(objRPT);

        }

        private void caseTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptCaseType objRPT = new RptCaseType();
            DataTable tb = new MasterDataSet.DTCaseTypesDataTable();

            BLLcasetype obj = new BLLcasetype();
            tb = obj.GetAllCaseType();

            objRPT.SetDataSource(tb);

            FrmReportViewer view = new FrmReportViewer();
            view.StartReport(objRPT);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            label1.Text = "Welcome To Advocate's Digital Diary..";

            TSJudges.Enabled = false;
            TSUser.Enabled = false; ;

            TSCaseType.Enabled = false;
            TSCourts.Enabled = false;
            TSReports.Enabled = false;
            TSActs.Enabled = false;
            btnAddCase.Enabled = false;
            btnListCase.Enabled = false;
            btnLogout.Enabled = false;
            btnLogin.Enabled = true;
            btnExit.Enabled = true;
            ssl.Text = "Logged Out Successfully...";
            dataGridView1.DataSource = null;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin obj = new FrmLogin();
            int a = obj.StartLogin();

            if (a > 0)
            {

                if (Program.UserType == "Admin")
                {
                    label1.Text = "Upcoming Hearing Dates";

                    TSJudges.Enabled = true;
                    TSCaseType.Enabled = true;
                    TSCourts.Enabled = true;
                    TSReports.Enabled = true;
                    TSShowActs.Enabled = true;
                    TSShowCaseType.Enabled = true;
                    TSShowCourt.Enabled = true;
                    TSShowJudge.Enabled = true;
                    TSActs.Enabled = true;
                    TSUser.Enabled = true;
                    btnAddCase.Enabled = true;
                    btnListCase.Enabled = true;
                    btnLogout.Enabled = true;
                    btnLogin.Enabled = false;
                    btnExit.Enabled = false;
                    ssl.Text = "Welcome Admin..";

                    BllHearingDate objb = new BllHearingDate();
                    dataGridView1.DataSource = objb.GetUpcomingCases();

                }
                else
                {
                    label1.Text = "Upcoming Hearing Dates";

                    TSReports.Enabled = (Program.Permissions.Substring(0, 1) == "1" ? true : false);
                    TSJudges.Enabled = (Program.Permissions.Substring(0, 1) == "1" ? true : false);
                    TSCaseType.Enabled = (Program.Permissions.Substring(0, 1) == "1" ? true : false);
                    TSCourts.Enabled = (Program.Permissions.Substring(0, 1) == "1" ? true : false);
                    TSReports.Enabled = (Program.Permissions.Substring(0, 1) == "1" ? true : false);
                    TSActs.Enabled = (Program.Permissions.Substring(0, 1) == "1" ? true : false);
                    btnAddCase.Enabled = (Program.Permissions.Substring(0, 1) == "1" ? true : false);
                    btnListCase.Enabled = (Program.Permissions.Substring(0, 1) == "1" ? true : false);
                    btnLogout.Enabled = (Program.Permissions.Substring(0, 1) == "1" ? true : false);
                    TSShowActs.Enabled = false;
                    TSUser.Enabled = false;
                    TSShowCaseType.Enabled = false;
                    TSShowCourt.Enabled = false;
                    TSShowJudge.Enabled = false;
                    btnLogin.Enabled = false;
                    btnExit.Enabled = false;
                    ssl.Text = "Welcome user...";

                    BllHearingDate objb = new BllHearingDate();
                    dataGridView1.DataSource = objb.GetUpcomingCases();

                }

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome To Advocate's Digital Diary..";
            TSJudges.Enabled = false;
            TSCaseType.Enabled = false;
            TSCourts.Enabled = false;
            TSReports.Enabled = false;
            TSActs.Enabled = false;
            TSUser.Enabled = false; ;
            btnAddCase.Enabled = false;
            btnListCase.Enabled = false;
            btnLogout.Enabled = false;
            btnLogin.Enabled = true;
            TSShowActs.Enabled = false;
            TSUser.Enabled = false;
            TSShowCaseType.Enabled = false;
            TSShowCourt.Enabled = false;
            TSShowJudge.Enabled = false;
            ssl.Text = "Press login to start...";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void databaseConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguration obj = new frmConfiguration();
            obj.ShowDialog();
        }

            

    }
}
