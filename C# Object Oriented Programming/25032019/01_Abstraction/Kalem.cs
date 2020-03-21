using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Abstraction
{
    //abstract classlar abstract olmayan üyeler barındırabilirler ancak abstrac bir üye varsa 
    //class kesinlikle abstrac olmalıdır.
    //Abstract classlardan instance alınamaz.
    //Abstract class içerisinde abstract tanımlanan yapının bir gövdesi bulunmaz 
    //bu yapı kalıtım alındığı classta implement edilerek gövdelendirilir.

    abstract class Kalem
    {
        public string Marka { get; set; }

        public string Renk { get; set; }

        public decimal Fiyat { get; set; }

        public abstract void Yaz(); // Yaz metodu bu classtan kalıtım aldığın her classtan tanımlamak (implement etmek) zorunda kalırsın abstract sınıfın ozelliği.
    }
}
