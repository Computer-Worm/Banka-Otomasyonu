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
    public partial class personel_listele : Form
    {
        public personel_listele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void personel_listele_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from personel_bilgi", baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "personel_bilgi");
            dataGridView1.DataSource = ds.Tables["personel_bilgi"];
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from personel_bilgi where personel_tc like '" + textBox1.Text + "%' ", baglanti);

            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }
    }
}
