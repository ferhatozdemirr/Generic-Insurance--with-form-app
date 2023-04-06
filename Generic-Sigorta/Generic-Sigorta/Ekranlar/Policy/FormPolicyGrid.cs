using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Sigorta
{
    public partial class FormPolicyGrid : Form
    {
        public FormPolicyGrid()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FormPolicyType frm = new FormPolicyType();
            frm.ShowDialog();
            dataGridView1.DataSource = DataOperations<PoliceType>.GetData();
        }

        private void FormPolicyGrid_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataOperations<PoliceType>.GetData();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            DataOperations<PoliceType>.DeleteData(index);
            dataGridView1.DataSource = DataOperations<PoliceType>.GetData();
        }

        private void btn_Düzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;
            
            FormPolicyType frm = new FormPolicyType();
            
            frm.index =  dataGridView1.SelectedRows[0].Index;
            frm.ShowDialog();
            dataGridView1.DataSource = DataOperations<PoliceType>.GetData();
        }
    }
}
