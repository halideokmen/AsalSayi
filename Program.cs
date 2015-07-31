using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {

            // kullanıcının girdiği sayının asal sayı olup olmadığını ekrana yazdır


            // kullanıcıdan al
            Console.Write("Lütfen Bir Sayı Giriniz.");
            int getSayi = Convert.ToInt32(Console.ReadLine());
            
            // işlemi yap
            int sonuc = 0;
            for (int i = 1; i <= getSayi; i++)
            {
                
                    if (getSayi%i == 0 ) 
                    {
                        sonuc++;
                        if (sonuc > 2) break;
                        
                    }
            }

            // ekrana yazdır
            if (sonuc == 2)
                Console.WriteLine("ASAL SAYIDIR");
            else 
                Console.WriteLine("ASAL SAYI DEĞİLDİR");
       
            Console.ReadKey();

        }
    }
}
