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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            BLLUser obj = new BLLUser();
            DataTable tb = obj.GetAllusers();
            dgvUsers.DataSource = tb;
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[5].Visible = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to delete it??","Delete?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (dgvUsers.SelectedRows.Count > 0)
                {
                    int a = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
                    BLLUser obj = new BLLUser();
                    obj.DeleteUser(a);
                    DataTable tb = obj.GetAllusers();
                    dgvUsers.DataSource = tb;
                    dgvUsers.Columns[0].Visible = false;
                    dgvUsers.Columns[5].Visible = false;

                    ssLabel.Text = "Deleted Successfully..";
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                FrmUser obj = new FrmUser();
                int a = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
                obj.StartUser(FrmUser.eTranType.Edit, a);

                BLLUser BLLobj = new BLLUser();
                DataTable tb = BLLobj.GetAllusers();
                dgvUsers.DataSource = tb;
                dgvUsers.Columns[0].Visible = false;
                dgvUsers.Columns[5].Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
