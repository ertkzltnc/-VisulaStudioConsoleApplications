using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    class Program
    {
        static void Main(string[] args)
        {
            string sifre = "2019";
            string girilenSifre;
             int sayac = 0;
            do
            {
                Console.WriteLine("Sifre Giriniz:");
                girilenSifre = Console.ReadLine();
                if (sifre == girilenSifre)
                {
                   
                    Console.WriteLine("Giris Basarili"); break;
                }
                else
                {
                    sayac++;
                    if (sayac==3)
                    {
                        Console.WriteLine("kartınız bloke oldu !!"); break;
                    }
                    else Console.WriteLine("Sifre hatalı Tekrar Giris Yapınız.(Kalan Hak {0})",3-sayac);
                }
               
                
            } while (true);
            Console.ReadKey();

        }
    }
}
