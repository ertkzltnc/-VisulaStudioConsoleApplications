using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamAgaci
{
    class Program
    {
        static void Main(string[] args)
        {
            string bosluk = " ";
            int boyut;
            Console.WriteLine("boyut giriniz");
            boyut=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < boyut; i = i + 2)
            {
                int j = (boyut - i) / 2;
                for (int k = 1; k <= j; k++)
                {
                    Console.Write(bosluk);


                }
                for (int m = 1; m <= i; m = m + 1)
                {
                    Console.Write("*");
                }
                for (int l = 1; l <= j; l++)
                {
                    Console.Write(bosluk);


                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
