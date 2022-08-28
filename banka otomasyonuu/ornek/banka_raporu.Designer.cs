
namespace ornek
{
    partial class banka_raporu
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
            this.label1 = new System.Windows.Forms.Label();
            this.mevcut_para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_gelen_para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_giden_para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mevcut_para,
            this.toplam_gelen_para,
            this.toplam_giden_para,
            this.net_para,
            this.tarih});
            this.dataGridView1.Location = new System.Drawing.Point(18, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 370);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "Genel Banka Raporu";
            // 
            // mevcut_para
            // 
            this.mevcut_para.DataPropertyName = "mevcut_para";
            this.mevcut_para.HeaderText = "Mevcut Bankadaki Para";
            this.mevcut_para.MinimumWidth = 6;
            this.mevcut_para.Name = "mevcut_para";
            this.mevcut_para.Width = 125;
            // 
            // toplam_gelen_para
            // 
            this.toplam_gelen_para.DataPropertyName = "toplam_gelen_para";
            this.toplam_gelen_para.HeaderText = "Total Gönderilen Para";
            this.toplam_gelen_para.MinimumWidth = 6;
            this.toplam_gelen_para.Name = "toplam_gelen_para";
            this.toplam_gelen_para.Width = 125;
            // 
            // toplam_giden_para
            // 
            this.toplam_giden_para.DataPropertyName = "toplam_giden_para";
            this.toplam_giden_para.HeaderText = "Total Giden Para";
            this.toplam_giden_para.MinimumWidth = 6;
            this.toplam_giden_para.Name = "toplam_giden_para";
            this.toplam_giden_para.Width = 125;
            // 
            // net_para
            // 
            this.net_para.DataPropertyName = "net_para";
            this.net_para.HeaderText = "Net Banka Kârı";
            this.net_para.MinimumWidth = 6;
            this.net_para.Name = "net_para";
            this.net_para.Width = 125;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.MinimumWidth = 6;
            this.tarih.Name = "tarih";
            this.tarih.Width = 125;
            // 
            // banka_raporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(918, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "banka_raporu";
            this.Text = "banka_raporu";
            this.Load += new System.EventHandler(this.banka_raporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mevcut_para;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_gelen_para;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_giden_para;
        private System.Windows.Forms.DataGridViewTextBoxColumn net_para;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
    }
}