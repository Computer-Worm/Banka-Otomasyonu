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
    public partial class baslangic : Form
    {
        public baslangic()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;

            if (panel2.Width >= 600)
            {
                timer1.Stop();
                giris_ekrani giris = new giris_ekrani();
                giris.Show();
                Hide();
            }
        }
    }
}
