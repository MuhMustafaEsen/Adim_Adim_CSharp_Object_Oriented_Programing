using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dolap evDolabi = new Dolap();
            evDolabi.Agirlik = 100;
            evDolabi.Genislik = 200;
            evDolabi.Hacim = 500;
            evDolabi.Yukseklik = 50;

            evDolabi.KapagıAc();
            //bu mmethod çalışır.
            //fakat diger method public olarak erişim belirleyicisi ayarlanmadıgı için çagırılmaz.
        }
    }
}
