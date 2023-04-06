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
    public partial class FormPolicyAdd : Form
    {
        public FormPolicyAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PolicyList policy = new PolicyList();
            policy.PolicyTypeName = cmbPolicyType.SelectedItem.ToString();
            policy.CreateDate = dtpStart.Value;
            policy.PlateNumber = txtPlate.Text;
            policy.CustomerName = cmbCustomer.SelectedItem.ToString();
            policy.EndDate = dtpEnd.Value;
            policy.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            policy.PaidAmount = Convert.ToDecimal(txtPaidAmount.Text);
            policy.RemainingAmount = Convert.ToDecimal(txtRemainingAmount.Text);

            DataOperations<PolicyList>.AddData(policy);

            this.Close();
        }

        private void FormPolicyAdd_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            var customerList = DataOperations<MusteriListesi>.GetData();
            for (int i = 0; i < customerList.Count; i++)
            {
                cmbCustomer.Items.Add(customerList[i].FullName);
            }

            var policyTypeList = DataOperations<PoliceType>.GetData();
            for (int i = 0; i < policyTypeList.Count; i++)
            {
                cmbPolicyType.Items.Add(policyTypeList[i].Name);
            }

            txtRemainingAmount.Enabled = false;
            dtpEnd.Enabled = false;

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpStart.Value.AddYears(1);

        }

        void Calc()
        {

            try
            {
                var ta = Convert.ToDecimal(txtTotalAmount.Text);
                var pa = Convert.ToDecimal(txtPaidAmount.Text);
                txtRemainingAmount.Text = (ta - pa).ToString();
                btnSave.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli bir Rakam Giriniz");
                btnSave.Enabled = false;
            }
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtRemainingAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPlate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbPolicyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPlate_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbPolicyType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void txtRemainingAmount_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void dtpEnd_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
