//public class Machines
//{
//    public virtual string Name { get; set; }

//    public Machines(string name)
//    {
//        Name = name;
//    }

//    public virtual string Describe()
//    {
//        return $"Это машина: {Name}.";
//    }
//}

//public class Aircraft : Machines
//{
//    public override string Name
//    {
//        get { return base.Name; }
//        set { base.Name = "Авиасредство: " + value; }
//    }

//    public Aircraft(string name) : base(name)
//    {
//    }

//    public override string Describe()
//    {
//        return base.Describe() + " Это авиасредство.";
//    }
//}

//public class Truck : Machines
//{
//    public Truck(string name) : base(name)
//    {
//        Name = "Грузовик: " + name;
//    }

//    public override string Describe()
//    {
//        return base.Describe() + " Это грузовик.";
//    }
//}

//public class Helicopter : Aircraft
//{
//    public Helicopter(string name) : base(name)
//    {
//        Name = "Вертолет: " + name;
//    }

//    public override string Describe()
//    {
//        return base.Describe() + " Это вертолет.";
//    }
//}

//public class Fighter : Aircraft
//{
//    public Fighter(string name) : base(name)
//    {
//        Name = "Истребитель: " + name;
//    }

//    public override string Describe()
//    {
//        return base.Describe() + " Это истребитель.";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Machines truck = new Truck("МАЗ");
//        Machines helicopter = new Helicopter("Ми-8");
//        Machines fighter = new Fighter("Су-27");

//        Console.WriteLine(truck.Describe());
//        Console.WriteLine(helicopter.Describe());
//        Console.WriteLine(fighter.Describe());

//        Console.ReadLine();
//    }
//}


