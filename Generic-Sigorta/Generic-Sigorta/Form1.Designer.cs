namespace Generic_Sigorta
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.poliçeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliçeTürleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniPoliçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliçeİşlemleriToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // poliçeİşlemleriToolStripMenuItem
            // 
            this.poliçeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliçeTürleriToolStripMenuItem,
            this.yeniPoliçeToolStripMenuItem});
            this.poliçeİşlemleriToolStripMenuItem.Name = "poliçeİşlemleriToolStripMenuItem";
            this.poliçeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.poliçeİşlemleriToolStripMenuItem.Text = "Poliçe İşlemleri";
            // 
            // poliçeTürleriToolStripMenuItem
            // 
            this.poliçeTürleriToolStripMenuItem.Name = "poliçeTürleriToolStripMenuItem";
            this.poliçeTürleriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.poliçeTürleriToolStripMenuItem.Text = "Poliçe Türleri";
            this.poliçeTürleriToolStripMenuItem.Click += new System.EventHandler(this.poliçeTürleriToolStripMenuItem_Click);
            // 
            // yeniPoliçeToolStripMenuItem
            // 
            this.yeniPoliçeToolStripMenuItem.Name = "yeniPoliçeToolStripMenuItem";
            this.yeniPoliçeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yeniPoliçeToolStripMenuItem.Text = "Yeni Poliçe";
            this.yeniPoliçeToolStripMenuItem.Click += new System.EventHandler(this.yeniPoliçeToolStripMenuItem_Click);
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriToolStripMenuItem,
            this.müşteriListesiToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // yeniMüşteriToolStripMenuItem
            // 
            this.yeniMüşteriToolStripMenuItem.Name = "yeniMüşteriToolStripMenuItem";
            this.yeniMüşteriToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.yeniMüşteriToolStripMenuItem.Text = "Yeni Müşteri";
            this.yeniMüşteriToolStripMenuItem.Click += new System.EventHandler(this.yeniMüşteriToolStripMenuItem_Click);
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 413);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem poliçeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliçeTürleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniPoliçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

