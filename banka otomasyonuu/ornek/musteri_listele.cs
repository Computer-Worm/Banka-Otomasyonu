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
    public partial class musteri_listele : Form
    {
        public musteri_listele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void musteri_listele_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * From musteri_bilgi", baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "musteri_bilgi");
            dataGridView1.DataSource = ds.Tables["musteri_bilgi"];
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from musteri_bilgi where hesap_no like '" + textBox1.Text + "%' ", baglanti);

            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

    }
}
