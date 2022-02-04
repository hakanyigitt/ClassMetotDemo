using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { Id = 1, Name = "Hakan", LastName = "YİĞİT", IdentityNumber = "12345678910", PhoneNumber = "5305555555", Address = "Ümraniye" };
            Musteri musteri2 = new Musteri() { Id = 1, Name = "Ogün", LastName = "YİĞİT", IdentityNumber = "12345678910", PhoneNumber = "5305555555", Address = "Ümraniye" };
            Musteri musteri3 = new Musteri() { Id = 1, Name = "Beyza Nur", LastName = "YİĞİT", IdentityNumber = "12345678910", PhoneNumber = "5305555555", Address = "Ümraniye" };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.List(musteriler);
        }
    }
}
