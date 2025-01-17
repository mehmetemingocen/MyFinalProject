# Katmanlı Mimari

Bu proje, modern bir yazılım geliştirme uygulamasını hayata geçirmek için tasarlanmış bir **Katmanlı Mimari** örneğidir. Proje, **C# ve .NET Core** teknolojilerini kullanarak iş mantığı, veri erişimi ve API entegrasyonu gibi konularda temel yetenekler sunmaktadır.

## Proje Yapısı

Proje aşağıdaki ana katmanlardan oluşmaktadır:

### 1. **Business**
- İş mantığının yazıldığı katmandır.
- `CheckIfProductCountOfCategoryCorrect` gibi iş kuralları burada bulunur.

### 2. **Core**
- Ortak kullanılabilir kodların yazıldığı bir altyapı katmanıdır.
- Güvenlik (`Security`) ve diğer temel bileşenleri içerir.

### 3. **DataAccess**
- Veritabanı erişim işlemlerini içerir.
- CRUD işlemleri ve sorgular bu katmanda yer alır.

### 4. **Entities**
- Projede kullanılan varlık sınıflarını tanımlar.
- Örneğin: Ürünler, kategoriler gibi temel nesneleri içerir.

### 5. **WebAPI**
- RESTful API servislerinin yazıldığı katmandır.
- Örnek: `TokenOptions` yapılandırması ve ilgili uç noktalar.

### 6. **ConsoleUI**
- Konsol tabanlı bir kullanıcı arayüzü sağlar.

## Kullanılan Teknolojiler

- **C#**
- **.NET Core**
- **Katmanlı Mimari**
- **Entity Framework Core**
