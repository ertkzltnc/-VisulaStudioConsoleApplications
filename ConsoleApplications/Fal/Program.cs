using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fal
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            int dogumYili, sonuc, sayac = 0;
           // char[] karakter;
            string[] burclar = { "Maymun", "Horoz", "Köpek", "Domuz", "Fare", "Öküz", "kaplan", "Tavşan", "Ejderha", "Yılan", "At", "Keçi" };

            try
            {
                Console.WriteLine("Dogum Yili:");
                dogumYili = Convert.ToInt32(Console.ReadLine());
                if ((2019 - dogumYili) > 18)
                {
                    yeniGiris:
                    Console.Write("İsim Giriniz:");

                    isim = Console.ReadLine();
                   char[] karakter = isim.ToCharArray();
                    for (int i = 0; i < isim.Length; i++)
                    {
                        if (Char.IsSymbol(karakter[i]) || Char.IsNumber(karakter[i]))
                        {
                            sayac++;
                            
                        }
                       
                        
                            

                        

                    }
                    if (sayac == 0)
                    {
                        sonuc = (2019 - dogumYili) % 12;
                        Console.WriteLine("{0} burcunuz:{1}", isim, burclar[sonuc]);
                        

                    }
                    else Console.WriteLine("isim hatali giris"); sayac = 0; goto yeniGiris;


                }
                else
                {
                    Console.WriteLine("18 yasindan büyük olmalısınız.!!");

                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            finally { Console.WriteLine(""); }
            Console.ReadKey();
        }
    }
}
