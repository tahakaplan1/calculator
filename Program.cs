using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basit_Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basit Hesaplama");
            Console.WriteLine("Lütfen İşlem Yapmak İstediğiniz 1. Sayıyı Giriniz");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen İşlem Yapmak İstediğiniz 2. Sayıyı Giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçini");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkartma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            int secim = Convert.ToInt32(Console.ReadLine());
            int sonuc = 0;
            if (secim == 1)
            {
                sonuc = sayı1 + sayi2;
                Console.WriteLine("İki Sayının Toplamı=" + sonuc);


            }
            else if(secim == 2)
            {
                sonuc = sayı1 - sayi2;
                Console.WriteLine("Birinci Sayının ikinci sayıdan Çıkarımı = "+sonuc);

            }
            else if(secim == 3)
            {
                sonuc = sayı1 * sayi2;
                Console.WriteLine("İki Sayının Çarpımı ="+ sonuc);
            }
            else if (secim == 4)
            {
                sonuc = sayı1 / sayi2;
                Console.WriteLine("Birinci Sayının İkinci Sayıya Bölümü ="+ sonuc);
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli Bir işlem Seçiniz");
            }
            Console.ReadLine();
        }
    }
}
