using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sealed
{
    class BaseBook
    {
        //Sealed anahtar kelimesi kendisinden nesne türetebilir ama miras verilemez(Muhurludur).
        //abstract classlar ile tam zıt mantıkla çalışırlar.
        //abstract oluşturulan class kalıtım alındığı classlarda işlevseldir
        //ama sealed sadece var olan classta işlevseldir. kalıtım alınamaz
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual void GetLog()
        {
            //
        }

        public virtual void UserLog()
        {

        }
    }
}
