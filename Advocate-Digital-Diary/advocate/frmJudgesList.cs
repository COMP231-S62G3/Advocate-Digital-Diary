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
    public partial class frmJudgesList : Form
    {
        public frmJudgesList()
        {
            InitializeComponent();
        }

        private void frmShowjudge_Load(object sender, EventArgs e)
        {
            BLLjudge obj = new BLLjudge();
            DataTable tb = obj.GetAllJudges();
            dgvShowJudge.DataSource = tb;
            dgvShowJudge.Columns[0].Visible = false;
        }

        private void btnShowJudgeDelete_Click(object sender, EventArgs e)
        {

            if (dgvShowJudge.SelectedRows.Count > 0)
            {
                 DialogResult dr;
                dr = MessageBox.Show("Do You Want To Delete it?","Delete?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    BLLjudge obj = new BLLjudge();
                    obj.JudgeId = Convert.ToInt32(dgvShowJudge.SelectedRows[0].Cells[0].Value);
                    obj.DeleteJudge();
                    sslabelShowJudge.Text = "Judge Record Deleted Successfully...";

                    BLLjudge BLLobj = new BLLjudge();
                    DataTable tb = BLLobj.GetAllJudges();
                    dgvShowJudge.DataSource = tb;
                    dgvShowJudge.Columns[0].Visible = false;

                }
               
            }
            else
            {
                sslabelShowJudge.Text = "please select an item";
            }
            
        }

        private void btnShowJudgeEdit_Click(object sender, EventArgs e)
        {
            if (dgvShowJudge.SelectedRows.Count > 0)
            {
                frmJudge obj = new frmJudge();
                int a = Convert.ToInt32(dgvShowJudge.SelectedRows[0].Cells[0].Value);
                obj.StartJudge(frmJudge.eTranType.Edit, a);

                BLLjudge BLLobj = new BLLjudge();
                DataTable tb = BLLobj.GetAllJudges();
                dgvShowJudge.DataSource = tb;
                dgvShowJudge.Columns[0].Visible = false;
            }
            else
            {
                sslabelShowJudge.Text = "please select an item";
            }
        }

        private void btnShowJudgeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
