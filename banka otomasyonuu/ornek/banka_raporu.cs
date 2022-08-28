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
    public partial class banka_raporu : Form
    {
        public banka_raporu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-ELQD485; Database = banka_otomasyonu; Trusted_Connection = True;");

        private void banka_raporu_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from banka_rapor", baglanti);
            DataSet ds = new DataSet();

            da.Fill(ds, "banka_rapor");
            dataGridView1.DataSource = ds.Tables["banka_rapor"];
            baglanti.Close();
        }
    }
}
