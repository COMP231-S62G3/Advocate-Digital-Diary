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
    public partial class frmActsList : Form
    {
        public frmActsList()
        {
            InitializeComponent();
        }

        private void frmShowActs_Load(object sender, EventArgs e)
        {
            BLLActs obj = new BLLActs();
            DataTable tb = obj.GetActs();
            dgvActs.DataSource = tb;
            dgvActs.Columns[0].Visible = false;
        }

        private void btnActsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActsEdit_Click(object sender, EventArgs e)
        {
            if (dgvActs.SelectedRows.Count > 0)
            {
                frmActs obj = new frmActs();
                int a = Convert.ToInt32(dgvActs.SelectedRows[0].Cells[0].Value);
                obj.StartAct(frmActs.eTranType.Edit, a);

                BLLActs BLLobj = new BLLActs();
                DataTable tb = BLLobj.GetActs();
                dgvActs.DataSource = tb;
                dgvActs.Columns[0].Visible = false;

            }
            else
            {
               sslabelShowActs.Text = "please select an item";
            }
        }

        private void btnActsDelete_Click(object sender, EventArgs e)
        {
            if (dgvActs.SelectedRows.Count > 0)
            {
                 DialogResult dr;
                dr = MessageBox.Show("Do You Want To Delete it?","Delete?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    BLLActs obj = new BLLActs();
                    obj.ActId = Convert.ToInt32(dgvActs.SelectedRows[0].Cells[0].Value);
                    obj.DeleteAct();

                    BLLActs BLLobj = new BLLActs();
                    DataTable tb = BLLobj.GetActs();
                    dgvActs.DataSource = tb;
                    dgvActs.Columns[0].Visible = false;


                    sslabelShowActs.Text = "Act Record deleted successfully...";
                }
               
            }
            else
            {
                sslabelShowActs.Text = "please select an item";
            }
        }
    }
}
