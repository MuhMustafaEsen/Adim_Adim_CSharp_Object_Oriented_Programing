using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation
{
    public class Urun
    {
        public string UrunAdi { get; set; }

        public double Agirlik { get; set; }

        private string _id;

        public string ID
        {
            get { return _id; }
            set
            {
                if (value.Length == 6)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("6 karakterli bir id giriniz");
                }

            }
        }

        private string _aciklama;

        public string Aciklama
        {
            get { return _aciklama; }
            set
            {
                if (value.Length > 100)
                {
                    _aciklama = value;
                }
                else
                {
                    throw new Exception("Lütfen yeterli(100) bir açıklama giriniz ");
                }
            }
        }

        private double _fiyat;

        public double Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (value > 0)
                {
                    _fiyat = value;
                }
                else
                {
                    throw new Exception("Fiyat 0 dan küçük olamaz");
                }
            }
        }

        private DateTime _skt;

        public DateTime SKT
        {
            get { return _skt; }
            set
            {
                if (value > DateTime.Now.AddDays(5))
                {
                    _skt = value;
                }
                else
                {
                    throw new Exception("Skt bugunden en az 5 gun sonra olmalıdır");
                }
            }
        }



        private string _tur;

        //eger bir propertynin get metodu yok ise o yapı dışarıdan veri alır ama basamaz yani read-only çalışır
        public string Tur
        {

            set
            {
                if (value == "Balta")
                {
                    _tur = value;
                }
                else
                {
                    throw new Exception("Balta değil");
                }
            }
        }

        private string _soyad;
        //set metodu olmayan propertyler yalnızca basma islemi yaparlar bu sebeple kendilerini write-only yapılar denir
        public string Soyad
        {
            get { return _soyad; }

        }

    }
}
