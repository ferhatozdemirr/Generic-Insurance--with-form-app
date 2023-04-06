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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

   

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriListesiForm frm = new MusteriListesiForm();
            frm.ShowDialog();
        }

        private void yeniMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkleForm frm = new MusteriEkleForm();
            frm.ShowDialog();
        }

        private void yeniPoliçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPolicyAdd form = new FormPolicyAdd();
            form.ShowDialog();
            dataGridView1.DataSource = DataOperations<PolicyList>.GetData();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataOperations<PolicyList>.GetData();

        }

        private void poliçeTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPolicyGrid frm = new FormPolicyGrid();
            frm.ShowDialog();
        }
    }
}
