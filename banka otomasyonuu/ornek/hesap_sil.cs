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
    public partial class hesap_sil : Form
    {
        public hesap_sil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");
        string gelen_tc3 = musteri_giris.giden_tc3;

        private void hesap_sil_Load(object sender, EventArgs e)
        {
            baglanti.Open();;

            SqlDataAdapter da = new SqlDataAdapter("Select hesap_no, bakiye, musteri_tc, musteri_adi, musteri_soyadi, musteri_tipi from hesap_ozeti where musteri_tc='" + gelen_tc3 + "'", baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "hesap_ozeti");
            dataGridView1.DataSource = ds.Tables["hesap_ozeti"];
            baglanti.Close();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["musteri_tc"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["musteri_adi"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["musteri_soyadi"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["musteri_tipi"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["hesap_no"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["bakiye"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sno, sorgu;
            sno = dataGridView1.CurrentRow.Cells["hesap_no"].Value.ToString();
            sorgu = dataGridView1.CurrentRow.Cells["bakiye"].Value.ToString();
            int denetle = Convert.ToInt32(sorgu);
            baglanti.Open();


            DialogResult durum = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (denetle >= 0)
            {
                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from hesap_ozeti where hesap_no=" + sno;

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);

                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");

                    SqlDataAdapter da = new SqlDataAdapter("Select * From hesap_ozeti where musteri_tc='" + gelen_tc3 + "'", baglanti);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "hesap_ozeti");
                    dataGridView1.DataSource = ds.Tables["hesap_ozeti"];
                    baglanti.Close();

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
            }

            else
            {
                MessageBox.Show("Bu işlem gerçekleşemedi...");
            }

        }
    }
}
