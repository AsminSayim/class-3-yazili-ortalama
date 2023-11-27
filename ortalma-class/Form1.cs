using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalma_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double y1=Convert.ToDouble(txtYazili1.Text);
            double y2 = Convert.ToDouble(txtxYazili2.Text);
            double y3 = Convert.ToDouble(txtxYazili3.Text);

            Ortalama ortalama= new Ortalama(y1,y2,y3);

            txtOrtalama.Text = ortalama.OrtalamaHesapla().ToString();

        }
    }
}
