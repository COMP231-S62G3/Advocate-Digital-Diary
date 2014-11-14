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
    public partial class frmJudge : Form
    {
        public enum eTranType
        {
            NEW = 1,
            Edit = 2
        }
        eTranType localmode;
        int JdgId;

        public frmJudge()
        {
            InitializeComponent();
        }

        public void StartJudge(eTranType mode, int value)
        {
            localmode = mode;
            JdgId = value;

            if (localmode == eTranType.Edit)
            {
                BLLjudge obj = new BLLjudge();
                obj.GetJudge(JdgId);
                txtJudgeName.Text = obj.JudgeName;
                txtjudgeaddress.Text = obj.JudgeAddress;
                if (obj.JudgeGender == "Male")
                {
                    rdbJudgeFemale.Checked = true;
                }
                else if (obj.JudgeGender == rdbJudgeFemale.Text)
                {
                    rdbJudgeFemale.Checked = true;
                }
                txtJudgePhone.Text = obj.JudgePhoneno.ToString();
            }
            this.ShowDialog();
        }

        private void frmjudge_Load(object sender, EventArgs e)
        {
        }

        private void btnSaveJudge_Click(object sender, EventArgs e)
        {
            if (localmode == eTranType.NEW)
            {
                if (txtJudgeName.Text.Length != 0 && txtjudgeaddress.Text.Length != 0 && txtJudgePhone.Text.Length != 0)
                {
                    BLLjudge obj = new BLLjudge();
                    obj.JudgeName = txtJudgeName.Text;
                    obj.JudgeAddress = txtjudgeaddress.Text;
                    if (rdbJudgeMale.Checked == true)
                    {
                        obj.JudgeGender = rdbJudgeMale.Text;
                    }
                    else
                    {
                        obj.JudgeGender = rdbJudgeFemale.Text;
                    }
                    obj.JudgePhoneno = Convert.ToInt32(txtJudgePhone.Text);
                    obj.SaveJudge();
                    sslabelJudge.Text = "Judge Record Added Successfully";
                    txtJudgeName.Clear();
                    txtjudgeaddress.Clear();
                    txtJudgePhone.Clear();
                }
                else if(txtJudgeName.Text.Length == 0)
                {
                    sslabelJudge.Text = "please enter a valid name";
                }
                else if (txtjudgeaddress.Text.Length == 0)
                {
                    sslabelJudge.Text = "please enter a valid address";
                }
                else if (txtJudgePhone.Text.Length == 0)
                {
                    sslabelJudge.Text = "please enter a valid phone no.";
                }
            }
            else if (localmode == eTranType.Edit)
            {
                BLLjudge obj = new BLLjudge();
                obj.JudgeId = JdgId;
                obj.JudgeName = txtJudgeName.Text;
                obj.JudgeAddress = txtjudgeaddress.Text;
                if (rdbJudgeMale.Checked == true)
                {
                    obj.JudgeGender = rdbJudgeMale.Text;
                }
                else
                {
                    obj.JudgeGender = rdbJudgeFemale.Text;
                }
                obj.JudgePhoneno = Convert.ToInt32(txtJudgePhone.Text);
                obj.UpdateJudge();
                sslabelJudge.Text = "Judge Record Updated Successfully...";
                localmode = eTranType.NEW;
                txtjudgeaddress.Clear();
                txtJudgeName.Clear();
                txtJudgePhone.Clear();
                rdbJudgeMale.Checked = true;
            }
            
        }

        private void btnCancelJudge_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtJudgePhone_KeyPress(object sender, KeyPressEventArgs e)
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
