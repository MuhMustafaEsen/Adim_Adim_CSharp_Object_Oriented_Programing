using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Abstraction
{
    class TahtaKalemi : Kalem
    {
        public bool MurekkepVarmi { get; set; }

        public override void Yaz()
        {
            MessageBox.Show("Tahta kalemi tahtayi boyar.");
        }
    }
}
