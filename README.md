# 🌍 Tatil & Seyahat Blog Projesi

**Tatil Seyahat Projesi**, ASP.NET MVC 5 ile geliştirilmiş, turizm temalı bir web uygulamasıdır. Blog içerikleri, otel önerileri ve etkinlik planları üzerinden kullanıcıya bilgi sunar. Veritabanı olarak SQL Server kullanılmış olup, Entity Framework üzerinden Code First yaklaşımı ile ilişkilendirilmiştir. Proje boyunca dört farklı template kullanılmışltır: Ana sayfa, blog sayfası, login ve admin.

---

## 📌 Proje Özellikleri

- 📝 Blog modülü (ülke/şehir bazlı seyahat yazıları)
- 🏨 Bloglara bağlı otel önerileri (başlık, açıklama, görsel)
- 📅 Tarih, lokasyon ve görsel içeren etkinlik listesi
- 🔍 LINQ ile veritabanından dinamik veri çekme
- 🎨 Bootstrap ve Font Awesome ile responsive kullanıcı arayüzü
- 💬 Blog detaylarında yorum ekleme / görüntüleme
- 🗃️ MVC pattern yapısına uygun katmanlı mimari

---

## 🛠️ Kullanılan Teknolojiler

| Katman       | Teknoloji               |
|--------------|--------------------------|
| Backend      | ASP.NET MVC 5            |
| ORM          | Entity Framework 6       |
| Veritabanı   | SQL Server Express (.mdf)|
| Frontend     | HTML5, CSS3, Bootstrap 3 |
| View Engine  | Razor                    |
| İkonlar      | Font Awesome             |

---

## 🛠️ Kurulum Talimatları

### 1. Repoyu Klonlayın

```bash
git clone https://github.com/kullaniciadiniz/TravelTripProje.git

##  2. Visual Studio ile Açın

- `TravelTripProje.sln` dosyasını **Visual Studio** ile açın.  
- Gerekirse NuGet bağımlılıklarını yükleyin:  
  `Tools > NuGet Package Manager > Manage NuGet Packages for Solution`

---

##  3. Veritabanı Ayarları

`Web.config` dosyasında aşağıdaki `<connectionStrings>` bölümünü kendi SQL Server bilgisayar adınıza göre güncelleyin:

```xml
<connectionStrings>
  <add name="Context" 
       connectionString="Data Source=.; Initial Catalog=TravelDb; Integrated Security=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>

## 🧩 Entity Relationship (ER) Diagram

![ER Diagram](docs/er_diagram.png)

