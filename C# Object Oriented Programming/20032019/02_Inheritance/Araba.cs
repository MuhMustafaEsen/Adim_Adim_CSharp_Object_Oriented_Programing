using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Inheritance
{
    class Araba:Tasit
    {
        public string Plaka { get; set; }
        public Color Renk { get; set; }
        public string Kasa { get; set; }
        public string BagajHacmi { get; set; }
    }
}
