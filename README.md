# Hayvanat Bahçesi Yönetim Sistemi 🦁

Bu proje, C# ve Windows Forms kullanılarak geliştirilmiş nesne yönelimli (OOP) bir hayvanat bahçesi yönetim ve takip sistemidir. Sistem, yönetici ve ziyaretçi olmak üzere iki farklı kullanıcı tipi için özelleştirilmiş ekranlar sunar. 

## 🚀 Öne Çıkan Özellikler

* **Rol Bazlı Erişim:** Admin paneli ve Ziyaretçi bilgilendirme ekranı olmak üzere iki farklı arayüz.
* **Polimorfizm (Çok Biçimlilik):** Ziyaretçi ekranında saat bilgisine göre hayvanların dinamik davranış (Dolaşıyor, Besleniyor, Dinleniyor) göstermesi.
* **İlişkisel Veritabanı:** MSSQL kullanılarak hayvan türleri, sağlık durumları ve muayene kayıtlarının `JOIN` işlemleriyle entegre biçimde yönetilmesi.
* **Dinamik UI:** Arayüz elemanlarının kod üzerinden merkezi bir "Temalar" sınıfı ile yönetilmesi.

## 🛠️ Kullanılan Teknolojiler

* **Programlama Dili:** C# (.NET Framework 4.8)
* **Veritabanı:** Microsoft SQL Server (LocalDB)
* **Veri Erişimi:** ADO.NET (SqlDataAdapter, SqlCommand)
* **Kavramlar:** Nesne Yönelimli Programlama (Kalıtım, Çok Biçimlilik), İlişkisel Veritabanı Yönetimi

## 📌 Modüller

1. **Admin Paneli:** Yöneticilerin hayvanların dolaşma saatlerini, beslenme vakitlerini ve güncel sağlık durumlarını güncelleyebildiği yönetim modülü.
2. **Ziyaretçi Paneli:** Ziyaretçilerin ad/soyad ve saat bilgisi girerek o an hayvanların hangi aktiviteyi (beslenme/dinlenme/dolaşma) yaptığını anlık olarak listeleyebildiği ekran.
