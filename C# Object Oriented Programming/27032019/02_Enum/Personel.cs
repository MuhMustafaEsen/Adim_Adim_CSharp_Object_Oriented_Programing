using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Enum
{

    public enum Departmanlar
    {
        Yazilim, Sistem, İşAnalizi, Grafik, Egitim, Muhasebe
    }

    public class Personel
    {
        private string _adiSoyadi;

        public string  AdiSoyadi
        {
            get { return _adiSoyadi; }
            set { _adiSoyadi = value; }
        }

        private Departmanlar _departmanlar;

        public Departmanlar departmanlar
        {
            get { return _departmanlar; }
            set { _departmanlar = value; }
        }

    }
}
