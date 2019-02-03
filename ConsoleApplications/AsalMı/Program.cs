using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDenemeler
{
    class programs

    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc;
            try
            {
                Console.WriteLine("sayi1:");
                sayi1 = Convert.ToInt32(Console.ReadLine();
                Console.WriteLine("sayi2");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                sonuc = sayi1 / sayi2;
                Console.WriteLine("sonuc:{0}",sonuc);
            }
            catch (Exception)
            {
                Console.WriteLine("Hata");
                throw;
            }
        }
            
    }
}
