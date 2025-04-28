# MyBlog - ASP.NET Core 4 Katmanlı Blog Projesi

Bu proje, ASP.NET Core ile geliştirilmiş dört katmanlı (Entity, DataAccess, Business, Presentation) mimari yapıya sahip bir blog uygulamasıdır. 
Kullanıcıların blog yazıları ekleyebildiği, kategorilerle içerikleri organize edebildiği ve yorum yapabildiği bir sistem oluşturulmuştur.

## Kullanılan Teknolojiler

- ASP.NET Core MVC
- Entity Framework Core
- Microsoft SQL Server
- Identity Framework (Kullanıcı yönetimi için)
- Katmanlı Mimari Yapı

## Katmanlar

- **Entity Layer**: Veritabanı tablolarına karşılık gelen sınıflar bulunur (Category, Article, Comment, AppUser, vb.).
- **Data Access Layer (DAL)**: Entity Framework ile veri işlemleri (CRUD) yapılır. Repository deseni uygulanmıştır.
- **Business Layer**: İş kurallarının ve servislerin yönetildiği katmandır.
- **Presentation Layer**: Kullanıcı arayüzünün oluşturulduğu ASP.NET Core MVC katmanıdır.

## Proje Özellikleri

- Kullanıcı kayıt ve giriş işlemleri (Identity kullanılarak)
- Blog yazısı oluşturma, listeleme ve düzenleme
- Blog yazılarına kategori atama
- Bloglara yorum yapma ve yorumları yönetme
- Sosyal medya ikonları ekleyerek profil kişiselleştirme
- Yetkilendirme ve kimlik doğrulama mekanizmaları
