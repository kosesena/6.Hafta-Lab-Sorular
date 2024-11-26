/*
3. Bir Satranç Tahtası Durumu
Bir sınıf oluşturun:
 Satranç tahtasındaki her bir kareyi temsil etsin.

 Kullanıcı, indeksleyici aracılığıyla bir kareye taş koyabilsin ya da taşın ne olduğunu
öğrenebilsin.
 Eğer kullanıcı geçersiz bir kareye erişmeye çalışırsa bir hata mesajı döndürsün.
*/

using System;

public class SatrancTahtasi
{
    private string[,] tahtadakiDurum; // 8x8 satranç tahtası

    public SatrancTahtasi()
    {
        tahtadakiDurum = new string[8, 8];
        // Tüm kareleri başlangıçta "Empty" yapalım
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                tahtadakiDurum[i, j] = "Empty";
            }
        }
    }

    // İndeksleme operatörü ile kareye erişim
    public string this[int satir, int sutun]
    {
        get
        {
            if (satir >= 0 && satir < 8 && sutun >= 0 && sutun < 8)
            {
                return tahtadakiDurum[satir, sutun];
            }
            else
            {
                return "Hata: Geçersiz kare!";
            }
        }
        set
        {
            if (satir >= 0 && satir < 8 && sutun >= 0 && sutun < 8)
            {
                tahtadakiDurum[satir, sutun] = value;
            }
            else
            {
                Console.WriteLine("Hata: Geçersiz kareye taş koyulamaz!");
            }
        }
    }

    // Tahtayı yazdırma
    public void TahtayiYazdir()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write($"{tahtadakiDurum[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SatrancTahtasi tahta = new SatrancTahtasi();

        // Taş koyma
        tahta[0, 0] = "Rook";   // Sağ üst köşeye kale
        tahta[7, 7] = "Queen";  // Sol alt köşeye vezir
        tahta[3, 4] = "Knight"; // Belirli bir kareye at

        // Tahtayı yazdırma
        tahta.TahtayiYazdir();

        // Geçersiz kareye erişim
        Console.WriteLine(tahta[8, 8]); // Hata mesajı
    }
}
