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
    public partial class musteri_duzenle : Form
    {
        public musteri_duzenle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void musteri_duzenle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select musteri_tc, musteri_adi, musteri_soyadi, musteri_tipi, hesap_no, bakiye, musteri_mail from musteri_bilgi", baglanti);
            DataSet ds1 = new DataSet();

            da1.Fill(ds1, "musteri_bilgi");
            dataGridView1.DataSource = ds1.Tables["musteri_bilgi"];
            baglanti.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from musteri_bilgi where hesap_no like '" + textBox8.Text + "%' ", baglanti);

            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["musteri_tc"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["musteri_adi"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["musteri_soyadi"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["musteri_tipi"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["hesap_no"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["bakiye"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["musteri_mail"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteri_bilgi set  musteri_tc='" + textBox1.Text + "', musteri_adi='" + textBox2.Text + "', musteri_soyadi='" + textBox3.Text + "', bakiye='" + textBox6.Text + "', musteri_mail='" + textBox7.Text + "' where hesap_no='" + textBox5.Text +"'", baglanti);           
            komut.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter("select musteri_tc, musteri_adi, musteri_soyadi, musteri_tipi, hesap_no, bakiye, musteri_mail from musteri_bilgi", baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "musteri_bilgi");
            dataGridView1.DataSource = ds.Tables["musteri_bilgi"];
            MessageBox.Show("Müşteri Düzeltme İşlemi Gerçekleşti.");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sno1;
            sno1 = dataGridView1.CurrentRow.Cells["hesap_no"].Value.ToString();
            baglanti.Open();


            DialogResult durum = MessageBox.Show(" kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == durum)
            {
                string silmeSorgusu = "delete from musteri_bilgi where hesap_no=" + sno1;

                SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);

                silKomutu.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi...");

                SqlDataAdapter da = new SqlDataAdapter("select * from musteri_bilgi", baglanti);
                DataSet ds = new DataSet();

                da.Fill(ds, "musteri_bilgi");
                dataGridView1.DataSource = ds.Tables["musteri_bilgi"];
                baglanti.Close();

            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

    }
}
