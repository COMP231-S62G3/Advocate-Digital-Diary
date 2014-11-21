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
    public partial class FrmLogin : Form
    {
        int UserNo;
        public FrmLogin()
        {
            InitializeComponent();
        }

        public int StartLogin()
        {
            this.ShowDialog();
            return (UserNo);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BLLUser obj = new BLLUser();
            obj.UserId = txtUserName.Text;
            obj.Password = txtPassword.Text;
            UserNo = obj.AuthenticateUser();

            if (UserNo > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID or password Invalid!", "Invalid!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserNo = 0;
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
