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
    public partial class frmWitnesses : Form
    {
        eTranType localmode;
        int caseId;
        BllWitness obj = new BllWitness();
        public void StartWitness(int value)
        {
            caseId = value;
            this.ShowDialog();
        }
        public enum eTranType
        {
            NEW = 1,
            Edit = 2
        }

        public frmWitnesses()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check1 = ValidateData();
            if (check1 == true)
            {
                obj.Name = txtWitnessName.Text;
                obj.Address = txtAddress.Text;
                obj.City = txtCity.Text;
                obj.Pin = Convert.ToInt32(txtPin.Text);
                obj.Phone = Convert.ToInt32(txtPhone.Text);
                obj.CaseId = caseId;
                obj.SaveWitness();
                sslabel.ForeColor = Color.Black;
                sslabel.Text = "New Witness Record Added Successfully....";
                txtAddress.Clear();
                txtCity.Clear();
                txtPhone.Clear();
                txtWitnessName.Clear();
                txtPin.Clear();



                BllWitness obj2 = new BllWitness();
                DataTable tb = obj2.GetWitnesses(caseId);
                dgvWitness.DataSource = tb;
                dgvWitness.Columns[0].Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWitnesses_Load(object sender, EventArgs e)
        {
            DataTable tb = obj.GetWitnesses(caseId);
            dgvWitness.DataSource = tb;
            dgvWitness.Columns[0].Visible = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvWitness.SelectedRows.Count > 0)
            {
                DialogResult dr;
                dr = MessageBox.Show("Do You Want To Delete it?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    obj.WitnessNo = Convert.ToInt32(dgvWitness.SelectedRows[0].Cells[0].Value);
                    obj.DeleteWitness();
                    sslabel.ForeColor = Color.Black;
                    sslabel.Text = "Witness Record Successfully Removed...";

                    BllWitness obj2 = new BllWitness();
                    DataTable tb = obj2.GetWitnesses(caseId);
                    dgvWitness.DataSource = tb;
                    dgvWitness.Columns[0].Visible = false;

                }

            }
            else
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = "Please select an item...";
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = (int)e.KeyChar;
            if (a != 8)
            {
                if (a < 48 || a > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool ValidateData()
        {
            if (txtWitnessName.Text.Length == 0)
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = " Please enter a valid Name...";
                return (false);
            }
            if (txtAddress.Text.Length == 0)
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = " Please enter a valid Address...";
                return (false);
            }
            if (txtCity.Text.Length == 0)
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = " Please enter a valid City...";
                return (false);
            }
            if (txtPin.Text.Length == 0)
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = " Please enter a valid Pin Code...";
                return (false);
            }
            if (txtPhone.Text.Length == 0)
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = " Please enter a valid Phone no...";
                return (false);
            }
            return (true);
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = (int)e.KeyChar;
            if (a != 8)
            {
                if (a < 48 || a > 57)
                {
                    e.Handled = true;
                }
            }
        }
   
    }
}
