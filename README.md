# Yemek_Tarif_Sitesi 🍽️  
_ASP.NET Web Forms ile Yemek Tarifi Yönetim Projesi_

Yemek_Tarif_Sitesi, **ASP.NET Web Forms** kullanılarak geliştirilmiş, **SQL Server** tabanlı ve **ADO.NET** ile veri erişimi sağlayan **eğitim amaçlı** bir web projesidir.

Bu proje; sayfa tabanlı web mimarisini, veritabanı bağlantılarını ve ASP.NET Web Forms yapısını öğrenmek ve pekiştirmek amacıyla oluşturulmuştur.

---

## ⚙️ Kurulum

### 1. Depoyu Klonla

    git clone https://github.com/Melikeacar/Yemek_Tarif_Sitesi.git
    cd Yemek_Tarif_Sitesi

---

## 🗄️ Veritabanı Ayarları (SQL Server)

- **SQL Server** kurulu ve çalışır durumda olmalıdır
- Aşağıdaki isimde bir veritabanı oluşturun:

    Dbo_yemektarif

- Proje **Windows Authentication** kullanmaktadır
- Veritabanı bağlantısı `SqlSinifi.cs` dosyası içinde tanımlıdır

Örnek bağlantı cümlesi:

    Data Source=SUNUCU_ADI;
    Initial Catalog=Dbo_yemektarif;
    Integrated Security=True;
    TrustServerCertificate=True;

> ℹ️ `SUNUCU_ADI` kısmını kendi SQL Server instance adınız ile değiştirin.

---

## ▶️ Çalıştırma

1. **Visual Studio** ile çözüm dosyasını açın:

    Yemek_Tarif_Sitesi.sln

2. **Yemek_Tarif_Sitesi** projesini  
   **Başlangıç Projesi (Startup Project)** olarak ayarlayın

3. Projeyi çalıştırın:

    Ctrl + F5

4. Uygulama **localhost (IIS Express)** üzerinden tarayıcıda açılacaktır

> ⚠️ Localhost üzerinde HTTPS kullanıldığı için tarayıcıda güvenlik uyarısı çıkabilir.  
> Bu, geliştirme ortamları için **normal bir durumdur**.

---

## 📁 Proje Yapısı

Yemek_Tarif_Sitesi/
│
├── Yemek_Tarif_Sitesi/
│ ├── GununYemegi.aspx
│ ├── *.aspx
│ ├── *.vb
│ ├── Master Pages
│
├── SqlSinifi.cs
├── Yemek_Tarif_Sitesi.sln
├── .gitignore
└── .gitattributes


---

## 📌 Notlar

- Bu proje **öğrenme amaçlı** geliştirilmiştir
- ORM (Entity Framework) yerine **ADO.NET** kullanılmıştır
- Aşağıdaki konuları öğrenmek için uygundur:
  - ASP.NET Web Forms yaşam döngüsü
  - SQL Server bağlantıları
  - Sayfa tabanlı web uygulama yapısı

---

## 👩‍💻 Geliştirici

**Melike Acar**  
Software & AI Enthusiast
