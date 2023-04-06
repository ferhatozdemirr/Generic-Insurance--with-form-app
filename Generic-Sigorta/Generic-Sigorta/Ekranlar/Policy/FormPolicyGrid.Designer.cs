namespace Generic_Sigorta
{
    partial class FormPolicyGrid
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Düzenle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1, 390);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(101, 55);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Çıkış";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(699, 390);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(101, 55);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Düzenle
            // 
            this.btn_Düzenle.Location = new System.Drawing.Point(577, 390);
            this.btn_Düzenle.Name = "btn_Düzenle";
            this.btn_Düzenle.Size = new System.Drawing.Size(101, 55);
            this.btn_Düzenle.TabIndex = 1;
            this.btn_Düzenle.Text = "Düzenle";
            this.btn_Düzenle.UseVisualStyleBackColor = true;
            this.btn_Düzenle.Click += new System.EventHandler(this.btn_Düzenle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(447, 390);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(101, 55);
            this.btn_Sil.TabIndex = 1;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // FormPolicyGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Düzenle);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPolicyGrid";
            this.Text = "FormPolicyGrid";
            this.Load += new System.EventHandler(this.FormPolicyGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Düzenle;
        private System.Windows.Forms.Button btn_Sil;
    }
}