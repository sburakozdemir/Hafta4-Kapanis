using Hafta4_Kapanis;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Oluşturulan ürünleri saklamak için liste
        List<BaseMakine> urunler = new List<BaseMakine>();

        while (true)
        {
            Console.WriteLine("Akıllı cihaz oluşturma uygulamasına hoşgeldiniz...");
            Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız:");

            // Kullanıcı girişini kontrol et
            if (!int.TryParse(Console.ReadLine(), out int secim) || (secim != 1 && secim != 2))
            {
                Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 giriniz.");
                continue;
            }

            // Seçime göre ürün oluştur
            BaseMakine urun;
            if (secim == 1)
                urun = new Telefon();
            else
                urun = new Bilgisayar();

            // Ortak özellikleri kullanıcıdan al
            Console.WriteLine("Seri Numarası giriniz:");
            urun.SeriNumarasi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad giriniz:");
            urun.Ad = Console.ReadLine();

            Console.WriteLine("Açıklama giriniz:");
            urun.Aciklama = Console.ReadLine();

            Console.WriteLine("İşletim Sistemi giriniz:");
            urun.IsletimSistemi = Console.ReadLine();

            // Ürün tipine özel özellikleri al
            if (urun is Telefon telefon)
            {
                Console.WriteLine("Tr Lisanslı mı? (true/false):");
                telefon.TrLisans = Convert.ToBoolean(Console.ReadLine());
            }
            else if (urun is Bilgisayar bilgisayar)
            {
                Console.WriteLine("USB Giriş Sayısı giriniz (2 veya 4):");
                bilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bluetooth var mı? (true/false):");
                bilgisayar.Bluetooth = Convert.ToBoolean(Console.ReadLine());
            }

            // Ürünü listeye ekle
            urunler.Add(urun);

            // Ürün bilgilerini yazdır
            Console.WriteLine("Ürün başarıyla üretildi!");
            urun.BilgileriYazdir();
            urun.UrunAdiGetir();

            // Kullanıcıya devam etmek isteyip istemediğini sor
            Console.WriteLine("Başka bir ürün üretmek istiyor musunuz? (E/H)");
            if (Console.ReadLine().ToUpper() != "E")
                break;
        }

        Console.WriteLine("İyi günler! Uygulama sonlandırılıyor...");
    }
}