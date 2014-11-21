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
    public partial class frmPayment : Form
    {
        public void StartPayment(int value)
        {
            
        }
        public enum eTranType
        {
            
        }
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateData()
        {
            if (txtAmount.Text.Length == 0)
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = " Please enter amount...";
                return (false);
            }
            if (txtParticular.Text.Length == 0)
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = " Please enter a Particular No...";
                return (false);
            }
            if (txtBank.Text.Length == 0)
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = " Please enter a valid Bank Name...";
                return (false);
            }
            
            
            return (true);
        }

        private bool ValidateData1()
        {
            if (txtAmount.Text.Length == 0)
            {
                sslabel.ForeColor = Color.Red;
                sslabel.Text = " Please enter amount...";
                return (false);
            }
           return (true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void cboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBank_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
