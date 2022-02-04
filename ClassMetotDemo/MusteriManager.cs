using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.LastName + " kişisi eklendi.");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.LastName + " kişisi silindi.");
        }
        public void List(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.LastName);
            }
        }
    }
}
