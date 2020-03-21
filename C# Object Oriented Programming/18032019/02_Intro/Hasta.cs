using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Intro
{
    public class Hasta
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
        public string TCKimlikNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string HastaSikayeti { get; set; }
        public string Cinsiyet { get; set; }
        public Brans[] GeldigiBranslar { get; set; }
        public Doktor[] GeldigiDoktorlar { get; set; }
    }
}
