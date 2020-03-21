using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElektroGitar eg = new ElektroGitar();
            string ses = eg.SesCikar();
            string tel = eg.TelSayisi();
            MessageBox.Show("çıkardıgı ses : " + ses + " tel sayisi : " + tel);

            KlasikGitar kg = new KlasikGitar();
            MessageBox.Show("çıkardıgı ses : " + kg.SesCikar() + " tel sayisi : " + kg.TelSayisi());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flut f = new Flut();
            string data = "";
            if (f.BlokMu)
            {
                data = "Evet";
            }
            else
            {
                data = "Hayir";
            }
            MessageBox.Show("çıkardıgı ses : " + f.SesCikar() + " blok mu = " + data);
        }
    }
}
