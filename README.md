# Fabrika Çalışan Memnuniyeti Anketi

# 🏭 Staj Projesi: Fabrika Çalışan Memnuniyeti Anket Sistemi Veritabanı Şeması

Bu depo, staj sürem boyunca **imalat/üretim sektörüne yönelik** hazırladığım ve **Fabrika Çalışan Memnuniyeti** süreçlerini yönetmek için tasarlanan uygulamanın temel veritabanı yapısını (DDL) içermektedir.

Proje, fabrika personelinin (mavi yaka, beyaz yaka) memnuniyet düzeylerini, departmanlar (örneğin Üretim, Kalite Kontrol, Lojistik) ve demografik gruplar bazında izlemeyi ve analiz etmeyi sağlayan güçlü bir SQL altyapısı sunmaktadır.

💾 **Veritabanı Motoru:** Microsoft SQL Server
🛠️ **Proje Odak Noktası:** Fabrika ortamında çalışanların katılımı, çalışma koşulları ve iç iletişim memnuniyetini ölçmek.

---

## 🇹🇷 Türkçe Açıklama: Fabrika Memnuniyet Anketi Şeması

### Veritabanı Yapısı ve Ana Fonksiyonlar

Bu şema, **Personel Takibi**, **Anket Sorularının Yönetimi** ve **Detaylı Cevap Analizi** olmak üzere üç ana fonksiyonu destekleyen 5 tablodan oluşur. Özellikle `Kisi` ve `Secim` tabloları, departman ve statü bazında kritik analizler yapmaya olanak tanır.

| Tablo Adı | Fabrika Bağlamında Açıklama | Anahtar Bilgi |
| :--- | :--- | :--- |
| **Soru** | İş güvenliği, çalışma ortamı, yönetim ve yan haklar gibi memnuniyet anketinin temel sorularını tutar. | `Id` (PK) |
| **Personel** | Fabrika çalışanlarının sicil numarası ve kimlik bilgilerini içerir. (Örn: Sicil No ile Fabrika Giriş Kartı Entegrasyonu) | `SicilNo`, `AdSoyad` |
| **Kisi** | Personelin anket anındaki demografik kırılımları (Cinsiyet, Yaş, **Statü** (Mavi/Beyaz Yaka), **Departman**) tutar. | `SiciIid`, `DepartmanAdi` |
| **Secim** | Personelin belirli bir soruya verdiği cevapları zaman, soru ve departman bazında kaydeder. Memnuniyet skorlarının temelini oluşturur. | `Sicilid`, `SoruId`, `Cevap` |
| **AnketLog** | Ankete başarıyla giriş yapan veya tamamlayan personelin kayıtlarını tarih ve sicil bazında tutar. (Katılım oranlarını hesaplamak için kullanılır). | `GirisTarihi`, `SicilId` |

**Önemli Sorgulama Senaryoları:**
* **Departman Performansı:** `Secim` ve `Kisi` tabloları birleştirilerek 'Üretim' departmanının memnuniyet ortalaması, 'Lojistik' departmanından ne kadar farklı hesaplanabilir.
* **Katılım Oranları:** `AnketLog` ve `Personel` tabloları kullanılarak toplam personel sayısına göre aylık/yıllık katılım yüzdesi kolayca hesaplanabilir.

---

## 🇬🇧 English Description: Factory Employee Satisfaction Survey Schema

### Database Schema for Factory Employee Satisfaction Survey System

This repository contains the core database structure (DDL) for the application I designed during my internship, specifically tailored for **managing Employee Satisfaction processes within the manufacturing/production sector.**

The project offers a robust SQL infrastructure to monitor and analyze the satisfaction levels of factory personnel (blue-collar, white-collar) across various departments (e.g., Production, Quality Control, Logistics) and demographic groups.

💾 **Database Engine:** Microsoft SQL Server
🛠️ **Project Focus:** Measuring employee satisfaction regarding working conditions, internal communication, and participation in a factory environment.

### Database Structure and Key Functions

This schema consists of 5 tables supporting three main functions: **Personnel Tracking**, **Survey Question Management**, and **Detailed Response Analysis**. The `Kisi` and `Secim` tables, in particular, allow for critical analysis based on department and employment status.

| Table Name | Description in Factory Context | Key Information |
| :--- | :--- | :--- |
| **Soru** (`Question`) | Stores core satisfaction questions related to topics like safety, working environment, management, and benefits. | `Id` (PK) |
| **Personel** (`Personnel`) | Contains the factory employees' registration numbers and identity details. (E.g., Integration with Factory Access Control via Personnel ID). | `SicilNo`, `AdSoyad` |
| **Kisi** (`Person`) | Stores the personnel's demographic breakdown at the time of the survey (Gender, Age, **Status** (Blue/White Collar), **Department**). | `SiciIid`, `DepartmanAdi` |
| **Secim** (`Selection`) | Records the answers given to specific questions, logged by time, question, and department. This forms the basis for satisfaction scores. | `Sicilid`, `SoruId`, `Cevap` |
| **AnketLog** (`SurveyLog`) | Stores records of personnel who successfully entered or completed the survey, logged by date and personnel ID (Used to calculate participation rates). | `GirisTarihi`, `SicilId` |

**Key Query Scenarios:**
* **Departmental Performance:** By joining `Secim` and `Kisi` tables, you can calculate how much the average satisfaction of the 'Production' department differs from the 'Logistics' department.
* **Participation Rates:** The monthly/annual percentage of participation can be easily calculated using the `AnketLog` and `Personel` tables relative to the total number of employees.

