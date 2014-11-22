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
    public partial class frmDocument : Form
    {
        int caseId;
        BllDocument obj = new BllDocument();
        public void StartDocument(int value)
        {
            caseId = value;
            this.ShowDialog();
        }
        public frmDocument()
        {
            InitializeComponent();
        }

        private void frmDocument_Load(object sender, EventArgs e)
        {
            BllDocument obj2 = new BllDocument();
            DataTable tb = obj2.GetDocuments(caseId);
            dgvDocument.DataSource = tb;
            dgvDocument.Columns[0].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateData()
        {
            if (txtName.Text.Length == 0)
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = " Please enter a valid Name...";
                return (false);
            }
           
            return (true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check1 = ValidateData();
            if (check1 == true)
            {
                obj.Name = txtName.Text;
                obj.ReceivingDate = dtDocument.Value;
                obj.Description = txtDescription.Text;
                obj.CaseId = caseId;
                obj.SaveDocument();
                sslabel.ForeColor = Color.Black;
                sslabel.Text = "New Document Added Successfully....";

                txtDescription.Clear();
                txtName.Clear();

                BllDocument obj2 = new BllDocument();
                DataTable tb = obj2.GetDocuments(caseId);
                dgvDocument.DataSource = tb;
                dgvDocument.Columns[0].Visible = false;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvDocument.SelectedRows.Count > 0)
            {
                DialogResult dr;
                dr = MessageBox.Show("Do You Want To Delete it?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    obj.DocumentNo = Convert.ToInt32(dgvDocument.SelectedRows[0].Cells[0].Value);
                    obj.DeleteDocument();
                    sslabel.ForeColor = Color.Black;
                    sslabel.Text = "Document Record Successfully Removed...";

                    BllDocument obj2 = new BllDocument();
                    DataTable tb = obj2.GetDocuments(caseId);
                    dgvDocument.DataSource = tb;
                    dgvDocument.Columns[0].Visible = false;
                }

            }
            else
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = "Please select an item...";
            }
        }
    }
}
