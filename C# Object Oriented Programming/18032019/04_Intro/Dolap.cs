using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Intro
{
    public class Dolap
    {
        public string Renk { get; set; }
        public int RafSayisi { get; set; }
        public decimal Yukseklik { get; set; }
        public decimal Genislik { get; set; }
        public decimal Hacim { get; set; }
        public decimal Agirlik { get; set; }

        public void KapagıAc()
        {
            MessageBox.Show("Kapak açıl");
        }

        void KapagıKapat()
        {
            MessageBox.Show("Kapak kapan");
        }
    }
}
