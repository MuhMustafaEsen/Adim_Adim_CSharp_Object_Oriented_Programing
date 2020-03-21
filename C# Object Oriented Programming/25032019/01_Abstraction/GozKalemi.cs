using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Abstraction
{
    class GozKalemi : Kalem
    {
        public bool SuyaDayaniklimi { get; set; }
        public bool Isiltilimi { get; set; }

        public override void Yaz()
        {
            MessageBox.Show("Göz kalemi gözü boyar.");
        }
    }
}
