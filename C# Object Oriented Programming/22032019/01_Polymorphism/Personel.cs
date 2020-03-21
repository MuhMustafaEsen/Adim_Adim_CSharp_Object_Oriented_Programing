using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Polymorphism
{
    public class Personel
    {
        //Bu senaryoda personal base classtır. base class kalıtım verileceği classların temel özelliklerini 
        //tutar eger biz burada bir virtual metot oluşturursak bu bizim o metodu kalıtım aldığımız sınflarda
        //ezip farklı biçimlerde kullanmamızı sağlar virtual ezilebilir demektir base classta tanımlarken kullanılması gerekir 
        //ancak kalıtım alınan diğer classlarda override anahtar kelimesiyle ezilmelidir. Ayrıca her kalıtım aldığın classta 
        //bu yapıyı ezmek zorunda değilsin ezmezsen base'de nasıl tanımlandıysa o şekilde gelir
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int CalisilanGun { get; set; }
        public decimal GunlukKazanc { get; set; }

        public virtual decimal Maas
        {
            get
            {
                return GunlukKazanc * CalisilanGun;
            }
        }
    }
}
