using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteriler)
        {
            Console.WriteLine("Kişi Sisteme Kayıt edildi.");
            Console.WriteLine("\nKişi İsmi: "+musteriler.FirstName);
        }
        public void Delete(Musteri musteriler)
        {
            Console.WriteLine("Kişinin Kaydı Sistemden Silinmiştir.");
            Console.WriteLine("\nKişi İsmi: "+musteriler.FirstName);
        }
        public void ListofMusteri(Musteri[] musteriler)
        {
            Console.WriteLine("Kişiler Listelenmiştir.\n");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Kişi İsmi: "+musteri.FirstName+"\nKişi Soyismi: "+musteri.LastName+"\nKişi Bakiyesi: "+musteri.Balance+"\n");
            }
        }
    }
}
