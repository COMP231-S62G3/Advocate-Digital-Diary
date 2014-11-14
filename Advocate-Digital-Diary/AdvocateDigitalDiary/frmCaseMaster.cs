using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvocateDigitalDiary
{
    public partial class frmCaseMaster : Form
    {
        eTranType localmode;
        int CsId;

        BLLCases obj = new BLLCases();
        int EntityType;

        public enum eTranType
        {
            NEW = 1,
            Edit = 2
        }
        
        public frmCaseMaster()
        {
            InitializeComponent();
        }

        public void StartCase(eTranType mode, int value)
        {
            localmode = mode;
            CsId = value;

            BLLcasetype obj1 = new BLLcasetype();
            cboCaseTypeId.DataSource = obj1.GetAllCaseType();
            cboCaseTypeId.DisplayMember = "Name";
            cboCaseTypeId.ValueMember = "CaseTypeId";

            BLLjudge obj2 = new BLLjudge();
            cboCaseJudgeId.DataSource = obj2.GetAllJudges();
            cboCaseJudgeId.DisplayMember = "Name";
            cboCaseJudgeId.ValueMember = "JudgeId";

            BLLcourt obj3 = new BLLcourt();
            cboCourtTypeId.DataSource = obj3.GetAllCourt();
            cboCourtTypeId.DisplayMember = "Name";
            cboCourtTypeId.ValueMember = "CourtId";

            if (localmode == eTranType.Edit)
            {
                obj.GetCase(CsId);
                txtCaseTitle.Text = obj.Title;
                DtCasesFileDate.Value = Convert.ToDateTime(obj.FileDate);
                cboCourtTypeId.Text = Convert.ToString(obj.CourtId);
                cboCaseJudgeId.Text = Convert.ToString(obj.JudgeId);
                cboCaseTypeId.Text = Convert.ToString(obj.CaseTypeId);
                txtDescription.Text = obj.Description;

                dgvPlantiff.DataSource = obj.tbPlaintiff;
                dgvPlantiff.Columns[5].Visible = false;
                dgvDefendent.DataSource = obj.tbDefendent;
                dgvDefendent.Columns[5].Visible = false;
            }
            this.ShowDialog();
        }

        private void btnAddPlantiff_Click(object sender, EventArgs e)
        {
            if (btnAddPlantiff.Text == "Add")
            {
                if (cboPlantiffPartyType.SelectedIndex == 0)
                {
                    bool check1 = ValidateParty();
                    if (check1 == true)
                    {
                        obj.AddPlaintiff(txtName.Text, txtAddress.Text, txtCity.Text, Convert.ToInt32(txtPin.Text), Convert.ToInt32(txtPhone.Text));
                        dgvPlantiff.DataSource = obj.tbPlaintiff;
                        dgvPlantiff.Columns[5].Visible = false;
                        ssCaseMaster.Text = "Plaintiff's Record Added...";

                        txtName.Clear();
                        txtAddress.Clear();
                        txtCity.Clear();
                        txtPin.Clear();
                        txtPhone.Clear();
                    }
                }
                else if (cboPlantiffPartyType.SelectedIndex == 1)
                {
                    obj.AddDefendant(txtName.Text, txtAddress.Text, txtCity.Text, Convert.ToInt32(txtPin.Text), Convert.ToInt32(txtPhone.Text));
                    dgvDefendent.DataSource = obj.tbDefendent;
                    dgvDefendent.Columns[5].Visible = false;
                    ssCaseMaster.Text = "Defendant's Record Added...";
                    txtName.Clear();
                    txtAddress.Clear();
                    txtCity.Clear();
                    txtPin.Clear();
                    txtPhone.Clear();
                }
                else
                {
                    ssCaseMaster.Text = "Please select a Party Type";
                }
            }
            else
            {

                if (EntityType == 1)
                {
                    obj.tbPlaintiff.Rows[dgvPlantiff.SelectedRows[0].Index][0] = txtName.Text;
                    obj.tbPlaintiff.Rows[dgvPlantiff.SelectedRows[0].Index][1] = txtAddress.Text;
                    obj.tbPlaintiff.Rows[dgvPlantiff.SelectedRows[0].Index][2] = txtCity.Text;
                    obj.tbPlaintiff.Rows[dgvPlantiff.SelectedRows[0].Index][3] = txtPin.Text;
                    obj.tbPlaintiff.Rows[dgvPlantiff.SelectedRows[0].Index][4] = txtPhone.Text;
                }
                else
                {
                    obj.tbDefendent.Rows[dgvPlantiff.SelectedRows[0].Index][0] = txtName.Text;
                    obj.tbDefendent.Rows[dgvPlantiff.SelectedRows[0].Index][1] = txtAddress.Text;
                    obj.tbDefendent.Rows[dgvPlantiff.SelectedRows[0].Index][2] = txtCity.Text;
                    obj.tbDefendent.Rows[dgvPlantiff.SelectedRows[0].Index][3] = txtPin.Text;
                    obj.tbDefendent.Rows[dgvPlantiff.SelectedRows[0].Index][4] = txtPhone.Text;
                }
                txtName.Clear();
                txtAddress.Clear();
                txtCity.Clear();
                txtPin.Clear();
                txtPhone.Clear();

                btnPlantiffReset.Text = "Reset";
                btnAddPlantiff.Text = "Add";
                dgvDefendent.Enabled = true;
                dgvPlantiff.Enabled = true;

                btnEditDefendent.Enabled = true;
                btnEditPlaintiff.Enabled = true;
                btnSaveCase.Enabled = true;


            }

        }

        private void btnPlantiffReset_Click(object sender, EventArgs e)
        {
            if (btnPlantiffReset.Text == "Reset")
            {
                txtName.Clear();
                txtAddress.Clear();
                txtCity.Clear();
                txtPin.Clear();
                txtPhone.Clear();
                ssCaseMaster.Text = "...";
            }
            else
            {
                txtName.Clear();
                txtAddress.Clear();
                txtCity.Clear();
                txtPin.Clear();
                txtPhone.Clear();

                btnPlantiffReset.Text = "Reset";
                btnAddPlantiff.Text = "Add";
                dgvPlantiff.Enabled = true;
                dgvDefendent.Enabled = true;

                btnEditDefendent.Enabled = true;
                btnEditPlaintiff.Enabled = true;
                btnSaveCase.Enabled = true;
            }
        }

        private void btnCaseCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validate()
        {
            if (txtCaseTitle.Text.Length == 0)
            {
                ssCaseMaster.Text = " Please enter a valid Title...";
                return (false);
            }

            if (cboCourtTypeId.SelectedIndex < 0)
            {
                ssCaseMaster.Text = " Please select a valid Court...";
                return (false);
            }
            if (cboCaseTypeId.SelectedIndex < 0)
            {
                ssCaseMaster.Text = " Please select a valid CaseType...";
                return (false);
            }
            if (cboCaseJudgeId.SelectedIndex < 0)
            {
                ssCaseMaster.Text = " Please select a valid Judge...";
                return (false);
            }
            return (true);
        }

        private bool ValidateParty()
        {
            if (txtName.Text.Length == 0)
            {
                ssCaseMaster.Text = " Please enter a valid Name...";
                return (false);
            }
            if (txtAddress.Text.Length == 0)
            {
                ssCaseMaster.Text = " Please enter a valid Address...";
                return (false);
            }
            if (txtCity.Text.Length == 0)
            {
                ssCaseMaster.Text = " Please enter a valid City...";
                return (false);
            }
            if (txtPin.Text.Length == 0)
            {
                ssCaseMaster.Text = " Please enter a valid Pin Code...";
                return (false);
            }
            if (txtPhone.Text.Length == 0)
            {
                ssCaseMaster.Text = " Please enter a valid Phone no...";
                return (false);
            }
            return (true);
        }

        private void frmCaseMaster_Load(object sender, EventArgs e)
        {
        }

        private void txtPlantiffPin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlantiffPhone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSaveCase_Click(object sender, EventArgs e)
        {
            if (localmode == eTranType.NEW)
            {
                bool Check = validate();
                if (Check == true)
                {
                    obj.Title = txtCaseTitle.Text;
                    obj.FileDate = DtCasesFileDate.Value;
                    obj.CourtId = Convert.ToInt32(cboCourtTypeId.SelectedValue);
                    obj.CaseTypeId = Convert.ToInt32(cboCaseTypeId.SelectedValue);
                    obj.JudgeId = Convert.ToInt32(cboCaseJudgeId.SelectedValue);
                    obj.Description = txtDescription.Text;
                    obj.SaveCase();
                    ssCaseMaster.Text = "New Case Added Successfully....";
                    txtCaseTitle.Clear();
                    txtDescription.Clear();
                }
            }
            else if (localmode == eTranType.Edit)
            {
                bool Check = validate();
                if (Check == true)
                {
                    obj.CaseId = CsId;
                    obj.Title = txtCaseTitle.Text;
                    obj.FileDate = DtCasesFileDate.Value;
                    obj.CourtId = Convert.ToInt32(cboCourtTypeId.SelectedValue);
                    obj.CaseTypeId = Convert.ToInt32(cboCaseTypeId.SelectedValue);
                    obj.JudgeId = Convert.ToInt32(cboCaseJudgeId.SelectedValue);
                    obj.Description = txtDescription.Text;
                    obj.UpdateCase();
                    ssCaseMaster.Text = "Updated...";
                    localmode = eTranType.NEW;

                    txtCaseTitle.Clear();
                    txtDescription.Clear();
                }

            }
        }

        private void btnEditPlaintiff_Click(object sender, EventArgs e)
        {
            if (dgvPlantiff.SelectedRows.Count > 0)
            {
                txtName.Text = dgvPlantiff.SelectedRows[0].Cells[0].Value.ToString();
                txtAddress.Text = dgvPlantiff.SelectedRows[0].Cells[1].Value.ToString();
                txtCity.Text = dgvPlantiff.SelectedRows[0].Cells[2].Value.ToString();
                txtPin.Text = dgvPlantiff.SelectedRows[0].Cells[3].Value.ToString();
                txtPhone.Text = dgvPlantiff.SelectedRows[0].Cells[4].Value.ToString();

                btnEditPlaintiff.Enabled = false;
                btnEditDefendent.Enabled = false;
                btnPlantiffReset.Text = "Cancel";
                btnAddPlantiff.Text = "Update";

                dgvPlantiff.Enabled = false;
                dgvDefendent.Enabled = false;
                btnSaveCase.Enabled = false;

                EntityType = 1;

            }

        }

        private void btnEditDefendent_Click(object sender, EventArgs e)
        {
            if (dgvDefendent.SelectedRows.Count > 0)
            {
                txtName.Text = dgvDefendent.SelectedRows[0].Cells[0].Value.ToString();
                txtAddress.Text = dgvDefendent.SelectedRows[0].Cells[1].Value.ToString();
                txtCity.Text = dgvDefendent.SelectedRows[0].Cells[2].Value.ToString();
                txtPin.Text = dgvDefendent.SelectedRows[0].Cells[3].Value.ToString();
                txtPhone.Text = dgvDefendent.SelectedRows[0].Cells[4].Value.ToString();

                btnEditPlaintiff.Enabled = false;
                btnEditDefendent.Enabled = false;
                btnPlantiffReset.Text = "Cancel";
                btnAddPlantiff.Text = "Update";

                dgvPlantiff.Enabled = false;
                dgvDefendent.Enabled = false;
                btnSaveCase.Enabled = false;

                EntityType = 2;

            }

        }



    }
}
