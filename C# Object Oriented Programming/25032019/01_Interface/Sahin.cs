using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Interface
{
    class Sahin : Araba, IRadio,IKafaSallayanKopekObjesi
    {
        public void FrekansBul()
        {
           MessageBox.Show("Frekans bulundu");
        }

        public void KafaSalla()
        {
            throw new NotImplementedException();
        }
    }
}
