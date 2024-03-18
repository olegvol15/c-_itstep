//using System;
//using System.Linq;

//public class Item
//{
//    public string Name { get; set; }
//    public int Level { get; set; }
//    public decimal Value { get; set; }
//    public float Weight { get; set; }

//    public Item(string name, int level, decimal value, float weight)
//    {
//        Name = name;
//        Level = level;
//        Value = value;
//        Weight = weight;
//    }
//}

//public class Player
//{
//    public string Name { get; set; }
//    private Item[] inventory;
//    private int itemCount;

//    public Player(string name)
//    {
//        Name = name;
//        inventory = new Item[10];
//        itemCount = 0;
//    }

//    public void AddItem(Item item)
//    {
//        if (itemCount == inventory.Length)
//        {
//            IncreaseInventorySize();
//        }
//        inventory[itemCount++] = item;
//    }

//    private void IncreaseInventorySize()
//    {
//        var newSize = inventory.Length * 2;
//        var newInventory = new Item[newSize];
//        Array.Copy(inventory, newInventory, inventory.Length);
//        inventory = newInventory;
//    }

//    public bool RemoveItem(string itemName)
//    {
//        for (int i = 0; i < itemCount; i++)
//        {
//            if (inventory[i].Name == itemName)
//            {
//                for (int j = i; j < itemCount - 1; j++)
//                {
//                    inventory[j] = inventory[j + 1];
//                }
//                itemCount--;
//                return true;
//            }
//        }
//        return false;
//    }

//    public float GetTotalWeight()
//    {
//        float totalWeight = 0;
//        for (int i = 0; i < itemCount; i++)
//        {
//            totalWeight += inventory[i].Weight;
//        }
//        return totalWeight;
//    }

//    public decimal GetTotalValue()
//    {
//        decimal totalValue = 0;
//        for (int i = 0; i < itemCount; i++)
//        {
//            totalValue += inventory[i].Value;
//        }
//        return totalValue;
//    }

//    public Item[] FindItems(int? level = null, decimal? value = null)
//    {
//        Item[] foundItems = new Item[itemCount];
//        int foundCount = 0;
//        for (int i = 0; i < itemCount; i++)
//        {
//            if ((level == null || inventory[i].Level == level) &&
//                (value == null || inventory[i].Value == value))
//            {
//                foundItems[foundCount++] = inventory[i];
//            }
//        }
//        Array.Resize(ref foundItems, foundCount);
//        return foundItems;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Player player = new Player("Олег");
//        player.AddItem(new Item("Меч света", 5, 500m, 3f));
//        player.AddItem(new Item("Легкая броня", 3, 300m, 2f));
//        player.AddItem(new Item("Зелье исцеления", 1, 50m, 0.5f));

//        Console.WriteLine("Инвентарь после добавления предметов:");
//        foreach (var item in player.FindItems())
//        {
//            Console.WriteLine($"{item.Name} - Уровень: {item.Level}, Стоимость: {item.Value}, Вес: {item.Weight}");
//        }

//        player.RemoveItem("Меч света");

//        Console.WriteLine("\nИнвентарь после удаления предмета:");
//        foreach (var item in player.FindItems())
//        {
//            Console.WriteLine($"{item.Name} - Уровень: {item.Level}, Стоимость: {item.Value}, Вес: {item.Weight}");
//        }

//        float totalWeight = player.GetTotalWeight();
//        decimal totalValue = player.GetTotalValue();
//        Console.WriteLine($"\nОбщий вес предметов: {totalWeight}, Общая стоимость предметов: {totalValue}");

//        Console.WriteLine("\nПоиск предметов по уровню 5:");
//        var levelItems = player.FindItems(level: 5);
//        foreach (var item in levelItems)
//        {
//            Console.WriteLine($"{item.Name} - Уровень: {item.Level}, Стоимость: {item.Value}, Вес: {item.Weight}");
//        }

//        Console.WriteLine("\nПоиск предметов по стоимости 50:");
//        var valueItems = player.FindItems(value: 50m);
//        foreach (var item in valueItems)
//        {
//            Console.WriteLine($"{item.Name} - Уровень: {item.Level}, Стоимость: {item.Value}, Вес: {item.Weight}");
//        }
//        Console.ReadLine();
//    }
//}
