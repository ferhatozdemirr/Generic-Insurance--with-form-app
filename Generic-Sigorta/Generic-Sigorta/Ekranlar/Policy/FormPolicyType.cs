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
    public partial class FormPolicyType : Form
    {
        public int index = -1;
        public FormPolicyType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PoliceType tip = new PoliceType();
            tip.Name = txtName.Text;
            if (index < 0)
                DataOperations<PoliceType>.AddData(tip);
            else
            {
                DataOperations<PoliceType>.EditData(index, tip);
                index = -1;
            }
              
   

            this.Close();   
        }

        private void FormPolicyType_Load(object sender, EventArgs e)
        {
            if (index < 0) return;
            
            var ab = DataOperations<PoliceType>.GetDataWithIndex(index);
            txtName.Text = ab.Name;

        }
    }
}
