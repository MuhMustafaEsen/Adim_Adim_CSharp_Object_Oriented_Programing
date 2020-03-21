using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Sealed
{
    sealed class CookBook : Book, ITest
    {
        public void Test()
        {
            MessageBox.Show("Interface çalışıyor.");
        }
    }
}
