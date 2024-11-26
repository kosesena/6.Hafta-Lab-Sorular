/*
3. GPS Konum Mesafesi
Bir struct oluşturun:
 Enlem ve boylam (Latitude ve Longitude) bilgilerini tutsun.
 İki GPS konumu arasındaki mesafeyi kilometre olarak hesaplayan bir metot ekleyin (Haversine Formülü).
*/

using System;

public struct GPSKonum
{
    public double Latitude { get; set; }  // Enlem
    public double Longitude { get; set; } // Boylam

    // Yapıcı (constructor) metot
    public GPSKonum(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    // İki GPS noktası arasındaki mesafeyi kilometre olarak hesapla (Haversine Formülü)
    public double MesafeHesapla(GPSKonum diger)
    {
        const double YariCap = 6371; // Dünya yarıçapı (kilometre)
        double radianLat1 = ToRadians(this.Latitude);
        double radianLat2 = ToRadians(diger.Latitude);
        double farkLat = ToRadians(diger.Latitude - this.Latitude);
        double farkLon = ToRadians(diger.Longitude - this.Longitude);

        double a = Math.Sin(farkLat / 2) * Math.Sin(farkLat / 2) +
                   Math.Cos(radianLat1) * Math.Cos(radianLat2) *
                   Math.Sin(farkLon / 2) * Math.Sin(farkLon / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return YariCap * c; // Mesafe kilometre olarak
    }

    // Dereceyi radyana çeviren yardımcı metot
    private static double ToRadians(double derece)
    {
        return derece * (Math.PI / 180);
    }

    public override string ToString()
    {
        return $"Latitude: {Latitude}, Longitude: {Longitude}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // GPS konumları oluştur
        GPSKonum konum1 = new GPSKonum(41.0082, 28.9784); // İstanbul
        GPSKonum konum2 = new GPSKonum(39.9208, 32.8541); // Ankara

        // Mesafeyi hesapla
        double mesafe = konum1.MesafeHesapla(konum2);
        Console.WriteLine($"Mesafe: {mesafe:F2} km");
    }
}
