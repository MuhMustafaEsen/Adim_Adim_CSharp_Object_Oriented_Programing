using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Polymorphism
{
    class SatisTemsilcisi:Personel
    {
        public int satisAdedi { get; set; }

        public override decimal Maas
        {
            get
            {
                return (CalisilanGun * GunlukKazanc) + (GunlukKazanc * 80 / 100) * satisAdedi;
            }
        }
    }
}
