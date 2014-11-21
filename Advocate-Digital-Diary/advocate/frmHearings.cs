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
    public partial class frmHearings : Form
    {
        BllHearingDate obj = new BllHearingDate();
        int caseId;
        public void StartDate(int value)
        {
            caseId = value;
            this.ShowDialog();
        }
        public frmHearings()
        {
            InitializeComponent();
        }

        private void frmHearings_Load(object sender, EventArgs e)
        {
            BllHearingDate obj2 = new BllHearingDate();
            DataTable tb = obj2.GetDates(caseId);
            dgvHearings.DataSource = tb;
            dgvHearings.Columns[0].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check1 = ValidateData();
            if (check1 == true)
            {
                obj.Date = dtpHearings.Value;
                obj.Description = txtDescription.Text;
                obj.CaseId = caseId;
                obj.SaveDate();
                ssLabelHearing.ForeColor = Color.Black;
                ssLabelHearing.Text = "New Date Record Added Successfully....";
                txtDescription.Clear();


                BllHearingDate obj2 = new BllHearingDate();
                DataTable tb = obj2.GetDates(caseId);
                dgvHearings.DataSource = tb;
                dgvHearings.Columns[0].Visible = false;
            }
        }

        private bool ValidateData()
        {
            if (txtDescription.Text.Length == 0)
            {
                ssLabelHearing.ForeColor = Color.Red;
                ssLabelHearing.Text = " Please enter a valid Name...";
                return (false);
            }
            
            return (true);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvHearings.SelectedRows.Count > 0)
            {
                DialogResult dr;
                dr = MessageBox.Show("Do You Want To Delete it?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    obj.HearingDateNo = Convert.ToInt32(dgvHearings.SelectedRows[0].Cells[0].Value);
                    obj.DeleteDate();
                    ssLabelHearing.ForeColor = Color.Black;
                    ssLabelHearing.Text = "Date Record Successfully Removed...";

                    BllHearingDate obj2 = new BllHearingDate();
                    DataTable tb = obj2.GetDates(caseId);
                    dgvHearings.DataSource = tb;
                    dgvHearings.Columns[0].Visible = false;

                }

            }
            else
            {
                ssLabelHearing.ForeColor = Color.Red;
                ssLabelHearing.Text = "Please select an item...";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStatement_Click(object sender, EventArgs e)
        {
            if (dgvHearings.SelectedRows.Count > 0)
            {
                BllStatement objbll = new BllStatement();
                int a = Convert.ToInt32(dgvHearings.SelectedRows[0].Cells[0].Value);

                frmStatements objs = new frmStatements();
                objs.StartStatement(caseId,a);   
            }
        }
    }
}
