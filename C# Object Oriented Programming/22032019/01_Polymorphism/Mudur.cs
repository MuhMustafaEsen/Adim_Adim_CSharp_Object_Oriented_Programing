using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Polymorphism
{
    class Mudur : Personel
    {
        public override decimal Maas {
            get
            {
                return GunlukKazanc * CalisilanGun;
            }     
        }
        
    }
}
