using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanVeHacimHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int islem;// Alan ve hacim Secimi kontrol degiskeni
            int sekilSecimi;//Ana menü geometrik sekil secim degiskeni
            // Geometrik şekil seçm işlemi için menü yazıyoruz.
            Console.WriteLine("****MENÜ****");
            Console.WriteLine("Piramit Alan veya Hacim İslemleri İçin 1");//Kare Piramit İcin
            Console.WriteLine("Küre Alan veya Hacim İslemleri İçin 2");
            Console.WriteLine("Küp Alan veya Hacim İslemleri İçin 3");
            Console.WriteLine("Silindir Alan veya Hacim İslemleri İçin 4");
            Console.WriteLine(" Secim İslemi Yapınız ! ");
             sekilSecimi = Convert.ToInt32(Console.ReadLine()); // Secilen geometrik sekil  degiskene atanıyor.
            
            switch (sekilSecimi)
            {
                case 1:
                    double tabanUzunlugu, yukseklik, piramitAlan, piramitHacim;//Piramit alan ve hacim icin gerekli degiskenler
                    Console.WriteLine("Alan Hesabı icin '1',Hacim Hesabı İcin '2'");
                     islem = Convert.ToInt32(Console.ReadLine());
                    if (islem == 1)
                    {
                        Console.WriteLine("Piramit icin alan hesaplaması");
                        Console.Write("Kare piramit icin taban uzunlugu giriniz :");
                        tabanUzunlugu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Kare piramit icin yükseklik giriniz:");
                        yukseklik = Convert.ToDouble(Console.ReadLine());
                        piramitAlan = tabanUzunlugu * (tabanUzunlugu + Math.Sqrt(Math.Pow(tabanUzunlugu,2) + 4 * Math.Pow(yukseklik,2)));//Piramit alan hesaplama formül
                        Console.WriteLine("Kare piramit alanı: {0}",piramitAlan);

                    }
                    else if(islem==2)
                    {
                        Console.WriteLine("Piramit icin hacim hesaplama");
                        Console.Write("Kare piramit icin taban uzunlugu giriniz :");
                        tabanUzunlugu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Kare piramit icin yükseklik giriniz:");
                        yukseklik = Convert.ToDouble(Console.ReadLine());
                        piramitHacim = (Math.Pow(tabanUzunlugu,2) * yukseklik) / 3;
                        Console.WriteLine("Kare piramit hacim: {0}",piramitHacim);

                    }
                    else Console.WriteLine("Gecersiz İslem !!");
                    break;
                case 2:
                    double küreYariCap, küreAlan, küreHacim;// Küre alan ve hacim icin gerekli degiskenler 
                    
                    Console.WriteLine("Alan Hesabı icin '1',Hacim Hesabı İcin '2'");
                     islem = Convert.ToInt32(Console.ReadLine());
                    if (islem == 1)
                    {
                        Console.WriteLine("Küre icin alan hesaplaması");
                        Console.Write("Küre yari cap uzunlugu giriniz: ");
                        küreYariCap = Convert.ToDouble(Console.ReadLine());
                        küreAlan = 4 * Math.PI * Math.Pow(küreYariCap,2);
                        Console.WriteLine("Küre yüzey alanı: {0}",küreAlan);


                    }
                    else if (islem == 2)
                    {
                        Console.WriteLine("Küre icin hacim hesaplama");
                        Console.Write("Küre yari cap uzunlugu giriniz: ");
                        küreYariCap = Convert.ToDouble(Console.ReadLine());
                        küreHacim = (4 * Math.PI* Math.Pow(küreYariCap, 3)) / 3;
                        Console.WriteLine("Küre hacim: {0}",küreHacim);
                    }
                    else Console.WriteLine("Gecersiz İslem !!");
                    break;
                case 3:
                    double kenarUzunlugu, küpAlan, küpHacim;// Küp alan ve hacim icin gerekli degiskenler
                    Console.WriteLine("Alan Hesabı icin '1',Hacim Hesabı İcin '2'");
                     islem = Convert.ToInt32(Console.ReadLine());
                    if (islem == 1)
                    {
                        Console.WriteLine("Küp icin alan hesaplaması");
                        Console.Write("Küp kenar uzunlugu giriniz:");
                        kenarUzunlugu = Convert.ToDouble(Console.ReadLine());
                        küpAlan = 6 * Math.Pow(kenarUzunlugu, 2);
                        Console.WriteLine("Küp Yüzey alanı: {0}",küpAlan);

                    }
                    else if (islem == 2)
                    {
                        Console.WriteLine("Küp icin hacim hesaplama");
                        Console.Write("Küp kenar uzunlugu giriniz:");
                        kenarUzunlugu = Convert.ToDouble(Console.ReadLine());
                        küpHacim = Math.Pow(kenarUzunlugu, 3);
                        Console.WriteLine("Küp hacim: {0}",küpHacim);
                    }
                    else Console.WriteLine("Gecersiz İslem !!");
                    break;
                case 4:
                    double silindirYariCap,silindirYukseklik,silindirAlan,silindirHacim;// silindir alan ve hacim hesaplama icin gerekli degiskenler
                    Console.WriteLine("Alan Hesabı icin '1',Hacim Hesabı İcin '2'");
                    islem = Convert.ToInt32(Console.ReadLine());
                    if (islem == 1)
                    {
                        Console.WriteLine("Silindir icin alan hesaplaması");
                        Console.Write("Silindir yarıcap giriniz:");
                        silindirYariCap = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Silindir yukseklik giriniz:");
                        silindirYukseklik = Convert.ToDouble(Console.ReadLine());
                        silindirAlan = 2 * Math.PI * Math.Pow(silindirYariCap, 2) + 2 * Math.PI * silindirYariCap * silindirYukseklik;
                        Console.WriteLine("Silindir yüzey alanı: {0}",silindirAlan);


                    }
                    else if (islem == 2)
                    {
                        Console.WriteLine("Silindir icin hacim hesaplama");
                        Console.Write("Silindir yarıcap giriniz:");
                        silindirYariCap = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Silindir yukseklik giriniz:");
                        silindirYukseklik = Convert.ToDouble(Console.ReadLine());
                        silindirHacim = Math.PI * Math.Pow(silindirYariCap, 2) * silindirYukseklik;
                        Console.WriteLine("Siindir hacim: {0}",silindirHacim);
                    }
                    else Console.WriteLine("Gecersiz İslem !!");
                    break;
                default:
                    Console.WriteLine("Yanlış Giriş Yaptınız.");// İstenilen sekil harici giris olursa kontrol ediliyor.
                    break;
            }

            Console.ReadKey();
        }
    }
}
