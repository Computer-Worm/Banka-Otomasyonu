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
    public partial class musteri_ekle : Form
    {
        public musteri_ekle()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void musteri_ekle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("Select musteri_tc, musteri_adi, musteri_soyadi, musteri_tipi, hesap_no, musteri_sifre, musteri_mail, bakiye from musteri_bilgi", baglanti);
            DataSet ds1 = new DataSet();

            da1.Fill(ds1, "musteri_bilgi");
            dataGridView1.DataSource = ds1.Tables["musteri_bilgi"];
            baglanti.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 08) 
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("Yanlış Karakter Girdiniz, Lütfen Düzeltin...");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((int)e.KeyChar >= 65 && (int)e.KeyChar <= 90) || (int)e.KeyChar == 08 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }

            else if (((int)e.KeyChar >= 97 && (int)e.KeyChar <= 122) || (int)e.KeyChar == 08 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }

            else if (((int)e.KeyChar >= 128) || (int)e.KeyChar == 08 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("Yanlış Karakter Girdiniz, Lütfen Düzeltin...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.SelectedIndex = 0;
            textBox5.Enabled = true;
            textBox8.Enabled = true;

            baglanti.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("Select musteri_tc, musteri_adi, musteri_soyadi, musteri_tipi, hesap_no, musteri_sifre, musteri_mail, bakiye from musteri_bilgi", baglanti);
            DataSet ds1 = new DataSet();

            da1.Fill(ds1, "musteri_bilgi");
            dataGridView1.DataSource = ds1.Tables["musteri_bilgi"];
            baglanti.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" ||
                textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Girilebilir Alanlar Boş Geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                baglanti.Open();

                string bilgi_kayit = "insert into musteri_bilgi(musteri_tc, musteri_adi, musteri_soyadi, musteri_tipi, musteri_sifre, hesap_no, bakiye, musteri_mail)" +
                    "values (@mtc, @madi, @msoyadi, @mtipi, @hesap_no, @msifre, @bakiye, @mmail)";

                SqlCommand komut = new SqlCommand(bilgi_kayit, baglanti);
                string secilen = comboBox1.SelectedItem.ToString();

                komut.Parameters.AddWithValue("@mtc", textBox1.Text);
                komut.Parameters.AddWithValue("@madi", textBox2.Text);
                komut.Parameters.AddWithValue("@msoyadi", textBox3.Text);
                komut.Parameters.AddWithValue("@mtipi", secilen);
                komut.Parameters.AddWithValue("@hesap_no", textBox5.Text);
                komut.Parameters.AddWithValue("@msifre", textBox8.Text);
                komut.Parameters.AddWithValue("@bakiye", textBox6.Text);
                komut.Parameters.AddWithValue("@mmail", textBox7.Text);
                int sonuc1 = komut.ExecuteNonQuery();

                if (sonuc1 == 1)
                {
                    MessageBox.Show("İşlem Başarılı");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    comboBox1.SelectedIndex = 0;
                    textBox5.Enabled = true;
                    textBox8.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Opss, Bir Hata Oldu..");
                }

                SqlDataAdapter da1 = new SqlDataAdapter("Select musteri_tc, musteri_adi, musteri_soyadi, musteri_tipi, hesap_no, musteri_sifre, bakiye, musteri_mail from musteri_bilgi", baglanti);
                DataSet ds1 = new DataSet();

                da1.Fill(ds1, "musteri_bilgi");
                dataGridView1.DataSource = ds1.Tables["musteri_bilgi"];
                baglanti.Close();
            }
        }


        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int sifre;

            sifre = random.Next(1000, 10000);
            textBox8.Text = sifre.ToString();

            textBox8.Enabled = false;
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int hesap_no;

            hesap_no = random.Next(1000, 10000);
            textBox5.Text = hesap_no.ToString();

            textBox5.Enabled = false;
        }


    }
}
