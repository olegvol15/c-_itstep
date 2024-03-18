//using System;

//public class String
//{
//    private char[] characters;

//    public String(string str)
//    {
//        characters = str.ToCharArray();
//    }

//    public String(int length)
//    {
//        characters = new char[length];
//    }

//    public String(String other, int n)
//    {
//        characters = new char[n];
//        for (int i = 0; i < n && i < other.characters.Length; i++)
//        {
//            characters[i] = other.characters[i];
//        }
//    }

//    public char this[int index]
//    {
//        get { return characters[index]; }
//        set { characters[index] = value; }
//    }

//    public int Length
//    {
//        get { return characters.Length; }
//    }

//    public override string ToString()
//    {
//        return new string(characters);
//    }

//    static void Main()
//    {
//        String str = new String("Hello world");
//        Console.WriteLine($"String: {str}. Length: {str.Length}");
//        String str2 = new String(str, 6);
//        Console.WriteLine($"String: {str2}. Length: {str2.Length}");
//        String str3 = new String(10);
//        Console.WriteLine($"String: {str3}. Length: {str3.Length}");

//        Console.ReadLine();
//    }
//}


