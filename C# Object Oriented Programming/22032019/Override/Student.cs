using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    public class Student
    {
        public Student(string ad,string soyad,int vize,int final)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.VizeNotu = vize;
            this.FinalNotu = final;

        }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public bool Basari { get; set; }

        private int _vizeNotu;

        public int VizeNotu
        {
            get { return _vizeNotu; }
            set {

                if (value >=0  && value <= 100 )
                {
                    _vizeNotu = value;
                }
                else
                {
                    throw new Exception("Lütfen 0 ile 100 arasında bir not giriniz.");
                }
                }
        }
        private int _finalNotu;

        public int FinalNotu
        {
            get { return _finalNotu; }
            set
            {
                if (value >=0  && value <= 100) 
                {
                    _finalNotu = value;
                }
                else
                {
                    throw new Exception("Lütfen 0 ile 100 arasında bir not giriniz.");
                }
            }
        }
        public override string ToString()
        {
            string sonuc = "kaldi";
            if (Basari)
            {
                sonuc = "geçti";
            }
            return sonuc;
        }
        

    }
}
