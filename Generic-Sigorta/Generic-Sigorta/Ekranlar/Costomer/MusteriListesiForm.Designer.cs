namespace Generic_Sigorta
{
    partial class MusteriListesiForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_MusteriEkle = new System.Windows.Forms.Button();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_mstrKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_MusteriEkle
            // 
            this.btn_MusteriEkle.Location = new System.Drawing.Point(663, 388);
            this.btn_MusteriEkle.Name = "btn_MusteriEkle";
            this.btn_MusteriEkle.Size = new System.Drawing.Size(125, 56);
            this.btn_MusteriEkle.TabIndex = 1;
            this.btn_MusteriEkle.Text = "Ekle";
            this.btn_MusteriEkle.UseVisualStyleBackColor = true;
            this.btn_MusteriEkle.Click += new System.EventHandler(this.btn_MusteriEkle_Click);
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Location = new System.Drawing.Point(522, 388);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(125, 56);
            this.btn_Duzenle.TabIndex = 1;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(368, 388);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(125, 56);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_mstrKapat
            // 
            this.btn_mstrKapat.Location = new System.Drawing.Point(0, 388);
            this.btn_mstrKapat.Name = "btn_mstrKapat";
            this.btn_mstrKapat.Size = new System.Drawing.Size(125, 56);
            this.btn_mstrKapat.TabIndex = 1;
            this.btn_mstrKapat.Text = "Çıkış";
            this.btn_mstrKapat.UseVisualStyleBackColor = true;
            this.btn_mstrKapat.Click += new System.EventHandler(this.btn_mstrKapat_Click);
            // 
            // MusteriListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.btn_mstrKapat);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.btn_MusteriEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MusteriListesiForm";
            this.Text = "MusteriListesiForm";
            this.Load += new System.EventHandler(this.MusteriListesiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_MusteriEkle;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_mstrKapat;
    }
}