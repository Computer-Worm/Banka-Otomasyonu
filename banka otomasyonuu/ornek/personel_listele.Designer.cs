
namespace ornek
{
    partial class personel_listele
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
            this.personel_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personel_tc,
            this.personel_adi,
            this.personel_soyadi,
            this.personel_tip,
            this.personel_sifre});
            this.dataGridView1.Location = new System.Drawing.Point(306, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 567);
            this.dataGridView1.TabIndex = 3;
            // 
            // personel_tc
            // 
            this.personel_tc.DataPropertyName = "personel_tc";
            this.personel_tc.HeaderText = "TC";
            this.personel_tc.MinimumWidth = 6;
            this.personel_tc.Name = "personel_tc";
            this.personel_tc.Width = 125;
            // 
            // personel_adi
            // 
            this.personel_adi.DataPropertyName = "personel_adi";
            this.personel_adi.HeaderText = "Adı";
            this.personel_adi.MinimumWidth = 6;
            this.personel_adi.Name = "personel_adi";
            this.personel_adi.Width = 125;
            // 
            // personel_soyadi
            // 
            this.personel_soyadi.DataPropertyName = "personel_soyadi";
            this.personel_soyadi.HeaderText = "Soyadı";
            this.personel_soyadi.MinimumWidth = 6;
            this.personel_soyadi.Name = "personel_soyadi";
            this.personel_soyadi.Width = 125;
            // 
            // personel_tip
            // 
            this.personel_tip.DataPropertyName = "personel_tip";
            this.personel_tip.HeaderText = "Müşteri Tipi";
            this.personel_tip.MinimumWidth = 6;
            this.personel_tip.Name = "personel_tip";
            this.personel_tip.Width = 125;
            // 
            // personel_sifre
            // 
            this.personel_sifre.DataPropertyName = "personel_sifre";
            this.personel_sifre.HeaderText = "Şifresi";
            this.personel_sifre.MinimumWidth = 6;
            this.personel_sifre.Name = "personel_sifre";
            this.personel_sifre.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arama..";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 40);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // personel_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1027, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "personel_listele";
            this.Text = "personel_listele";
            this.Load += new System.EventHandler(this.personel_listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_sifre;
    }
}