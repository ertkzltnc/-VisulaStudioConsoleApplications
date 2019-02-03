using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziDoldurma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random rnd = new Random();
            int sayi, sayac = 0;
            for (int i = 0; i < 10; i++)
            {
                sayi = rnd.Next(0, 21);
                for(int k=0; k<=i;k++)
                {
                    if (dizi[k] == sayi) sayac++; 

                }
                if (sayac == 0) dizi[i] = sayi;
                else { sayac = 0;i--; }

            }
            foreach (int x in dizi)
            {
                Console.WriteLine("{0}",x);

            }
            Console.ReadKey();
        }
    }
}
