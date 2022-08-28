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
    public partial class musteri_giris : Form
    {
        public musteri_giris()
        {
            InitializeComponent();
        }

        public static string giden_tc1;
        public static string giden_tc2;
        public static string giden_tc3;
        public static string giden_tc4;
        public static string giden_tc5;
        SqlConnection baglan = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void musteri_giris_Load(object sender, EventArgs e)
        {
            bilgilerim cek = new bilgilerim();
            hesap_ekle gonder = new hesap_ekle();
            hesap_sil git = new hesap_sil();
            eft_havale git1 = new eft_havale();
            musteri_listele git2 = new musteri_listele();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "select * from musteri_bilgi where musteri_tc = @tc and musteri_sifre = @sifre";

            SqlCommand comd = new SqlCommand(sorgu, baglan);
            comd.Parameters.AddWithValue("@tc", textBox1.Text);
            comd.Parameters.AddWithValue("@sifre", textBox2.Text);
            SqlDataReader readd = comd.ExecuteReader();

            giden_tc1 = textBox1.Text.ToString();
            giden_tc2 = textBox1.Text.ToString();
            giden_tc3 = textBox1.Text.ToString();
            giden_tc4 = textBox1.Text.ToString();
            giden_tc5 = textBox1.Text.ToString();

            if (readd.Read())
            {
                musteri_panel geri = new musteri_panel();
                geri.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Giriş, Tekrar Deneyiniz...");
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            giris_ekrani geri = new giris_ekrani();
            geri.Show();
            Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremi_unuttum geri = new sifremi_unuttum();
            geri.Show();
            Hide();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string tc = textBox1.Text;
                string sifre = textBox2.Text;

                baglan.Open();
                string sorgu = "select * from musteri_bilgi where musteri_tc = @mtc and musteri_sifre = @msifre";

                SqlCommand command = new SqlCommand(sorgu, baglan);
                command.Parameters.AddWithValue("@mtc", textBox1.Text);
                command.Parameters.AddWithValue("@msifre", textBox2.Text);
                SqlDataReader read = command.ExecuteReader();

                giden_tc1 = textBox1.Text.ToString();
                giden_tc2 = textBox1.Text.ToString();
                giden_tc3 = textBox1.Text.ToString();
                giden_tc4 = textBox1.Text.ToString();
                giden_tc5 = textBox1.Text.ToString();

                if (read.Read())
                {
                    musteri_panel geri = new musteri_panel();
                    geri.Show();
                    Hide();
                }

                else
                {
                    MessageBox.Show("Hatalı Giriş, Tekrar Deneyiniz...");
                }

                baglan.Close();
            }
        }
    }
}
