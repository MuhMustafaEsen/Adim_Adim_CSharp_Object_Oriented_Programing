using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Abstraction
{
    class DolmaKalem : Kalem
    {
        public int DolumMiktari { get; set; }

        public override void Yaz()
        {
            MessageBox.Show("Dolma Kalem ile yazı yazarim.");
        }
        public void Yaz(string veri)
        {
            MessageBox.Show(veri + " yazi yaziyorum");
        }
    }
}
