using System;

public class Item
{
    public string Name { get; set; }
    public int Level { get; set; }
    public double Value { get; set; }
    public double Weight { get; set; }

    public Item(string name, int level, double value, double weight)
    {
        Name = name;
        Level = level;
        Value = value;
        Weight = weight;
    }
}


public class Player
{
    public string Name { get; set; }
    public List<Item> Inventory { get; set; }

    public Player(string name)
    {
        Name = name;
        Inventory = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void RemoveItem(Item item)
    {
        Inventory.Remove(item);
    }

    public double GetTotalWeight()
    {
        return Inventory.Sum(item => item.Weight);
    }

    public double GetTotalValue()
    {
        return Inventory.Sum(item => item.Value);
    }

    public List<Item> FindItems(int? level = null, double? value = null)
    {
        return Inventory.Where(item =>
               (!level.HasValue || item.Level == level.Value) &&
               (!value.HasValue || item.Value == value.Value))
               .ToList();
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player("Hero");

        player.AddItem(new Item("Sword", 5, 150.0, 3.0));
        player.AddItem(new Item("Shield", 4, 100.0, 5.0));
        player.AddItem(new Item("Potion", 1, 50.0, 0.5));

        Console.WriteLine($"Total weight: {player.GetTotalWeight()} kg");
        Console.WriteLine($"Total value: {player.GetTotalValue()} gold");

        var itemToRemove = player.Inventory[0];
        player.RemoveItem(itemToRemove);

        var foundItems = player.FindItems(level: 1);
        Console.WriteLine("Items of level 1:");
        foreach (var item in foundItems)
        {
            Console.WriteLine($"{item.Name} - Level: {item.Level}, Value: {item.Value}, Weight: {item.Weight}");
        }

        foundItems = player.FindItems(value: 100.0);
        Console.WriteLine("Items with value 100.0 gold:");
        foreach (var item in foundItems)
        {
            Console.WriteLine($"{item.Name} - Level: {item.Level}, Value: {item.Value}, Weight: {item.Weight}");
        }
        Console.ReadLine();
    }
}

