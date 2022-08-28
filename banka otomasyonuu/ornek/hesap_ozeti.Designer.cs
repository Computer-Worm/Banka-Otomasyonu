
namespace ornek
{
    partial class hesap_ozeti
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesap_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelen_para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giden_para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hesap Seç..";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 40);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesap_no,
            this.musteri_adi,
            this.musteri_soyadi,
            this.bakiye,
            this.gelen_para,
            this.giden_para,
            this.tarih});
            this.dataGridView1.Location = new System.Drawing.Point(326, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 219);
            this.dataGridView1.TabIndex = 6;
            // 
            // hesap_no
            // 
            this.hesap_no.DataPropertyName = "hesap_no";
            this.hesap_no.HeaderText = "Hesap Numarası";
            this.hesap_no.MinimumWidth = 6;
            this.hesap_no.Name = "hesap_no";
            this.hesap_no.Width = 125;
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
            // bakiye
            // 
            this.bakiye.DataPropertyName = "bakiye";
            this.bakiye.HeaderText = "Bakiye";
            this.bakiye.MinimumWidth = 6;
            this.bakiye.Name = "bakiye";
            this.bakiye.Width = 125;
            // 
            // gelen_para
            // 
            this.gelen_para.DataPropertyName = "gelen_para";
            this.gelen_para.HeaderText = "Gelen Para ";
            this.gelen_para.MinimumWidth = 6;
            this.gelen_para.Name = "gelen_para";
            this.gelen_para.Width = 125;
            // 
            // giden_para
            // 
            this.giden_para.DataPropertyName = "giden_para";
            this.giden_para.HeaderText = "Giden Para";
            this.giden_para.MinimumWidth = 6;
            this.giden_para.Name = "giden_para";
            this.giden_para.Width = 125;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.MinimumWidth = 6;
            this.tarih.Name = "tarih";
            this.tarih.Width = 125;
            // 
            // hesap_ozeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1273, 378);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hesap_ozeti";
            this.Text = "hesap_ozeti";
            this.Load += new System.EventHandler(this.hesap_ozeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesap_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelen_para;
        private System.Windows.Forms.DataGridViewTextBoxColumn giden_para;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
    }
}