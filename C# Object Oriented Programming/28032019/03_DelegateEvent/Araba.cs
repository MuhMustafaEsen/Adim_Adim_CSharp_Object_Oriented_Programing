using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DelegateEvent
{
    public delegate void HizAsimiEventHandler(); //delegate oluşturma

    public class Araba
    {
        public Araba(int hiz, string marka)
        {
            this.Hiz = hiz;
            this.Marka = marka;
        }

        private int _hiz;

        public int Hiz
        {
            get { return _hiz; }
            set
            {
                _hiz = value;
                if (value > 120)
                {
                    //event tetiklenecek;
                    HizAsimi();
                }
            }
        }

        public event HizAsimiEventHandler HizAsimi; //event  oluşturma
        private string _Marka;

        public string Marka
        {
            get { return _Marka; }
            set { _Marka = value; }
        }


    }
}
