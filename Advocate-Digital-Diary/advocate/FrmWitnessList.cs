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
    public partial class FrmWitnessList : Form
    {
        public int WitnessNo;
        public string WitnessName;

        bool a;

        public FrmWitnessList()
        {
            InitializeComponent();
        }

        public bool StartWitness(int value)
        {

            BllWitness obj = new BllWitness();
            dataGridView1.DataSource = obj.GetWitnesses(value);
            dataGridView1.Columns[0].Visible = false;

            this.ShowDialog();
            return (a);
        }

        private void FrmWitnessList_Load(object sender, EventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                WitnessNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                WitnessName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                a = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            WitnessNo = 0;
            WitnessName = "";
            a = false;
            this.Close();
        }
    }
}
