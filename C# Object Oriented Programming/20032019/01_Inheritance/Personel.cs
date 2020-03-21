using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inheritance
{
    public class Personel:Kisi
    {
        public string Title { get; set; }
        public decimal Maas { get; set; }
        public string Departman { get; set; }
        public DateTime İseGirisTarihi { get; set; }
    }
}
