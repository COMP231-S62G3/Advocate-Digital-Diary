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
    public partial class frmCaseTypesList : Form
    {
        public frmCaseTypesList()
        {
            InitializeComponent();
        }

        private void frmshowcasetype_Load(object sender, EventArgs e)
        {
            BLLcasetype obj = new BLLcasetype();
            DataTable tb = obj.GetAllCaseType();
            dgvCaseType.DataSource = tb;
            dgvCaseType.Columns[0].Visible = false;
        }

        private void btnCaseTypeEdit_Click(object sender, EventArgs e)
        {
            if (dgvCaseType.SelectedRows.Count > 0)
            {
                frmCaseType obj = new frmCaseType();
                int a = Convert.ToInt32(dgvCaseType.SelectedRows[0].Cells[0].Value);
                obj.StartCaseType(frmCaseType.eTranType.Edit, a);

                BLLcasetype obj1 = new BLLcasetype();
                DataTable tb = obj1.GetAllCaseType();
                dgvCaseType.DataSource = tb;
                dgvCaseType.Columns[0].Visible = false;
            }
            else
            {
                sslabelCaseType.Text = "please select an item";
            }
        }

        private void btnCaseTypeDelete_Click(object sender, EventArgs e)
        {
            if (dgvCaseType.SelectedRows.Count > 0)
            {
                 DialogResult dr;
                dr = MessageBox.Show("Do You Want To Delete it?","Delete?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    BLLcasetype obj = new BLLcasetype();
                    obj.CaseTypeId = Convert.ToInt32(dgvCaseType.SelectedRows[0].Cells[0].Value);
                    obj.DeleteCaseType();
                    sslabelCaseType.Text = "deleted";

                    BLLcasetype obj1 = new BLLcasetype();
                    DataTable tb = obj1.GetAllCaseType();
                    dgvCaseType.DataSource = tb;
                    dgvCaseType.Columns[0].Visible = false;
                }
                
            }
            else
            {
                sslabelCaseType.Text = "please select an item";
            }
        }

        private void btnShowCaseTypeClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
