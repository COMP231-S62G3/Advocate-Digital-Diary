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
    public partial class frmStatements : Form
    {
        public enum eTranType
        {
            NEW = 1,
            Edit = 2
        }

        eTranType localmode;
        int caseId;
        int HNO;

        public frmStatements()
        {
            InitializeComponent();
        }

        private void frmStatements_Load(object sender, EventArgs e)
        {

        }

        public void StartStatement(int value,int hno)
        {
            
            caseId = value;
            HNO = hno;
            this.ShowDialog();
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (txtStatement.Text.Length != 0 && txtWitness.Text.Length !=0)
                {
                    BllStatement obj = new BllStatement();
                    obj.Statement = txtStatement.Text;
                    obj.WitnessNo = Convert.ToInt32( txtWitness.Tag);
                    obj.HearingDateNo = HNO;
                    obj.SaveStatement();
                    ssLabel.Text = "Statement added successfully";

                    dataGridView1.DataSource = obj.GetWitnessStatements(Convert.ToInt32(txtWitness.Tag));
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;

                    txtStatement.Clear();
                    

                }
                else
                {
                    ssLabel.Text = "Please enter a valid Statement and Witness..";
                }
            
        }

        private void btnBrowseWitness_Click(object sender, EventArgs e)
        {
            FrmWitnessList obj= new FrmWitnessList();
            if (obj.StartWitness(caseId) == true)
            {
                txtWitness.Text = obj.WitnessName;
                txtWitness.Tag = obj.WitnessNo;

                BllStatement objBLL = new BllStatement();
                dataGridView1.DataSource = objBLL.GetWitnessStatements(Convert.ToInt32(txtWitness.Tag));
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;


            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                BllStatement obj = new BllStatement();
                obj.DeleteStatement(a);
                dataGridView1.DataSource = obj.GetWitnessStatements(Convert.ToInt32(txtWitness.Tag));
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close??" , "Close?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
