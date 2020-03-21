using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kalem gozKalemi = new GozKalemi();

            gozKalemi.Marka = "Maybelline";
            gozKalemi.Renk = "Siyah";

            MessageBox.Show("göz kaleminin markası " + gozKalemi.Marka);
            gozKalemi.Yaz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kalem tahtaKalemi = new TahtaKalemi();

            tahtaKalemi.Fiyat = 15;
            tahtaKalemi.Renk = "mor";

            MessageBox.Show("tahta kaleminin fiyatı " + tahtaKalemi.Fiyat);
            tahtaKalemi.Yaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DolmaKalem dolmakalem = new DolmaKalem();
            dolmakalem.Renk = "Mavi";
            dolmakalem.Fiyat = 100;
            string veri = dolmakalem.Renk + " renkli fiyati : " + dolmakalem.Fiyat + " tl olan kalem ile";
            dolmakalem.Yaz(veri);
        }
    }
}
