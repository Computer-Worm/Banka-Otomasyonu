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
    public partial class bilgilerim : Form
    {
        public bilgilerim()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");
        string gelen_tc1 = musteri_giris.giden_tc1;

        private void bilgilerim_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            string bilgi = "select musteri_tc, musteri_adi, musteri_soyadi, musteri_tipi, musteri_sifre from musteri_bilgi where musteri_tc='" + gelen_tc1 + "'";
            SqlCommand komut = new SqlCommand(bilgi, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                textBox1.Text = oku["musteri_tc"].ToString();
                textBox2.Text = oku["musteri_adi"].ToString();
                textBox3.Text = oku["musteri_soyadi"].ToString();
                textBox4.Text = oku["musteri_tipi"].ToString();
                textBox5.Text = oku["musteri_sifre"].ToString();
            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update musteri_bilgi set  musteri_sifre='" + textBox5.Text + "' where musteri_tc='" + textBox1.Text + "'", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
