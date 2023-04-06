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
    public partial class MusteriEkleForm : Form
    {
        public int indexNumber = -1;
        public MusteriEkleForm()
        {
            InitializeComponent();
        }

        private void btn_MusteriEkle_Click(object sender, EventArgs e)
        {

            MusteriListesi musterinin = new MusteriListesi();
            musterinin.FullName = txtName.Text;
            musterinin.Debts = Convert.ToDecimal(txtKalanBakiye.Text);
            musterinin.Email = txtEmail.Text;
            musterinin.Phone = txtPhone.Text;
            musterinin.Address = rchBox.Text;

            if (indexNumber < 0)
            {
                DataOperations<MusteriListesi>.AddData(musterinin);

            } else
            {
                DataOperations<MusteriListesi>.EditData(indexNumber ,  musterinin);
                indexNumber = -1;

            }

            this.Close();

        }

        private void MusteriEkleForm_Load(object sender, EventArgs e)
        {

            if (indexNumber >= 0)
            {
                var duzenlenen = DataOperations<MusteriListesi>.GetDataWithIndex(indexNumber);
                txtName.Text = duzenlenen.FullName;
                txtEmail.Text = duzenlenen.Email;
                txtPhone.Text = duzenlenen.Phone;
                txtKalanBakiye.Text = duzenlenen.Debts.ToString();
                rchBox.Text = duzenlenen.Email;
            }
   
        }
    }
}
