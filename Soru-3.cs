using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date1 = new DateTime(2020, 5, 15);
        DateTime date2 = new DateTime(2023, 11, 24);

        // Gün cinsinden fark
        int dayDifference = CalculateDateDifference(date1, date2);
        Console.WriteLine($"Gün cinsinden fark: {dayDifference}");

        // Saat cinsinden fark
        double hourDifference = CalculateDateDifference(date1, date2, true);
        Console.WriteLine($"Saat cinsinden fark: {hourDifference}");

        // Yıl, ay ve gün cinsinden fark
        (int years, int months, int days) = CalculateDateDifferenceDetailed(date1, date2);
        Console.WriteLine($"Yıl: {years}, Ay: {months}, Gün: {days}");
    }

    // Gün cinsinden farkı hesaplayan metod
    static int CalculateDateDifference(DateTime startDate, DateTime endDate)
    {
        return (endDate - startDate).Days;
    }

    // Saat cinsinden farkı hesaplayan metod
    static double CalculateDateDifference(DateTime startDate, DateTime endDate, bool inHours)
    {
        if (inHours)
        {
            return (endDate - startDate).TotalHours;
        }
        return 0;
    }

    // Yıl, ay ve gün cinsinden farkı hesaplayan metod
    static (int years, int months, int days) CalculateDateDifferenceDetailed(DateTime startDate, DateTime endDate)
    {
        int years = endDate.Year - startDate.Year;
        int months = endDate.Month - startDate.Month;
        int days = endDate.Day - startDate.Day;

        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(endDate.Year, endDate.Month == 1 ? 12 : endDate.Month - 1);
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }

        return (years, months, days);
    }
}

