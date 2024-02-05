using Business.Concrete;
using System;
using System.Collections.Generic;
namespace Workaround
{
    class Program
    {
        private static object person1;

        static void Main(string[] args)
        {
            //Degiskenler();

            //Vatandas vatandas1 = new Vatandas();

            SelamVer("Engin");
            SelamVer("Ayse");
            SelamVer("Mustafa");
            SelamVer();
            int sonuc = Topla(6,50);
            // Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";
            for(int i = 0; i<ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Kayseri 1");
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            Entities.Concrete.Person person1 = new Entities.Concrete.Person();
            person1.FirstName = "Mustafa";
            person1.LastName = "SARIALP";
            person1.DateofBirthYear = 1989;
            person1.NationalIdentity = 11123421222;
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba! " + isim);
        }
        static int Topla(int sayi1=5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam " + sonuc.ToString());
            return sonuc;
        }
        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmismi = false;

            string ad = "Mustafa";
            string soyad = "Sarıalp";
            int dogumYili = 1989;
            long tcNo = 111222334455;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }
    // pascal casing
    public class Vatandas
    {
        //public string ad = "Mustafa";
        //public string soyad = "Sarıalp";
        //public int dogumYili = 1989;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
