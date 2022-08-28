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
    public partial class personel_ekle : Form
    {
        public personel_ekle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void personel_ekle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from personel_bilgi", baglanti);
            DataSet ds1 = new DataSet();

            da1.Fill(ds1, "personel_bilgi");
            dataGridView1.DataSource = ds1.Tables["personel_bilgi"];
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

            if (((int)e.KeyChar >= 65 && (int)e.KeyChar <= 90) || (int)e.KeyChar == 08)
            {
                e.Handled = false;
            }

            else if (((int)e.KeyChar >= 97 && (int)e.KeyChar <= 122) || (int)e.KeyChar == 08)
            {
                e.Handled = false;
            }

            else if (((int)e.KeyChar >= 128) || (int)e.KeyChar == 08)
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
            comboBox1.SelectedIndex = 0;
            textBox5.Enabled = true;

            baglanti.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from personel_bilgi", baglanti);
            DataSet ds1 = new DataSet();

            da1.Fill(ds1, "personel_bilgi");
            dataGridView1.DataSource = ds1.Tables["personel_bilgi"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Girilebilir Alanlar Boş Geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                baglanti.Open();

                string bilgi_kayit = "insert into personel_bilgi(personel_tc, personel_adi, personel_soyadi, personel_tip, personel_sifre)" +
                    "values (@ptc, @padi, @psoyadi, @ptipi, @psifre)";

                SqlCommand komut = new SqlCommand(bilgi_kayit, baglanti);
                string secilen = comboBox1.SelectedItem.ToString();

                komut.Parameters.AddWithValue("@ptc", textBox1.Text);
                komut.Parameters.AddWithValue("@padi", textBox2.Text);
                komut.Parameters.AddWithValue("@psoyadi", textBox3.Text);
                komut.Parameters.AddWithValue("@ptipi", secilen);
                komut.Parameters.AddWithValue("@psifre", textBox5.Text);
                int sonuc1 = komut.ExecuteNonQuery();

                if (sonuc1 == 1)
                {
                    MessageBox.Show("İşlem Başarılı");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox5.Clear();
                    comboBox1.SelectedIndex = 0;
                    textBox5.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Opss, Bir Hata Oldu..");
                }

                SqlDataAdapter da1 = new SqlDataAdapter("select * from personel_bilgi", baglanti);
                DataSet ds1 = new DataSet();

                da1.Fill(ds1, "personel_bilgi");
                dataGridView1.DataSource = ds1.Tables["personel_bilgi"];
                baglanti.Close();

                baglanti.Close();
            }
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int sifre;

            sifre = random.Next(1000, 10000);
            textBox5.Text = sifre.ToString();

            textBox5.Enabled = false;
        }

    }
}
