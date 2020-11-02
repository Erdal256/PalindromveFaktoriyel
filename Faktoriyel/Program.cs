using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, i, f = 1;
            Console.WriteLine("Faktoriyeli sayı giriniz:");
            sayi = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= sayi; i++)
            {

                f = i * f;

            }
            Console.WriteLine("Cevap : " + f);

            Console.ReadLine();
        }
    }
}
