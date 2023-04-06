namespace Generic_Sigorta
{
    partial class MusteriEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKalanBakiye = new System.Windows.Forms.TextBox();
            this.rchBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_MusteriEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(112, 52);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(243, 22);
            this.txtPhone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email Adresi";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kalan Bakiye";
            // 
            // txtKalanBakiye
            // 
            this.txtKalanBakiye.Location = new System.Drawing.Point(112, 130);
            this.txtKalanBakiye.Name = "txtKalanBakiye";
            this.txtKalanBakiye.Size = new System.Drawing.Size(243, 22);
            this.txtKalanBakiye.TabIndex = 1;
            // 
            // rchBox
            // 
            this.rchBox.Location = new System.Drawing.Point(441, 18);
            this.rchBox.Name = "rchBox";
            this.rchBox.Size = new System.Drawing.Size(227, 104);
            this.rchBox.TabIndex = 2;
            this.rchBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adres";
            // 
            // btn_MusteriEkle
            // 
            this.btn_MusteriEkle.Location = new System.Drawing.Point(441, 133);
            this.btn_MusteriEkle.Name = "btn_MusteriEkle";
            this.btn_MusteriEkle.Size = new System.Drawing.Size(227, 30);
            this.btn_MusteriEkle.TabIndex = 4;
            this.btn_MusteriEkle.Text = "Kaydet";
            this.btn_MusteriEkle.UseVisualStyleBackColor = true;
            this.btn_MusteriEkle.Click += new System.EventHandler(this.btn_MusteriEkle_Click);
            // 
            // MusteriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 172);
            this.Controls.Add(this.btn_MusteriEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rchBox);
            this.Controls.Add(this.txtKalanBakiye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "MusteriEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MusteriEkleForm";
            this.Load += new System.EventHandler(this.MusteriEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKalanBakiye;
        private System.Windows.Forms.RichTextBox rchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_MusteriEkle;
    }
}