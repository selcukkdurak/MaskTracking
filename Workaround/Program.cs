using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            //Vatandas vatandas = new Vatandas();

            SelamVer("Engin");
            SelamVer("Selçuk");
            SelamVer("Ayşe");
            SelamVer();

            int sonuc = Topla(5); //sayi1 in default olan 4 değeri yerine 5 alır fakat sayi2 yi default kullanır

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Selçuk";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Selçuk";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Malatya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
                        
            Person person1 = new Person();
            person1.FirstName = "MİRAÇ SELÇUK";
            person1.LastName = "DURAK";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "ENGİN";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //MyList
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        //resharper
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);

        }

        static int Topla(int sayi1 = 4, int sayi2 = 8)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }

        //pascal casing
        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;  //db den geliyor
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Selçuk";
            string soyad = "Durak";
            int dogumYili = 2000;
            long tcNo = 12345678910;


            Console.WriteLine(mesaj);

            Console.WriteLine(mesaj);

            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
