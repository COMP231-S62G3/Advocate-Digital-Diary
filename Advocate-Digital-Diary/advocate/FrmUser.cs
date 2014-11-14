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
    public partial class FrmUser : Form
    {
        public enum eTranType
        {
            NEW = 1,
            Edit = 2
        }
        public FrmUser()
        {
            InitializeComponent();
        }
        
        eTranType localmode;
        int UsrId;

        public void StartUser(eTranType mode, int value)
        {
            localmode = mode;
            UsrId = value;

            if (localmode == eTranType.Edit)
            {
                BLLUser obj = new BLLUser();
                obj.GetUser(UsrId);
                txtUserId.Text = obj.UserId;
                txtPassword.Text = obj.Password;
                if (obj.UserType == "Admin")
                {
                    radioButton1.Checked = true;
                }
                else if (obj.UserType == "Normal")
                {
                    radioButton2.Checked = true;
                }
                textBox2.Text = obj.UserName;
            }
            this.ShowDialog();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (localmode == eTranType.NEW)
            {
                bool check1 = ValidateData();
                if (check1 == true)
                {
                    BLLUser obj = new BLLUser();
                    obj.UserId = txtUserId.Text;
                    obj.Password = txtPassword.Text;
                    obj.UserName = textBox2.Text;
                    if (radioButton1.Checked == true)
                    {
                        obj.UserType = "Admin";
                        obj.Permissions = "11010111";
                    }
                    else
                    {
                        obj.UserType = "Normal";
                        obj.Permissions = "11010110";
                    }
                    obj.SaveUser();

                    txtPassword.Clear();
                    txtUserId.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    radioButton2.Checked = true;
                    sslabelMessage.Text = "Saved Successfully...";
                }
            }
            else if (localmode == eTranType.Edit)
            {
                BLLUser obj1 = new BLLUser();
                obj1.UserNo = UsrId;
                obj1.UserId = txtUserId.Text;
                obj1.Password = txtPassword.Text;
                obj1.UserName = textBox2.Text;
                if (radioButton1.Checked == true)
                {
                    obj1.UserType = "Admin";
                    obj1.Permissions = "11010111";
                }
                else
                {
                    obj1.UserType = "Normal";
                    obj1.Permissions = "11010110";
                }
                obj1.UpdateUser(UsrId);

                localmode = eTranType.NEW;
                txtPassword.Clear();
                txtUserId.Clear();
                textBox1.Clear();
                textBox2.Clear();
                radioButton2.Checked = true;

                sslabelMessage.Text = "Updated...";
            }
            
        }
        private bool ValidateData()
        {
            if (txtUserId.Text.Length == 0)
            {
                sslabelMessage.ForeColor = Color.Red;
                sslabelMessage.Text = " Please enter a valid UserId...";
                return (false);
            }
            if (txtPassword.Text.Length == 0)
            {
                sslabelMessage.ForeColor = Color.Red;
                sslabelMessage.Text = " Please enter a valid Password...";
                return (false);
            }
            if (textBox2.Text.Length == 0)
            {
                sslabelMessage.ForeColor = Color.Red;
                sslabelMessage.Text = " Please enter a valid Name...";
                return (false);
            }
            if (txtPassword.Text!=textBox1.Text)
            {
                sslabelMessage.ForeColor = Color.Red;
                sslabelMessage.Text = " Password not matched...";
                return (false);
            }
           
            return (true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
