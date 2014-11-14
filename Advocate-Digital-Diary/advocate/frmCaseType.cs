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
    public partial class frmCaseType : Form
    {
        public enum eTranType
        {
            NEW = 1,
            Edit = 2
        }
        eTranType localmode;
        int CstId;
        public frmCaseType()
        {
            InitializeComponent();
        }
        public void StartCaseType(eTranType mode, int value)
        {
            localmode = mode;
            CstId= value;
            if (localmode == eTranType.Edit)
            {
                BLLcasetype obj = new BLLcasetype();
                obj.GetCaseType(CstId);
                txtCaeTypeDescription.Text = obj.Description;
                txtCaseTypeName.Text = obj.CaseTypeName;
            }
            this.ShowDialog();
        }
        private void btnSaveCaseType_Click(object sender, EventArgs e)
        {
            if (localmode == eTranType.NEW)
            {
                if (txtCaseTypeName.Text.Length != 0)
                {
                    BLLcasetype obj = new BLLcasetype();
                   
                    obj.CaseTypeName = txtCaseTypeName.Text;
                    obj.Description = txtCaeTypeDescription.Text;
                    obj.SaveCaseType();
                    sslabelCaseType.Text = "case added successfully";
                    localmode = eTranType.NEW;
                    txtCaseTypeName.Clear();
                    txtCaeTypeDescription.Clear();
                }
                else
                {
                    sslabelCaseType.Text = "Please enter a valid case type name";
                }
            }
            else if (localmode == eTranType.Edit)
            {
                BLLcasetype obj = new BLLcasetype();
                obj.CaseTypeId = CstId;
                obj.CaseTypeName = txtCaseTypeName.Text;
                obj.Description = txtCaeTypeDescription.Text;
                obj.UpdateCaseType();
                sslabelCaseType.Text = "updated";
                localmode = eTranType.NEW;
                txtCaeTypeDescription.Clear();
                txtCaseTypeName.Clear();
            }
        }
        private void btnCaseTypeCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
