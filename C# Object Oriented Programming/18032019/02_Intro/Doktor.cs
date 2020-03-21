using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Intro
{
   public class Doktor //access modifier public oldugu için diger classlardan erişebiliriz.
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Brans Uzmanlik { get; set; }//Brans adindaki kendi yazdıgımız sinifi ozellik olarak verebiliriz.

    }
}
