using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Struct
{
    struct Point :ITest //structlar classlardan kalıtım almamazlar sadece interface kalıtımı alırlar.
    {
        public void Test()
        {
            MessageBox.Show("ITest Interface calışıyor.");
        }
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int Hesapla()
        {
            return X + Y;
        }

        
    }
    public class Test    //structlar classlara kalitim veremezler.
    {
    }
}

