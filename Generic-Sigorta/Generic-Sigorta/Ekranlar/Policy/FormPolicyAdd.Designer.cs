namespace Generic_Sigorta
{
    partial class FormPolicyAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtRemainingAmount = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.cmbPolicyType = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 271);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 32);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Bitiş Tarihi ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Başlangıç Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Kalan Rakam";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ödenen Rakam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Toplam Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Plaka Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Poliçe Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Müşteri";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(169, 239);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(300, 22);
            this.dtpEnd.TabIndex = 24;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(169, 207);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(300, 22);
            this.dtpStart.TabIndex = 23;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // txtRemainingAmount
            // 
            this.txtRemainingAmount.Location = new System.Drawing.Point(169, 175);
            this.txtRemainingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemainingAmount.Name = "txtRemainingAmount";
            this.txtRemainingAmount.Size = new System.Drawing.Size(300, 22);
            this.txtRemainingAmount.TabIndex = 22;
            this.txtRemainingAmount.Text = "0";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(169, 143);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(300, 22);
            this.txtPaidAmount.TabIndex = 21;
            this.txtPaidAmount.Text = "0";
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(169, 111);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(300, 22);
            this.txtTotalAmount.TabIndex = 20;
            this.txtTotalAmount.Text = "0";
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            // 
            // cmbPolicyType
            // 
            this.cmbPolicyType.FormattingEnabled = true;
            this.cmbPolicyType.Location = new System.Drawing.Point(169, 46);
            this.cmbPolicyType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPolicyType.Name = "cmbPolicyType";
            this.cmbPolicyType.Size = new System.Drawing.Size(300, 24);
            this.cmbPolicyType.TabIndex = 19;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(169, 13);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(300, 24);
            this.cmbCustomer.TabIndex = 18;
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(169, 79);
            this.txtPlate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(300, 22);
            this.txtPlate.TabIndex = 17;
            // 
            // FormPolicyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 308);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtRemainingAmount);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.cmbPolicyType);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.txtPlate);
            this.Name = "FormPolicyAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPolicyAdd";
            this.Load += new System.EventHandler(this.FormPolicyAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox txtRemainingAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.ComboBox cmbPolicyType;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TextBox txtPlate;
    }
}