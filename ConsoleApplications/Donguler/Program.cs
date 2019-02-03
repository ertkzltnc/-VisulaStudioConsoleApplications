using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, carpim = 1, sayac = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sayi Girisi:");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0 && sayi % 2 == 1) carpim *= sayi;sayac++;
            }
            if(sayac>=1)Console.WriteLine("sonuc:{0}",carpim);
            else Console.WriteLine("sonuc:{0}",0);
            Console.ReadKey();
        }
       
    }
}
