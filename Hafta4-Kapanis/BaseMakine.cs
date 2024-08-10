using System;

namespace Hafta4_Kapanis
{
    // Tüm makineler için temel sınıf
    public abstract class BaseMakine
    {
        // Üretim tarihi, nesne oluşturulduğunda otomatik olarak atanır
        public DateTime UretimTarihi { get; } = DateTime.Now;
        public int SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        // Makinenin temel bilgilerini konsola yazdırır
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Ürün Bilgileri:\nÜretim Tarihi: {UretimTarihi}\nSeri Numarası: {SeriNumarasi}\nAdı: {Ad}\nAçıklama: {Aciklama}\nİşletim Sistemi: {IsletimSistemi}");
        }

        // Ürünün adını getiren soyut metot. Alt sınıflarda uygulanmalıdır
        public abstract void UrunAdiGetir();
    }

    // Telefon sınıfı, BaseMakine'den türetilmiştir
    class Telefon : BaseMakine
    {
        public bool TrLisans { get; set; }

        // Telefonun tüm bilgilerini, temel bilgilerle birlikte yazdırır
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Tr Lisansı: {TrLisans}");
        }

        // Telefonun adını özel bir formatta getirir
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }

    // Bilgisayar sınıfı, BaseMakine'den türetilmiştir
    class Bilgisayar : BaseMakine
    {
        // USB giriş sayısı için özel alan
        private int _usbGirisSayisi;

        // USB giriş sayısını kontrol ederek atar
        // Sadece 2 veya 4 değerlerini kabul eder, aksi halde -1 atar
        public int UsbGirisSayisi
        {
            get => _usbGirisSayisi;
            set
            {
                if (value == 2 || value == 4)
                    _usbGirisSayisi = value;
                else
                {
                    Console.WriteLine("Usb Giriş Sayısı 2 veya 4 olabilir. -1 değeri atanıyor.");
                    _usbGirisSayisi = -1;
                }
            }
        }

        public bool Bluetooth { get; set; }

        // Bilgisayarın tüm bilgilerini, temel bilgilerle birlikte yazdırır
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Usb Giriş Sayısı: {UsbGirisSayisi}\nBluetooth: {Bluetooth}");
        }

        // Bilgisayarın adını özel bir formatta getirir
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }
    }
}