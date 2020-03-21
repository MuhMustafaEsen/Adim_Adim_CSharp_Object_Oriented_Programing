using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Brans ortopedi = new Brans();
            Brans dahiliye = new Brans();

            Doktor doktor1 = new Doktor();
            doktor1.Ad = "Cihan";
            doktor1.Soyad = "Cetinkaya";
            doktor1.Uzmanlik = dahiliye;

            Hasta hasta1 = new Hasta();
            hasta1.Isim = "Mustafa";
            hasta1.Soyisim = "Esen";
            hasta1.GeldigiBranslar[0] = ortopedi;
        }
    }
}
