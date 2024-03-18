//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            int a = 10;
//            int b = 0;
//            int result = a / b;
//        }
//        catch (DivideByZeroException)
//        {
//            Console.WriteLine("Делить на ноль нельзя!");
//            Console.ReadLine();
//        }
//    }
//}



//using System;

//namespace DelegateExample
//{
//    class Program
//    {
//        delegate void GreetingDelegate(string message);

//        static void Hi(string message)
//        {
//            Console.WriteLine(message);
//        }

//        static void Main(string[] args)
//        {
//            GreetingDelegate hiDelegate = Hi;
//            hiDelegate("Привет");

//            Console.ReadLine();
//        }
//    }
//}



//using System;

//namespace UserManagement
//{
//    class User
//    {
//        public string name { get; set; }
//        public string surname { get; set; }
//        public string email { get; set; }
//        public int age { get; set; }
//        public string city { get; set; }

//        public override string ToString()
//        {
//            return $"Name: {name} {surname}, Email: {email}, Age: {age}, City: {city}";
//        }
//    }

//    delegate User UserDelegate();

//    class Program
//    {
//        static User CreateUser()
//        {
//            User user = new User
//            {
//                name = "Oleg",
//                surname = "Volostnykh",
//                email = "oleg.volostnykh@gmail.com.com",
//                age = 17,
//                city = "Wroclaw"
//            };

//            return user;
//        }

//        static void Main(string[] args)
//        {
//            UserDelegate userData = CreateUser;

//            User[] users = new User[1];
//            users[0] = userData();

//            Console.WriteLine(users[0]);
//            Console.ReadLine();
//        }
//    }
//}


//using System;
//using System.Linq;

//class Program
//{
//    delegate void ArrayOperation(int[] array);

//    static void Main()
//    {
//        int[] array = new int[30];
//        Random random = new Random();
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = random.Next(-10, 11); // Заполняем массив случайными числами для наглядности
//        }

//        ArrayOperation operation = PrintOriginalArray;
//        operation += SortAndPrintAscending;
//        operation += SortAndPrintDescending;
//        operation += PrintEvenNumbers;
//        operation += PrintOddNumbers;

//        operation(array);
//        Console.ReadLine();
//    }

//    static void PrintOriginalArray(int[] array)
//    {
//        Console.WriteLine("Исходный массив:");
//        PrintArray(array);
//    }

//    static void SortAndPrintAscending(int[] array)
//    {
//        var sortedArray = array.OrderBy(x => x).ToArray();
//        Console.WriteLine("Отсортированный массив в большую сторону:");
//        PrintArray(sortedArray);
//    }

//    static void SortAndPrintDescending(int[] array)
//    {
//        var sortedArray = array.OrderByDescending(x => x).ToArray();
//        Console.WriteLine("Отсортированный массив в меньшую сторону:");
//        PrintArray(sortedArray);
//    }

//    static void PrintEvenNumbers(int[] array)
//    {
//        var evenArray = array.Where(x => x % 2 == 0).ToArray();
//        Console.WriteLine("Четный массив:");
//        PrintArray(evenArray);
//    }

//    static void PrintOddNumbers(int[] array)
//    {
//        var oddArray = array.Where(x => x % 2 != 0).ToArray();
//        Console.WriteLine("Нечетный массив:");
//        PrintArray(oddArray);
//    }

//    static void PrintArray(int[] array)
//    {
//        foreach (int number in array)
//        {
//            Console.Write(number + "\t");
//        }
//        Console.WriteLine("\n");
//    }

//}


//using System;

//class Program
//{
//    delegate int SquareDelegate(int number);

//    static void Main()
//    {
//        SquareDelegate square = number => number * number;

//        int value = 4;
//        int squaredValue = square(value);

//        Console.WriteLine(squaredValue);
//    }
//}

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Predicate<string> stringVal = Length;

//        bool result = stringVal("Volostnykh");
//        Console.WriteLine(result);

//        result = stringVal("oleh");
//        Console.WriteLine(result);
//        Console.ReadLine();
//    }

//    public static bool Length(string input)
//    {
//        return input.Length >= 7;
//    }
//}

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Func<int, int, int, int, int> sumFunction = (a, b, c, d) => a + b + c + d;
//        int sum = sumFunction(2, 2, 5, 4);
//        Console.WriteLine($"Sum: {sum}");
//        Console.ReadLine();
//    }
//}

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        int[] array = { 8, 4, 7, 3, 1, 9, 2 };
//        Action<int[]> sortArray = (arr) => Array.Sort(arr);
//        sortArray(array);

//        Console.WriteLine("Sorted array:");
//        foreach (int element in array)
//        {
//            Console.Write(element + " ");
//        }
//    }
//}
