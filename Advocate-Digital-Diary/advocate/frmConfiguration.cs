using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace advocate
{
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string CS;
            if (chkSecurity.Checked == true)
            {
                CS = "Server=" + txtServer.Text + ";Database=Advocate;Trusted_connection=yes";
            }
            else
            {
                CS = "Server=" + txtServer.Text + ";uid=" + txtUserid.Text + ";Password=" + txtPassword.Text + ";database=Advocate";
            }

            string strPath = Application.StartupPath + "\\DBConfig.CFG";

            FileStream FS = new FileStream(strPath, FileMode.Create);
            StreamWriter SW = new StreamWriter(FS);
            SW.WriteLine(CS);
            SW.Close();
            FS.Close();

            MessageBox.Show("Application is configured for database connectivity...", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void chkSecurity_CheckedChanged(object sender, EventArgs e)
        {
            txtUserid.Enabled = !chkSecurity.Checked;
            txtPassword.Enabled = !chkSecurity.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
