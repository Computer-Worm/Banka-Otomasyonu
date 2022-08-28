using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek
{
    public partial class giris_ekrani : Form
    {
        public giris_ekrani()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            personel_giris aktar = new personel_giris();
            aktar.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            musteri_giris aktar = new musteri_giris();
            aktar.Show();
            Hide();
        }
    }
}
