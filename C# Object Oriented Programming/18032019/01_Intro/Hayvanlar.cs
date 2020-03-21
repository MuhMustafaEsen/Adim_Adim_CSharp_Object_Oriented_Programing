using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Intro
{
    class Hayvanlar
    {
        /*ACCESS MODİFİERS
         * 
         * Public => bir yapı public olarak belirlendiyse o yapıya her yerden erişilebilir. Public erişim belirleyicisinin hiç bir kısıtlaması yoktur.
         * 
         * Internal => bulunduğu assembly(dll ve exe) içinde erişilebilir. Classlar default olarak internal gelirler
         * 
         * Private => bir değerin private olarak tanımlanması o yapıya yalnızca o classta erişilebilir. class seviyesindeki yapılar(degişkenler metotlar) default olarak private gelirler.
         * 
         * Protected => oluşturulan sınıfta ve o sınıftan türetilmiş (kalıtım alınmış miras edilmiş) yapılarda kullanılırlar.
         * 
         * Internal Protected
         */

         //propertyler
        public string Ad { get; set; }
        public int Yas { get; set; }
        public string Tur { get; set; }
        public string Cins { get; set; }
        public bool OmurgaliMi { get; set; }
    }
}
