using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ornek
{
    public partial class musteri_panel : Form
    {
        public musteri_panel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            bilgilerim ekle = new bilgilerim();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hesap_ekle ekle = new hesap_ekle();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hesap_sil ekle = new hesap_sil();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            giris_ekrani aktar = new giris_ekrani();
            aktar.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            eft_havale ekle = new eft_havale();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hesap_ozeti ekle = new hesap_ozeti();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }
    }
}
