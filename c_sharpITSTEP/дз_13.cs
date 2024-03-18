//using System;

//public class Deposit
//{
//    public virtual int Id { get; set; }
//    public virtual string Owner { get; set; }
//    public virtual decimal Sum { get; set; }
//    public virtual int Term { get; set; }
//    public virtual decimal Rate { get; set; }
//    public virtual DateTime Date { get; set; }

//    public Deposit(int id, string owner, decimal sum, int term, DateTime date)
//    {
//        Id = id;
//        Owner = owner;
//        Sum = sum >= 10000 && sum <= 200000 ? sum : throw new ArgumentException();
//        Term = term >= 3 && term <= 36 ? term : throw new ArgumentException();
//        Date = date;
//        Rate = CalculateRate(sum, term);
//    }

//    protected virtual decimal CalculateRate(decimal sum, int term)
//    {
//        return (sum / 10000) + (term / 12);
//    }

//    public virtual string GetInfo()
//    {
//        return $"ID: {Id}, Owner: {Owner}, Sum: {Sum}, Term: {Term} months, Rate: {Rate}%, Date: {Date}";
//    }

//    public virtual decimal Close(DateTime closeDate)
//    {
//        int completedMonths = (closeDate.Year - Date.Year) * 12 + closeDate.Month - Date.Month;
//        if (completedMonths <= 0)
//            return 0;
//        return Sum + (Sum * Rate / 100 * completedMonths / 12);
//    }
//}

//public class Credit : Deposit
//{
//    public Credit(int id, string owner, decimal sum, int term, DateTime date)
//        : base(id, owner, sum, term, date)
//    {
//    }

//    protected override decimal CalculateRate(decimal sum, int term)
//    {
//        return (sum / 5000) + (term / 12);
//    }
//}

//public class Program
//{
//    static void Main()
//    { 
//        Deposit deposit = new Deposit(id: 1, owner: "Oleh Volostnykh", sum: 15000, term: 12, date: DateTime.Now);
//        Console.WriteLine(deposit.GetInfo());

        
//        decimal returnedAmount = deposit.Close(DateTime.Now.AddMonths(6)); 
//        Console.WriteLine($"Returned sum: {returnedAmount}");

        
//        Credit credit = new Credit(id: 2, owner: "Korablyov Volodya", sum: 50000, term: 24, date: DateTime.Now);
//        Console.WriteLine(credit.GetInfo());

//        Console.ReadLine();
//    }
//}


