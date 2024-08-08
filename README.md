# PatikaWeek4PracticeAbstraction

## Proje Açıklaması

Bu proje, C# dilinde soyut sınıflar ve kalıtım kullanarak bir işçi yönetim sistemi örneği sağlar. `BaseWorker` adında bir soyut sınıf ve `Worker` adında bir türetilmiş sınıf içerir. `Worker` sınıfı, işçilerin bilgilerini depolar ve bu bilgileri ekrana yazdırır.

## Kullanılan Teknolojiler

- C#
- .NET Core (veya .NET Framework)

## Sınıflar

### `BaseWorker`

- **Açıklama**: Soyut bir temel sınıftır.
- **Özellikler**:
  - `Name` (string): İşçinin adı.
  - `Surname` (string): İşçinin soyadı.
  - `Department` (string): İşçinin çalıştığı departman.
  - `Position` (string): İşçinin pozisyonu.
- **Metodlar**:
  - `Gorev()`: Türetilmiş sınıflar tarafından uygulanması gereken soyut metod.

### `Worker`

- **Açıklama**: `BaseWorker` sınıfından türetilmiş bir sınıftır.
- **Konstruktorlar**:
  - Varsayılan konstruktor
  - Parametreli konstruktor: `Name`, `Surname`, `Department`, ve `Position` bilgilerini alır.
- **Metodlar**:
  - `Gorev()`: İşçinin bilgilerini ekrana yazdırır.

## Kullanım

### Kod Örneği

```csharp
using System;
using PatikaWeek4PracticeAbstraction;

class Program
{
    static void Main()
    {
        // Parametreli konstruktor ile Worker örneği oluşturma
        BaseWorker worker1 = new Worker("Bilal", "Bilin", "Proje Geliştirme", "Geliştirici");

        // worker1'in Gorev metodunu çağırma
        worker1.Gorev();

        // Varsayılan konstruktor ile Worker örneği oluşturma
        Worker worker2 = new Worker();
        worker2.Name = "Mikail";
        worker2.Surname = "Aslan";
        worker2.Department = "Kültür ve Sanat";
        worker2.Position = "Besteci";

        // worker2'nin Gorev metodunu çağırma
        worker2.Gorev();
    }
}
