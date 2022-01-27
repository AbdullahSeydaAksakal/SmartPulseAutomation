# SmartPulse Web and Mobile Automation
Web tarafında 30.03.2020 tarihine ait Kgüp exelin indirilmesi ve Mobil 05.04.2020 tarihine ait PTF ortalamasının mail olarak atılmasını sağlayan otomasyon projesidir. 
## Proje Özellikleri
* Xunit Mimarisi kullanılmıştır.
* C# 6.0.net core dilinde yazılmıştır.
* Mobil otomasyon için Appium kütüphanesi ve Appium Inspector aracı kullanılmıştır.
* Regrasyon web otomasyonu için Selenium Web Driver 4.1.0, ChromeWebDriver Kütüphaneleri kullanılmıştır.
* Geliştirilmiş Class yapısıyla kurulmuştur.
* İlerleyen versiyonlarda specflow(bdd) Clean Code mimarisi kurulacaktır.
* İlerleyen sürümlerde, Unit, Integration, API testi gibi çoklu katmanlı mimari yapısı entegre edilecektir.
* İlerleyen süreçlerde Docker, Kubernetes teknolojileri kullanılarak birbirimden bağımsız Cross Browser ve OS testleri koşacaktır.
* Veritabanı Mimarisi eklenecektir.

## Task İsterleri(UI)
1. Url: "https://seffaflik.epias.com.tr/transparency/uretim/planlama/kgup.xhtml" 
2. Urline gider. 30.03.2020 tarihine ait Kgüp verisinin exelini indirir.

## Task İsterleri(Mobil)
1. Epias Mobil uygulamasını açar.
2. 05.04.2020 tarihine ait PTF ortalamasını 'analyst.team@smartpulse.io' adresine mail olarak iletir.
