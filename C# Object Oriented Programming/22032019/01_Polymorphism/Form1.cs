using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mudur m = new Mudur();
            m.Ad = "Mustafa";
            m.Soyad = "Esen";
            m.CalisilanGun = 24;
            m.GunlukKazanc = 165;

            MessageBox.Show(m.Ad + " " + m.Soyad +" kazandıgı para = " + m.Maas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MudurYardimcisi my = new MudurYardimcisi();
            my.Ad = "Gizem";
            my.Soyad = "İşeri";
            my.CalisilanGun = 24;
            my.GunlukKazanc = 165;

            MessageBox.Show(my.Ad + " " + my.Soyad + " kazandıgı para = " + my.Maas);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatisTemsilcisi st = new SatisTemsilcisi();
            st.Ad = "abbas";
            st.Soyad = "cokkazanan";
            st.CalisilanGun = 20;
            st.GunlukKazanc = 120;
            st.satisAdedi = 10;

            MessageBox.Show(st.Ad + " " + st.Soyad + " kazandıgı para = " + st.Maas  );
        }
    }
}
