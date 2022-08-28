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
    public partial class hesap_ekle : Form
    {
        public hesap_ekle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");
        string gelen_tc2 = musteri_giris.giden_tc2;

        private void hesap_ekle_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            string bilgi = "select musteri_tc, musteri_adi, musteri_soyadi, musteri_tipi, hesap_no from musteri_bilgi where musteri_tc='" + gelen_tc2 + "'";
            SqlCommand komut = new SqlCommand(bilgi, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                textBox1.Text = oku["musteri_tc"].ToString();
                textBox2.Text = oku["musteri_adi"].ToString();
                textBox3.Text = oku["musteri_soyadi"].ToString();
                textBox4.Text = oku["musteri_tipi"].ToString();
            }
            

            Random random = new Random();
            int sifre;

            sifre = random.Next(1000, 10000);
            textBox5.Text = sifre.ToString();

            textBox6.Text = "2000";

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

            oku.Close();

            int pass = random.Next(1000, 10000);
            textBox5.Text = sifre.ToString();
            textBox5.Enabled = false;

            SqlDataAdapter da2 = new SqlDataAdapter("Select hesap_no, bakiye, musteri_adi, musteri_soyadi, musteri_tipi from hesap_ozeti where musteri_tc='" + textBox1.Text + "'", baglanti);
            DataSet ds2 = new DataSet();

            da2.Fill(ds2, "hesap_ozeti");
            dataGridView1.DataSource = ds2.Tables["hesap_ozeti"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string bilgi_kayit = "insert into hesap_ozeti(musteri_tc, musteri_adi, musteri_soyadi, musteri_tipi, hesap_no, bakiye, gelen_para, giden_para)" +
                "values (@mtc, @madi, @msoyadi, @mtipi, @hesap_no, @bakiye, @gelen_para, @giden_para)";

            SqlCommand komut = new SqlCommand(bilgi_kayit, baglanti);

            komut.Parameters.AddWithValue("@mtc", textBox1.Text);
            komut.Parameters.AddWithValue("@madi", textBox2.Text);
            komut.Parameters.AddWithValue("@msoyadi", textBox3.Text);
            komut.Parameters.AddWithValue("@mtipi", textBox4.Text);
            komut.Parameters.AddWithValue("@hesap_no", textBox5.Text);
            komut.Parameters.AddWithValue("@bakiye", textBox6.Text);
            komut.Parameters.AddWithValue("@gelen_para", 0);
            komut.Parameters.AddWithValue("@giden_para", 0);
            int sonuc1 = komut.ExecuteNonQuery();

            if (sonuc1 == 1)
            {
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Opss, Bir Hata Oldu..");
            }

            SqlDataAdapter da1 = new SqlDataAdapter("Select hesap_no, bakiye, musteri_adi, musteri_soyadi, musteri_tipi from hesap_ozeti where musteri_tc='" + textBox1.Text + "'", baglanti);
            DataSet ds1 = new DataSet();

            da1.Fill(ds1, "musteri_bilgi");
            dataGridView1.DataSource = ds1.Tables["musteri_bilgi"];
            baglanti.Close();
        }

    }
}
