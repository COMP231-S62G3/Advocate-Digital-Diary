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
    public partial class frmCourtList : Form
    {
        public frmCourtList()
        {
            InitializeComponent();
        }

        private void frmCourtShow_Load(object sender, EventArgs e)
        {
            BLLcourt obj = new BLLcourt();
            DataTable tb = obj.GetAllCourt();
            dgvcourt.DataSource = tb;
            dgvcourt.Columns[0].Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvcourt.SelectedRows.Count > 0)
            {
                frmCourt obj = new frmCourt();
                int a = Convert.ToInt32(dgvcourt.SelectedRows[0].Cells[0].Value);
                obj.StartCourt(frmCourt.eTranType.Edit, a);

                BLLcourt BLLobj = new BLLcourt();
                DataTable tb = BLLobj.GetAllCourt();
                dgvcourt.DataSource = tb;
                dgvcourt.Columns[0].Visible = false;
            }
            else
            {
                sslabelCourtShow.Text = "please select an item";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvcourt.SelectedRows.Count > 0)
            {
                DialogResult dr;
                dr = MessageBox.Show("Do You Want To Delete it?","Delete?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    BLLcourt obj = new BLLcourt();
                    obj.CourtId = Convert.ToInt32(dgvcourt.SelectedRows[0].Cells[0].Value);
                    obj.DeleteCourt();

                    BLLcourt BLLobj = new BLLcourt();
                    DataTable tb = BLLobj.GetAllCourt();
                    dgvcourt.DataSource = tb;
                    dgvcourt.Columns[0].Visible = false;

                    sslabelCourtShow.Text = "Court Record Deleted Successfully...";
                }
            }
            else
            {
                sslabelCourtShow.Text = "please select an item";
            }
        }

        private void btnShowCourtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
