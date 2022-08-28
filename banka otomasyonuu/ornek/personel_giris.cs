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
    public partial class personel_giris : Form
    {
        public personel_giris()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }

        public static string per_tc;
        SqlConnection baglan = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void personel_giris_Load(object sender, EventArgs e)
        {
            personel_panel cek = new personel_panel();
        }

        private void giris_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "select * from personel_bilgi where personel_tc = @tc and personel_sifre = @sifre";

            SqlCommand comd = new SqlCommand(sorgu, baglan);
            comd.Parameters.AddWithValue("@tc", textBox1.Text);
            comd.Parameters.AddWithValue("@sifre", textBox2.Text);
            SqlDataReader readd = comd.ExecuteReader();

            per_tc = textBox1.Text.ToString();

            if (readd.Read())
            {
                personel_panel geri = new personel_panel();
                geri.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Giriş, Tekrar Deneyiniz...");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            giris_ekrani geri = new giris_ekrani();
            geri.Show();
            Hide();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string tc = textBox1.Text;
                string sifre = textBox2.Text;

                baglan.Open();
                string sorgu = "select * from personel_bilgi where personel_tc = @ptc and personel_sifre = @psifre";

                SqlCommand command = new SqlCommand(sorgu, baglan);
                command.Parameters.AddWithValue("@ptc", textBox1.Text);
                command.Parameters.AddWithValue("@psifre", textBox2.Text);              
                SqlDataReader read = command.ExecuteReader();

                per_tc = textBox1.Text.ToString();

                if (read.Read())
                {
                    personel_panel geri = new personel_panel();
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
