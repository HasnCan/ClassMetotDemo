using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Behlül";
            musteri1.LastName = "Zeki";
            musteri1.Balance = 15468;

            Musteri musteri2= new Musteri();
            musteri2.Id = 2;
            musteri2.FirstName = "Lale";
            musteri2.LastName = "Akasya";
            musteri2.Balance = 562;

            Musteri musteri3=new Musteri();
            musteri3.Id = 3;
            musteri3.FirstName = "Ziya";
            musteri3.LastName = "Yenilmez";
            musteri3.Balance = 82;

            Musteri[] musteriler=new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager=new MusteriManager();

            
            musteriManager.Add(musteri1);
            Console.WriteLine("-------------");
            musteriManager.Delete(musteri3 );
            Console.WriteLine("-------------");
            musteriManager.ListofMusteri(musteriler);
            Console.WriteLine("-------------");
            


        }
    }
}