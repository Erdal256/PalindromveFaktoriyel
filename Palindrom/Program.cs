using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {

          

            int sayi, rem, sum = 0, gcc;
            
            Console.Write(" Sayı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            gcc = sayi;
            while (sayi > 0)
            {
                rem = sayi % 10;
                sayi = sayi / 10;
                sum = sum * 10 + rem;
            }
            if (gcc == sum)
            {
                Console.WriteLine(" Sayı Palindrom'dur.");
            }
            else
            {
                Console.WriteLine(" Sayı Palindrom Değil.");
            }
            
            ConsoleKeyInfo tus = new ConsoleKeyInfo();
            do
            {
                tus = Console.ReadKey(true);
               
                Console.WriteLine("'{0}' harfine bastınız.", tus.Key);
            } while (tus.Key != ConsoleKey.Q);

        }

    }
}


