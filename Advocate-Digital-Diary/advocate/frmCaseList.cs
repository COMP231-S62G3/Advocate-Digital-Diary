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
    public partial class frmCaseList : Form
    {
        int Caseid;
        public frmCaseList()
        {
            InitializeComponent();
        }

        private void frmCaseList_Load(object sender, EventArgs e)
        {
            BLLCases obj = new BLLCases();
            DataTable tb = obj.GetAllCases();
            dgvCaseList.DataSource = tb;
            dgvCaseList.Columns[0].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {
                
                frmCaseMaster obj = new frmCaseMaster();
                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);
                obj.StartCase(frmCaseMaster.eTranType.Edit, a);

                BLLCases obj1 = new BLLCases();
                dgvCaseList.DataSource = obj1.GetAllCases();
                
            }
            else
            {
                MessageBox.Show("please select an item");
            }
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {
                DialogResult dr;
                dr = MessageBox.Show("Do You Want To Delete it?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    BLLCases obj = new BLLCases();
                    obj.CaseId = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);
                    obj.DeleteCase();
                    ssCaseList.Text =  "Case Record Deleted Successfully...";

                   
                    dgvCaseList.DataSource = obj.GetAllCases(); 
                   
                }

            }
            else
            {
              ssCaseList.Text = "please select an item";
            }
            
        }
       
        private void witnessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {
                frmWitnesses objw = new frmWitnesses();
                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);
                objw.StartWitness(a);
            }
            else
            {
                ssCaseList.Text = "Please Select an item";
            }
        }

        private void hearingDatesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {
                frmHearings objw = new frmHearings();
                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);
                objw.StartDate(a);
            }
            else
            {
                ssCaseList.Text = "Please Select an item";
            }
            
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {
                frmDocument objd = new frmDocument();
                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);
                objd.StartDocument(a);
            }
            else
            {
                ssCaseList.Text = "Please Select an item";
            }
            
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {
                frmPayment objp = new frmPayment();
                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);
                objp.StartPayment(a);
            }
            else
            {
                ssCaseList.Text = "Please Select an item";
            }
            
        }

        private void hearingDatesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {
                frmHearings objw = new frmHearings();
                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);
                objw.StartDate(a);
            }
            else
            {
                ssCaseList.Text = "Please Select an item";
            }
            
        }

        private void witnessesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {
                frmWitnesses objw = new frmWitnesses();
                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);
                objw.StartWitness(a);
            }
            else
            {
                ssCaseList.Text = "Please Select an item";
            }
            
        }

        private void documentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {
                frmDocument objd = new frmDocument();
                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);
                objd.StartDocument(a);
            }
            else
            {
                ssCaseList.Text = "Please Select an item";
            }
            
        }

        private void paymentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {
                frmPayment objp = new frmPayment();
                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);
                objp.StartPayment(a);
            }
            else
            {
                ssCaseList.Text = "Please Select an item";
            }
            
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void witnessesToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (dgvCaseList.SelectedRows.Count > 0)
            {

                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);

                RptCaseWitness2 objRPT = new RptCaseWitness2();
                DataTable tb = new MasterDataSet2.DTCasesDataTable();
                DataTable tb1 = new MasterDataSet2.DTWitnessesDataTable();
                

                BLLCases objc = new BLLCases();
                BllWitness objW = new BllWitness();

                tb = objc.GetDetailForCase(a);
                tb1 = objW.GetWitnesses(a);
                
                objRPT.SetDataSource(tb);
                objRPT.Subreports[0].SetDataSource(tb1);
                FrmReportViewer viewer = new FrmReportViewer();
                viewer.StartReport(objRPT);
            }

        }

        private void paymentsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {

                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);

                RptCasePayment  objRPT = new RptCasePayment ();
                DataTable tb = new MasterDataSet2.DTCasesDataTable();
                DataTable tb1 = new MasterDataSet2.DTPaymentsDataTable();


                BLLCases objc = new BLLCases();
                BllPayment objP = new BllPayment();

                tb = objc.GetDetailForCase(a);
                tb1 = objP.GetPayment(a);

                objRPT.SetDataSource(tb);
                objRPT.Subreports[0].SetDataSource(tb1);
                FrmReportViewer viewer = new FrmReportViewer();
                viewer.StartReport(objRPT);
            }
        }

        private void documentsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {

                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);

                RptCaseDocument objRPT = new RptCaseDocument();
                DataTable tb = new MasterDataSet2.DTCasesDataTable();
                DataTable tb1 = new MasterDataSet2.DTDocumentsDataTable();


                BLLCases objc = new BLLCases();
                BllDocument objP = new BllDocument();

                tb = objc.GetDetailForCase(a);
                tb1 = objP.GetDocuments(a);

                objRPT.SetDataSource(tb);
                objRPT.Subreports[0].SetDataSource(tb1);
                FrmReportViewer viewer = new FrmReportViewer();
                viewer.StartReport(objRPT);
            }
        }

        private void hearingDatesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (dgvCaseList.SelectedRows.Count > 0)
            {

                int a = Convert.ToInt32(dgvCaseList.SelectedRows[0].Cells[0].Value);

                RptCaseHearingDates objRPT = new RptCaseHearingDates();
                DataTable tb = new MasterDataSet2.DTCasesDataTable();
                DataTable tb1 = new MasterDataSet2.DTHearingsDataTable();


                BLLCases objc = new BLLCases();
                BllHearingDate objP = new BllHearingDate();

                tb = objc.GetDetailForCase(a);
                tb1 = objP.GetDates(a);

                objRPT.SetDataSource(tb);
                objRPT.Subreports[0].SetDataSource(tb1);
                FrmReportViewer viewer = new FrmReportViewer();
                viewer.StartReport(objRPT);
            }
        }
    }
}
