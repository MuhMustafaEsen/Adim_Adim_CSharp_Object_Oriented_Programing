using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Interface
{
    class Porsche : Araba, IABS,IRadio,IKoltukIsıtma,IOtoPilot,ISunRoof
    {
        public string Malzeme
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void AbsCalis()
        {
            MessageBox.Show("Abs Çalışiyor");
        }

        public void FrekansBul()
        {
            throw new NotImplementedException();
        }

        public void KoltukIsisiniOlc()
        {
            throw new NotImplementedException();
        }

        public void SeritTakipEt()
        {
            throw new NotImplementedException();
        }

        public void TavanAc()
        {
            throw new NotImplementedException();
        }
    }
}
