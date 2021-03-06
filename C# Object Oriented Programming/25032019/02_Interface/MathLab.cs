﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface
{
    class MathLab : IMath
    {
        public string Name => "Matematiksel İşlemler";

        public int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Cıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
