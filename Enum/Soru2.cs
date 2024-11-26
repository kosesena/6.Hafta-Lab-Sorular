/*
2. Hava Durumu Tahmini
Bir enum oluşturun:
 Hava durumu tiplerini (Sunny, Rainy, Cloudy, Stormy) temsil etsin.
 Enum’a göre tavsiye veren bir metot yazın (örneğin, yağmurluysa şemsiye alın).
*/

using System;

public enum HavaDurumu
{
    Sunny,  // Güneşli
    Rainy,  // Yağmurlu
    Cloudy, // Bulutlu
    Stormy  // Fırtınalı
}

public class HavaTahmini
{
    // Hava durumuna göre tavsiye veren metot
    public string Tavsiye(HavaDurumu durum)
    {
        switch (durum)
        {
            case HavaDurumu.Sunny:
                return "Hava güneşli, güneş gözlüğü takmayı unutmayın!";
            case HavaDurumu.Rainy:
                return "Hava yağmurlu, yanınıza bir şemsiye alın!";
            case HavaDurumu.Cloudy:
                return "Hava bulutlu, hafif bir ceket giyebilirsiniz.";
            case HavaDurumu.Stormy:
                return "Hava fırtınalı, evde kalmanız tavsiye edilir!";
            default:
                return "Bilinmeyen hava durumu!";
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HavaTahmini havaTahmini = new HavaTahmini();

        // Hava durumları için tavsiye al
        Console.WriteLine($"Sunny: {havaTahmini.Tavsiye(HavaDurumu.Sunny)}");
        Console.WriteLine($"Rainy: {havaTahmini.Tavsiye(HavaDurumu.Rainy)}");
        Console.WriteLine($"Cloudy: {havaTahmini.Tavsiye(HavaDurumu.Cloudy)}");
        Console.WriteLine($"Stormy: {havaTahmini.Tavsiye(HavaDurumu.Stormy)}");
    }
}
