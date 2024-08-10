# Akıllı Cihaz Oluşturma Uygulaması

Bu proje, basit bir akıllı cihaz (telefon ve bilgisayar) oluşturma uygulamasını içerir. Nesne Yönelimli Programlama (OOP) prensiplerini kullanarak geliştirilmiştir ve C# programlama dilinde yazılmıştır.

## Özellikler

- Telefon ve Bilgisayar nesneleri oluşturma
- Nesne Yönelimli Programlama prensiplerinin uygulanması:
  - Kalıtım (Inheritance)
  - Kapsülleme (Encapsulation)
  - Çok Biçimlilik (Polymorphism)
  - Soyutlama (Abstraction)
- Kullanıcı girdisi ile cihaz özelliklerini belirleme
- Oluşturulan cihazların bilgilerini görüntüleme

## Proje Yapısı

Proje iki ana bölümden oluşur:

1. `BaseMakine`, `Telefon`, ve `Bilgisayar` sınıflarını içeren sınıf kodu
2. Kullanıcı etkileşimini ve program akışını yöneten ana program kodu

### Sınıf Yapısı

  - `BaseMakine`: Tüm cihazlar için temel sınıf
  - `Telefon`: `BaseMakine`'den türetilmiş telefon sınıfı
  - `Bilgisayar`: `BaseMakine`'den türetilmiş bilgisayar sınıfı

### Ana Program

Ana program, kullanıcıdan girdi alarak cihaz oluşturma sürecini yönetir ve oluşturulan cihazların bilgilerini görüntüler.

## Kullanım

1. Programı çalıştırın.
2. Telefon oluşturmak için '1', Bilgisayar oluşturmak için '2' tuşuna basın.
3. İstenilen bilgileri girin (Seri Numarası, Ad, Açıklama, İşletim Sistemi vb.).
4. Cihaz tipine özel bilgileri girin (Telefon için Tr Lisansı, Bilgisayar için USB Giriş Sayısı ve Bluetooth).
5. Oluşturulan cihazın bilgilerini görüntüleyin.
6. Başka bir cihaz oluşturmak isteyip istemediğinizi belirtin.
