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
    public partial class personel_panel : Form
    {
        public personel_panel()
        {
            InitializeComponent();
            
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");
        string per_tc = personel_giris.per_tc;

        private void personel_panel_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            string bilgi = "select personel_tip from personel_bilgi where personel_tc ='" + per_tc + "'";
            SqlCommand komut = new SqlCommand(bilgi, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                if ("CEO" != oku["personel_tip"].ToString() || "Yönetici" == oku["personel_tip"].ToString())
                {
                    pictureBox4.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox8.Enabled = false;
                    label9.Enabled = false;
                    label11.Enabled = false;
                    label15.Enabled = false;
                }

                else
                {
                    pictureBox4.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox8.Enabled = true;
                    label9.Enabled = true;
                    label11.Enabled = true;
                    label15.Enabled = true;
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            musteri_ekle ekle = new musteri_ekle();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            giris_ekrani gec = new giris_ekrani();
            gec.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            musteri_listele ekle = new musteri_listele();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            musteri_duzenle ekle = new musteri_duzenle();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            personel_ekle ekle = new personel_ekle();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            personel_duzenle ekle = new personel_duzenle();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            personel_listele ekle = new personel_listele();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            banka_raporu ekle = new banka_raporu();
            ekle.TopLevel = false;
            panel2.Controls.Add(ekle);
            ekle.Show();
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }


    }
}
