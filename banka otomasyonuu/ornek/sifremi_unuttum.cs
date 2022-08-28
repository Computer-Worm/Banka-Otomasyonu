using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;

namespace ornek
{
    public partial class sifremi_unuttum : Form
    {
        public sifremi_unuttum()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-5N8L4II; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kom = new SqlCommand("select * from musteri_bilgi where musteri_tc='" + textBox1.Text.ToString() + "' and musteri_mail='" + textBox2.Text.ToString() + "'", baglanti);
            SqlDataReader oku = kom.ExecuteReader();

            if (oku.Read())
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    Random rnd = new Random();
                    int sifre_sifirla = rnd.Next(1000, 9999);

                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage message = new MailMessage();
                    String mailadre = ("ootomasyon09@gmail.com");
                    String sifre = ("otomasyon6565");
                    String smtpsrvr = "smtp.gmail.com";
                    String kime = (oku["musteri_mail"].ToString());
                    String password = sifre_sifirla.ToString();
                    String konu = ("Şifre Sıfırlama İsteği ");
                    String yaz = ("Merhaba Sayın" + oku["musteri_adi"].ToString() + " " + oku["musteri_soyadi"] +", Az Önce Şifre Sıfırlama İsteğinde Bulundunuz. \n Yeni Parolanız '" + password + "' Yeni Şifrenizi Kimseyle Paylaşmayın \n İyi Günler | La Capella Bank");
                    smtpserver.Credentials = new NetworkCredential(mailadre, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    message.From = new MailAddress(mailadre);
                    message.To.Add(kime);
                    message.Subject = konu;
                    message.Body = yaz;
                    smtpserver.Send(message);
                    label3.Visible = true;
                    oku.Close();

                    SqlCommand komut = new SqlCommand("update musteri_bilgi set  musteri_sifre='" + password + "' where musteri_tc='" + textBox1.Text + "'", baglanti);
                    komut.ExecuteNonQuery();


                }
                catch (Exception Hata)
                {
                    MessageBox.Show("mail gönderme hatası " + Hata + "");
                }

            }
            baglanti.Close();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            musteri_giris geri = new musteri_giris();
            geri.Show();
            Hide();
        }
    }

}
