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
    public partial class frmActs : Form
    {
        public enum eTranType
        {
            NEW = 1,
            Edit = 2
        }
        eTranType localmode;
        int AcId;
        public frmActs()
        {
            InitializeComponent();
        }

        public void StartAct(eTranType mode, int value)
        {
            localmode = mode;
            AcId = value;
            if (localmode == eTranType.Edit)
            {
                BLLActs obj = new BLLActs();
                obj.GetAct(AcId);
                txtActName.Text = obj.ActName;
                txtActDescription.Text = obj.Description;
            }
            this.ShowDialog();
        }

        private void btnCancelAct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAct_Click(object sender, EventArgs e)
        {
            if (localmode == eTranType.NEW)
            {
                if (txtActName.Text.Length != 0 )
                {
                    BLLActs obj = new BLLActs();
                    obj.ActName = txtActName.Text;
                    obj.Description= txtActDescription.Text;
                    obj.SaveAct();
                    sslabelActs.Text = "ACT added successfully";
                    txtActName.Clear();
                    txtActDescription.Clear();
                }
                else
                {
                    sslabelActs.Text = "Please enter a valid Act name";
                }
            }
            else if (localmode == eTranType.Edit)
            {
                BLLActs obj = new BLLActs();
                obj.ActId = AcId;
                obj.ActName = txtActName.Text;
                obj.Description = txtActDescription.Text;
                obj.UpdateAct();
                sslabelActs.Text = "updated";
                localmode = eTranType.NEW;
                txtActDescription.Clear();
                txtActName.Clear();
            }
        }

        private void frmActs_Load(object sender, EventArgs e)
        {

        }
    }
}
