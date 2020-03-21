using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sample
{
    class Personel
    {
        public Personel(string name)
        {
            this.Ad = name;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        private DateTime _dTarihi;

        public DateTime DTarihi
        {
            get { return _dTarihi; }
            set
            {
                if (DateTime.Now.Year - value.Year >= 18)
                {
                    _dTarihi = value;
                }
                else
                {
                    throw new Exception("büyüde gel");
                }
            }
        }

        public DateTime IsGirisTarihi { get; set; }
    }
}
