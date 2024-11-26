using System;

public class Otopark
{
    private string[,] parkYerleri; // Kat ve park yerleri

    public Otopark(int katSayisi, int parkYeriSayisi)
    {
        parkYerleri = new string[katSayisi, parkYeriSayisi];
        // Tüm park yerlerini başlangıçta "Empty" yapalım
        for (int i = 0; i < katSayisi; i++)
        {
            for (int j = 0; j < parkYeriSayisi; j++)
            {
                parkYerleri[i, j] = "Empty";
            }
        }
    }

    // İndeksleme operatörü ile park yerine erişim
    public string this[int kat, int parkYeri]
    {
        get
        {
            if (kat >= 0 && kat < parkYerleri.GetLength(0) && parkYeri >= 0 && parkYeri < parkYerleri.GetLength(1))
            {
                return parkYerleri[kat, parkYeri];
            }
            else
            {
                return "Hata: Geçersiz park yeri!";
            }
        }
        set
        {
            if (kat >= 0 && kat < parkYerleri.GetLength(0) && parkYeri >= 0 && parkYeri < parkYerleri.GetLength(1))
            {
                parkYerleri[kat, parkYeri] = value;
            }
            else
            {
                Console.WriteLine("Hata: Geçersiz park yeri!");
            }
        }
    }

    // Otopark durumunu yazdırma
    public void OtoparkDurumu()
    {
        for (int i = 0; i < parkYerleri.GetLength(0); i++)
        {
            Console.WriteLine($"Kat {i + 1}:");
            for (int j = 0; j < parkYerleri.GetLength(1); j++)
            {
                Console.WriteLine($"  Park Yeri {j + 1}: {parkYerleri[i, j]}");
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Otopark otopark = new Otopark(3, 5); // 3 katlı, her katta 5 park yeri

        // Araç ekleme
        otopark[0, 0] = "34ABC123"; // 1. katta 1. park yerine araç koy
        otopark[1, 2] = "06XYZ456"; // 2. katta 3. park yerine araç koy
        otopark[2, 4] = "35LMN789"; // 3. katta 5. park yerine araç koy

        // Otopark durumu yazdırma
        otopark.OtoparkDurumu();

        // Boş bir park yerini sorgulama
        Console.WriteLine(otopark[0, 3]); // 1. kat 4. park yeri ("Empty")

        // Geçersiz park yeri erişimi
        Console.WriteLine(otopark[3, 1]); // Hata mesajı
    }
}