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
    public partial class MusteriListesiForm : Form
    {
        public MusteriListesiForm()
        {
            InitializeComponent();
        }

        private void btn_mstrKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkleForm form = new MusteriEkleForm();
            form.ShowDialog();
            dataGridView1.DataSource = DataOperations<MusteriListesi>.GetData();
        }

        private void MusteriListesiForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataOperations<MusteriListesi>.GetData();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;
    
           int index = dataGridView1.SelectedRows[0].Index;
           DataOperations<MusteriListesi>.DeleteData(index);
           dataGridView1.DataSource = DataOperations<MusteriListesi>.GetData();
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;

            int index = dataGridView1.SelectedRows[0].Index;
            MusteriEkleForm frm = new MusteriEkleForm();
            frm.indexNumber = index;
            frm.ShowDialog();
            dataGridView1.DataSource = DataOperations<MusteriListesi>.GetData();

        }
    }
}
