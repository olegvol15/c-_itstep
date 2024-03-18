//using System;

//public class Processor
//{
//    public string Model { get; set; }
//    public double Frequency { get; set; } 

//    public Processor(string model, double frequency)
//    {
//        Model = model;
//        Frequency = frequency;
//    }
//}

//public class Motherboard
//{
//    public Processor CPU { get; set; }
//    private int _ram;

//    public int RAM
//    {
//        get { return _ram; }
//        set
//        {
//            if (value <= 0 || value > 1024)
//            {
//                throw new ArgumentException("Invalid RAM capacity. Must be between 1 and 1024 GB.");
//            }
//            _ram = value;
//        }
//    }

//    public Motherboard(Processor cpu, int ram)
//    {
//        CPU = cpu;
//        RAM = ram;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            Processor cpu = new Processor("Intel Core i7", 3.5);
//            Motherboard motherboard = new Motherboard(cpu, 16);

//            Console.WriteLine($"Processor: {motherboard.CPU.Model}, Frequency: {motherboard.CPU.Frequency} GHz");
//            Console.WriteLine($"RAM: {motherboard.RAM} GB");
//            Console.ReadLine();

//            motherboard.RAM = 1000;
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//            Console.ReadLine();
//        }
//    }
//}


//доп задача

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 

//        Console.WriteLine("Enter two numbers between 1 and 10 to sum their corresponding elements in the array:");

//        try
//        {
//            int index1 = Convert.ToInt32(Console.ReadLine()) - 1; 
//            int index2 = Convert.ToInt32(Console.ReadLine()) - 1; 

//            if (index1 >= 0 && index1 < numbers.Length && index2 >= 0 && index2 < numbers.Length)
//            {
//                int sum = numbers[index1] + numbers[index2];
//                Console.WriteLine($"The sum of elements {index1 + 1} and {index2 + 1} is: {sum}");
//            }
//            else
//            {
//                Console.WriteLine("One or both numbers are out of the array's range.");
//            }
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Please enter valid numbers.");
//        }
//        catch (OverflowException)
//        {
//            Console.WriteLine("The numbers are too large.");
//        }
//        Console.ReadLine();
//    }
//}
