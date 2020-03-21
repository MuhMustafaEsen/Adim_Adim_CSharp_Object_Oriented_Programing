using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Struct
{
    struct Ogrenci
    {
        /*STRUCT
        * Classlar referans tiplidir ama structlar deger tipli bir programlama öğeleridir.
        * Microsoft derki tasarlayacağınız yapı 16KB dan az ise struct kullanın.
        * Structlar kalıtımı desteklemez ancak interface alabilirler
        * Structlara parametresiz constructor tanımlanamaz default olarak gelir ama senin tanımlamana izin vermez.


       */
        public Ogrenci(string tc, string ad, string soyad, DateTime giris, string bolum)
        {
            _TCKNo = tc;
            _ad = ad;
            _soyad = soyad;
            _girisTarihi = giris;
            _bolum = bolum;
        }

        private string _TCKNo;

        public string TCKNo
        {
            get { return _TCKNo; }
            set
            {
                if (value.Length == 11)
                {
                    _TCKNo = value;
                }
            }
        }

        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        private string _bolum;

        public string Bolum
        {
            get { return _bolum; }
            set { _bolum = value; }
        }

        private DateTime _girisTarihi;

        public DateTime GirisTarihi
        {
            get { return _girisTarihi; }
            set { _girisTarihi = value; }
        }

        public string TamAdiGetir()
        {
            return Ad + " " + Soyad;
        }

    }
}
