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
    public partial class frmCourt : Form
    {
        public enum eTranType
        {
            NEW = 1,
            Edit = 2
        }
        eTranType localmode;
        int CrtId;

        public frmCourt()
        {
            InitializeComponent();
        }

        public void StartCourt(eTranType mode, int value)
        {
            localmode = mode;
            CrtId = value;
            if (localmode == eTranType.Edit)
            {
                BLLcourt obj = new BLLcourt();
                obj.GetCourt(CrtId);
                txtCourtName.Text = obj.CourtName;
                txtState.Text = obj.State;
                txtCity.Text = obj.City;
                txtDescription.Text = obj.Description;
            }
            this.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (localmode == eTranType.NEW)
            {
                if (txtCourtName.Text.Length != 0 && txtState.Text.Length != 0 && txtCity.Text.Length != 0)
                {
                    BLLcourt obj = new BLLcourt();
                    obj.CourtName = txtCourtName.Text;
                    obj.State = txtState.Text;
                    obj.City = txtCity.Text;
                    obj.Description = txtDescription.Text;
                    obj.SaveCourt();
                    sslabelCourts.Text = "court added successfully";
                    txtCourtName.Clear();
                    txtCity.Clear();
                    txtDescription.Clear();
                    txtState.Clear();
                }
                else if(txtCourtName.Text.Length == 0)
                {
                    sslabelCourts.Text = "Please enter a valid court name";
                }
                else if (txtState.Text.Length == 0)
                {
                    sslabelCourts.Text = "Please enter a valid State";
                }
                else if (txtCity.Text.Length == 0)
                {
                    sslabelCourts.Text = "Please enter a valid City";
                }
            }
            else if (localmode == eTranType.Edit)
            {
                BLLcourt obj = new BLLcourt();
                obj.CourtId = CrtId;
                obj.CourtName = txtCourtName.Text;
                obj.State = txtState.Text;
                obj.City = txtCity.Text;
                obj.Description = txtDescription.Text;
                obj.UpdateCourt();
                sslabelCourts.Text = "updated";
                localmode = eTranType.NEW;

                txtCourtName.Clear();
                txtCity.Clear();
                txtDescription.Clear();
                txtState.Clear();

            }
        
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCourt_Load(object sender, EventArgs e)
        {
            
        }
    }
}
