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
    public partial class personel_duzenle : Form
    {
        public personel_duzenle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void personel_duzenle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from personel_bilgi", baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "personel_bilgi");
            dataGridView1.DataSource = ds.Tables["personel_bilgi"];
            baglanti.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from personel_bilgi where personel_tc like '" + textBox8.Text + "%' ", baglanti);

            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["personel_tc"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["personel_adi"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["personel_soyadi"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["personel_tip"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["personel_sifre"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update personel_bilgi set personel_adi='" + textBox2.Text + "', personel_soyadi='" + textBox3.Text + "', personel_tipi='" + textBox4.Text + "', personel_sifre='" + textBox5.Text + "' where personel_tc='" + textBox1.Text + "'", baglanti);
            komut1.ExecuteNonQuery();

            SqlDataAdapter da1 = new SqlDataAdapter("select * from personel_bilgi", baglanti);
            DataSet ds1 = new DataSet();

            da1.Fill(ds1, "personel_bilgi");
            dataGridView1.DataSource = ds1.Tables["personel_bilgi"];
            MessageBox.Show("Müşteri Düzeltme İşlemi Gerçekleşti.");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sno1;
            sno1 = dataGridView1.CurrentRow.Cells["personel_tc"].Value.ToString();
            baglanti.Open();


            DialogResult durum = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == durum)
            {
                string silmeSorgusu = "delete from personel_bilgi where personel_tc=" + sno1;

                SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);

                silKomutu.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi...");

                SqlDataAdapter da = new SqlDataAdapter("select * from personel_bilgi", baglanti);
                DataSet ds = new DataSet();

                da.Fill(ds, "personel_bilgi");
                dataGridView1.DataSource = ds.Tables["personel_bilgi"];
                baglanti.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
