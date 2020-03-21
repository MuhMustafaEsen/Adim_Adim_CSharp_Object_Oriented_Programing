using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interface
{
    interface IMath
    {
        int Topla(int sayi1, int sayi2);
        int Cıkar(int sayi1, int sayi2);
        int Carp(int sayi1, int sayi2);
        int Bol(int sayi1, int sayi2);
        string Name { get; }
    }
}
