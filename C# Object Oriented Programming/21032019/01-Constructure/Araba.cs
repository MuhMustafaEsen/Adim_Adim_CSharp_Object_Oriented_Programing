using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Constructure
{
    class Araba
    {
        //Constructor=> Yapıcı metotlardır bir sınıf içerisindeki propertylere sınıfın instance alımı 
        //esnasında degerler verme işlemidir yapı ayağa kalkarken o degerler ile kalkar.
        //Bu metotlar tıpki void metotlar gibi çalışırlar ve geriye herhangi bir tipte deger döndürmezler.
        //ayrıca bir metot adları yoktur classın adını alırlar kısaca ctor ile oluşturulurlar
        public Araba()
        {

        }
        public Araba(string model)
        {
            this.Model = model;
        }

        public Araba(string marka, string model)
        {
            this.Marka = marka;
            this.Model = model;
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int MotorGucu { get; set; }
    }
}
