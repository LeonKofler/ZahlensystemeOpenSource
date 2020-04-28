using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZahlensystemeOpenSource
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        static string ConvertToHex(string Eingelesen)
        {
            string Erg = Convert.ToInt32(Eingelesen, 2).ToString("X");

            return Erg;
        }


    }
}
