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
    public partial class hesap_ozeti : Form
    {
        public hesap_ozeti()
        {
            InitializeComponent();
        }

        string gelen_tc5 = musteri_giris.giden_tc5;
        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void hesap_ozeti_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            string blg = "select hesap_no from hesap_ozeti where musteri_tc='" + gelen_tc5 + "'";
            SqlCommand kmt = new SqlCommand(blg, baglanti);
            SqlDataReader rd = kmt.ExecuteReader();

            while (rd.Read())
            {
                comboBox1.Items.Add(rd["hesap_no"]);
            }

            baglanti.Close();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select hesap_no, musteri_adi, musteri_soyadi, bakiye, gelen_para, giden_para, tarih From hesap_ozeti where hesap_no='" + comboBox1.SelectedItem.ToString() + "'", baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "hesap_ozeti");
            dataGridView1.DataSource = ds.Tables["hesap_ozeti"];
            baglanti.Close();
        }
    }
}
