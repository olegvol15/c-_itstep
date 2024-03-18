//using System;

//public class GenericStorage<T>
//{
//    private T[] items;

//    public GenericStorage()
//    {
//        items = new T[0];
//    }

//    public void Add(T item)
//    {
//        T[] newItems = new T[items.Length + 1];
//        items.CopyTo(newItems, 0);
//        newItems[items.Length] = item;
//        items = newItems;
//    }

//    public void RemoveAt(int index)
//    {
//        if (index < 0 || index >= items.Length)
//        {
//            throw new IndexOutOfRangeException();
//        }

//        T[] newItems = new T[items.Length - 1];
//        for (int i = 0, j = 0; i < items.Length; i++)
//        {
//            if (i != index)
//            {
//                newItems[j++] = items[i];
//            }
//        }
//        items = newItems;
//    }

//    public T Get(int index)
//    {
//        if (index < 0 || index >= items.Length)
//        {
//            throw new IndexOutOfRangeException();
//        }

//        return items[index];
//    }

//    public int Length()
//    {
//        return items.Length;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var storage = new GenericStorage<int>();
//        storage.Add(1);
//        storage.Add(2);
//        storage.Add(3);

//        Console.WriteLine($"Element at index 1: {storage.Get(1)}");
//        storage.RemoveAt(2);
//        Console.WriteLine($"Length after removal: {storage.Length()}");
//        Console.ReadLine();
//    }
//}

