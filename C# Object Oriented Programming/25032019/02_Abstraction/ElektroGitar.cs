using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstraction
{
    class ElektroGitar : Gitar
    {
        public override string TelSayisi()
        {
            return "4";
        }
        public override string SesCikar()
        {
            return "Elektro Gitar sesi";
        }
    }
}
