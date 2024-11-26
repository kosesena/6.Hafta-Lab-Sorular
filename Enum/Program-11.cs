using System;

public enum TrafikIsigi
{
    Red,    // Kırmızı ışık
    Yellow, // Sarı ışık
    Green   // Yeşil ışık
}

public class TrafikKontrol
{
    // Trafik ışığına göre aksiyon belirleyen metot
    public string NeYapilmali(TrafikIsigi isik)
    {
        switch (isik)
        {
            case TrafikIsigi.Red:
                return "Durun!";
            case TrafikIsigi.Yellow:
                return "Hazırlanın!";
            case TrafikIsigi.Green:
                return "Geçin!";
            default:
                return "Bilinmeyen trafik ışığı durumu!";
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TrafikKontrol trafikKontrol = new TrafikKontrol();

        // Red ışık için
        Console.WriteLine($"Red ışık: {trafikKontrol.NeYapilmali(TrafikIsigi.Red)}");

        // Yellow ışık için
        Console.WriteLine($"Yellow ışık: {trafikKontrol.NeYapilmali(TrafikIsigi.Yellow)}");

        // Green ışık için
        Console.WriteLine($"Green ışık: {trafikKontrol.NeYapilmali(TrafikIsigi.Green)}");
    }
}