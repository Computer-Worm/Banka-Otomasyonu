
namespace ornek
{
    partial class musteri_listele
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hesap_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_tipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesap_no,
            this.bakiye,
            this.musteri_tc,
            this.musteri_adi,
            this.musteri_soyadi,
            this.musteri_tipi,
            this.musteri_mail,
            this.musteri_sifre});
            this.dataGridView1.Location = new System.Drawing.Point(306, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 567);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama..";
            // 
            // hesap_no
            // 
            this.hesap_no.DataPropertyName = "hesap_no";
            this.hesap_no.HeaderText = "Hesap Numarası";
            this.hesap_no.MinimumWidth = 6;
            this.hesap_no.Name = "hesap_no";
            this.hesap_no.Width = 125;
            // 
            // bakiye
            // 
            this.bakiye.DataPropertyName = "bakiye";
            this.bakiye.HeaderText = "Bakiye";
            this.bakiye.MinimumWidth = 6;
            this.bakiye.Name = "bakiye";
            this.bakiye.Width = 125;
            // 
            // musteri_tc
            // 
            this.musteri_tc.DataPropertyName = "musteri_tc";
            this.musteri_tc.HeaderText = "TC";
            this.musteri_tc.MinimumWidth = 6;
            this.musteri_tc.Name = "musteri_tc";
            this.musteri_tc.Width = 125;
            // 
            // musteri_adi
            // 
            this.musteri_adi.DataPropertyName = "musteri_adi";
            this.musteri_adi.HeaderText = "Adı";
            this.musteri_adi.MinimumWidth = 6;
            this.musteri_adi.Name = "musteri_adi";
            this.musteri_adi.Width = 125;
            // 
            // musteri_soyadi
            // 
            this.musteri_soyadi.DataPropertyName = "musteri_soyadi";
            this.musteri_soyadi.HeaderText = "Soyadı";
            this.musteri_soyadi.MinimumWidth = 6;
            this.musteri_soyadi.Name = "musteri_soyadi";
            this.musteri_soyadi.Width = 125;
            // 
            // musteri_tipi
            // 
            this.musteri_tipi.DataPropertyName = "musteri_tipi";
            this.musteri_tipi.HeaderText = "Müşteri Tipi";
            this.musteri_tipi.MinimumWidth = 6;
            this.musteri_tipi.Name = "musteri_tipi";
            this.musteri_tipi.Width = 125;
            // 
            // musteri_mail
            // 
            this.musteri_mail.DataPropertyName = "musteri_mail";
            this.musteri_mail.HeaderText = "Mail Adresi";
            this.musteri_mail.MinimumWidth = 6;
            this.musteri_mail.Name = "musteri_mail";
            this.musteri_mail.Width = 125;
            // 
            // musteri_sifre
            // 
            this.musteri_sifre.DataPropertyName = "musteri_sifre";
            this.musteri_sifre.HeaderText = "Şifresi";
            this.musteri_sifre.MinimumWidth = 6;
            this.musteri_sifre.Name = "musteri_sifre";
            this.musteri_sifre.Width = 125;
            // 
            // musteri_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1373, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "musteri_listele";
            this.Text = "musteri_listele";
            this.Load += new System.EventHandler(this.musteri_listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesap_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_tipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_sifre;
    }
}