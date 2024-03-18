//using System;

//public struct Birthday
//{
//    public DateTime DateOfBirth { get; private set; }

//    public void SetDateOfBirth(int year, int month, int day)
//    {
//        this.DateOfBirth = new DateTime(year, month, day);
//    }

//    public string GetDayOfWeekOfBirth()
//    {
//        return DateOfBirth.DayOfWeek.ToString();
//    }

//    public string GetDayOfWeekInYear(int year)
//    {
//        DateTime specifiedYearBirthday = new DateTime(year, DateOfBirth.Month, DateOfBirth.Day);
//        return specifiedYearBirthday.DayOfWeek.ToString();
//    }

//    public int GetDaysUntilNextBirthday()
//    {
//        DateTime today = DateTime.Today;
//        DateTime nextBirthday = new DateTime(today.Year, DateOfBirth.Month, DateOfBirth.Day);
//        if (nextBirthday < today)
//        {
//            nextBirthday = nextBirthday.AddYears(1);
//        }
//        return (nextBirthday - today).Days;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Birthday myBirthday = new Birthday();
//        myBirthday.SetDateOfBirth(2006, 4, 9); 

//        Console.WriteLine($"День недели рождения: {myBirthday.GetDayOfWeekOfBirth()}");

//        int year = 2025;
//        Console.WriteLine($"День недели дня рождения в {year} году: {myBirthday.GetDayOfWeekInYear(year)}");

//        Console.WriteLine($"Дней до следующего дня рождения: {myBirthday.GetDaysUntilNextBirthday()}");

//        Console.ReadLine();
//    }
//}


