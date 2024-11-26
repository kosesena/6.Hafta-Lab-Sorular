/*
3. Çalışan Rolleri ve Maaş Hesaplama
Bir enum oluşturun:
 Çalışan rolleri (Manager, Developer, Designer, Tester) için maaşları belirlemek üzere.
 Enum’a göre maaşı hesaplayan bir metot yazın.
*/

using System;

public enum CalisanRol
{
    Manager,   // Yönetici
    Developer, // Yazılımcı
    Designer,  // Tasarımcı
    Tester     // Test Uzmanı
}

public class MaasHesaplama
{
    // Çalışan rolüne göre maaş döndüren metot
    public int MaasHesapla(CalisanRol rol)
    {
        switch (rol)
        {
            case CalisanRol.Manager:
                return 15000; // Yönetici maaşı
            case CalisanRol.Developer:
                return 12000; // Yazılımcı maaşı
            case CalisanRol.Designer:
                return 10000; // Tasarımcı maaşı
            case CalisanRol.Tester:
                return 9000;  // Test Uzmanı maaşı
            default:
                return 0; // Bilinmeyen rol için 0 maaş
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MaasHesaplama maasHesaplama = new MaasHesaplama();

        // Çalışan rolleri için maaş hesapla
        Console.WriteLine($"Manager maaşı: {maasHesaplama.MaasHesapla(CalisanRol.Manager)} TL");
        Console.WriteLine($"Developer maaşı: {maasHesaplama.MaasHesapla(CalisanRol.Developer)} TL");
        Console.WriteLine($"Designer maaşı: {maasHesaplama.MaasHesapla(CalisanRol.Designer)} TL");
        Console.WriteLine($"Tester maaşı: {maasHesaplama.MaasHesapla(CalisanRol.Tester)} TL");
    }
}
