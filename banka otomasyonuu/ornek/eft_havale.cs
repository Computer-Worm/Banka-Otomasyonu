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
    public partial class eft_havale : Form
    {
        public eft_havale()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");
        string gelen_tc3 = musteri_giris.giden_tc3;

        private void eft_havale_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            string bilgi = "select hesap_no from hesap_ozeti where musteri_tc='" + gelen_tc3 + "'";
            SqlCommand komut = new SqlCommand(bilgi, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            comboBox1.Items.Add("Seçiminiz..");
            //comboBox1.SelectedIndex = 0;

            while (oku.Read())
            {
                comboBox1.Items.Add(oku["hesap_no"]);
            }
            oku.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            int kontrol, total1, total2, gonderilen, sonuc1, sonuc2, gelen_para, giden_para, mevcut_para, net_para;

            string bilgi1 = "select musteri_adi, musteri_soyadi, hesap_no, bakiye from hesap_ozeti where musteri_tc='" + gelen_tc3 + "'";
            SqlCommand komut1 = new SqlCommand(bilgi1, baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();


            if (oku1.Read())
            {
                kontrol = Convert.ToInt32(oku1["bakiye"]);

                if (kontrol >= 0)
                {
                    if (textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedIndex == 0)
                    {
                        MessageBox.Show("Girilebilir Alanlar Boş Geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {   
                        oku1.Close();
                        string blg = "select bakiye from hesap_ozeti where hesap_no='" + comboBox1.SelectedItem.ToString() + "'";
                        SqlCommand kmt = new SqlCommand(blg, baglanti);
                        SqlDataReader rd = kmt.ExecuteReader();
                        

                        if (rd.Read())
                        {
                            gonderilen = Convert.ToInt32(textBox2.Text);
                            rd.Close();

                            string bilgi2 = "select bakiye, gelen_para, giden_para from hesap_ozeti where hesap_no='" + textBox3.Text + "'";
                            SqlCommand komut2 = new SqlCommand(bilgi2, baglanti);
                            SqlDataReader oku2 = komut2.ExecuteReader();

                            if (oku2.Read())
                            {
                                total2 = Convert.ToInt32(oku2["bakiye"]);
                                gelen_para = Convert.ToInt32(oku2["gelen_para"]);
                                sonuc2 = total2 + gonderilen;
                                oku2.Close();
                                gelen_para += gonderilen;

                                string rapor1 = "select top 1 * from banka_rapor order by tarih desc";
                                SqlCommand comd1 = new SqlCommand(rapor1, baglanti);
                                SqlDataReader reader1 = comd1.ExecuteReader();

                                if (reader1.Read())
                                {
                                    mevcut_para = Convert.ToInt32(reader1["net_para"]);
                                    net_para = mevcut_para + gonderilen;
                                    reader1.Close();


                                    string bilgi_kayit = "insert into banka_rapor(mevcut_para, toplam_gelen_para, toplam_giden_para, net_para)" +
                                                             "values (@mevcut_para, @toplam_gelen_para, @toplam_giden_para, @net_para)";

                                    SqlCommand komut = new SqlCommand(bilgi_kayit, baglanti);

                                    komut.Parameters.AddWithValue("@mevcut_para", mevcut_para.ToString());
                                    komut.Parameters.AddWithValue("@toplam_gelen_para", gonderilen.ToString());
                                    komut.Parameters.AddWithValue("@toplam_giden_para", 0);
                                    komut.Parameters.AddWithValue("@net_para", net_para);
                                    komut.ExecuteNonQuery();
                                    reader1.Close();
                                }

                                baglanti.Close();
                                baglanti.Open();
                                SqlCommand info1 = new SqlCommand("update hesap_ozeti set  bakiye='" + sonuc2 + "', gelen_para='" + gelen_para + "' where hesap_no='" + textBox3.Text + "'", baglanti);
                                info1.ExecuteNonQuery();
                            }

                            baglanti.Close();
                            baglanti.Open();
                            string bilgi3 = "select bakiye, gelen_para, giden_para from hesap_ozeti where hesap_no='" + comboBox1.SelectedItem.ToString() + "'";
                            SqlCommand komut3 = new SqlCommand(bilgi3, baglanti);
                            SqlDataReader oku3 = komut3.ExecuteReader();

                            if (oku3.Read())
                            {
                                total1 = Convert.ToInt32(oku3["bakiye"]);
                                giden_para = Convert.ToInt32(oku3["giden_para"]);
                                sonuc1 = total1 - gonderilen;
                                oku3.Close();
                                giden_para -= gonderilen;

                                string rapor2 = "select top 1 * from banka_rapor order by tarih desc";
                                SqlCommand comd2 = new SqlCommand(rapor2, baglanti);
                                SqlDataReader reader2 = comd2.ExecuteReader();

                                if (reader2.Read())
                                {
                                    mevcut_para = Convert.ToInt32(reader2["net_para"]);
                                    net_para = mevcut_para - gonderilen;
                                    reader2.Close();


                                    string bilgi_kayit = "insert into banka_rapor(mevcut_para, toplam_gelen_para, toplam_giden_para, net_para)" +
                                                             "values (@mevcut_para, @toplam_gelen_para, @toplam_giden_para, @net_para)";

                                    SqlCommand komut = new SqlCommand(bilgi_kayit, baglanti);

                                    komut.Parameters.AddWithValue("@mevcut_para", mevcut_para.ToString());
                                    komut.Parameters.AddWithValue("@toplam_gelen_para", 0);
                                    komut.Parameters.AddWithValue("@toplam_giden_para", gonderilen.ToString());
                                    komut.Parameters.AddWithValue("@net_para", net_para);
                                    komut.ExecuteNonQuery();
                                }

                                baglanti.Close();
                                baglanti.Open();
                                SqlCommand info2 = new SqlCommand("update hesap_ozeti set  bakiye='" + sonuc1 + "', giden_para='" + giden_para + "' where hesap_no='" + comboBox1.SelectedItem.ToString() + "'", baglanti);
                                info2.ExecuteNonQuery();
                            }


                            label7.Text = "Durum : Para Transfer İşlemi Başarılı";

                            //comboBox1.SelectedIndex = 0;
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox4.Enabled = true;
                        }
                        
                    }
                }

            }            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //baglanti.Open();
            string info = "select bakiye, musteri_adi, musteri_soyadi from hesap_ozeti where hesap_no='" + comboBox1.SelectedItem.ToString() + "'";
            SqlCommand sql = new SqlCommand(info, baglanti);
            SqlDataReader reader = sql.ExecuteReader();

            if (reader.Read())
            {
                textBox5.Text = reader["bakiye"].ToString();
                textBox1.Text = reader["musteri_adi"].ToString() + " " + reader["musteri_soyadi"].ToString();
            }
            //reader.Close();
            //baglanti.Close();
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Enabled = false;

            baglanti.Close();
            baglanti.Open();
            string info = "select musteri_adi, musteri_soyadi from hesap_ozeti where hesap_no='" + textBox3.Text + "'";
            SqlCommand sql = new SqlCommand(info, baglanti);
            SqlDataReader rdr = sql.ExecuteReader();

            if (rdr.Read())
            {
                textBox4.Text = rdr["musteri_adi"].ToString() + " " + rdr["musteri_soyadi"].ToString();
            }
            //rdr.Close();

        }
 
    }
}
