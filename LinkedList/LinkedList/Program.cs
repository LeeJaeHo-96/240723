using System.Collections.Generic;
using System.ComponentModel;

namespace LinkedList
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

             Inventory inventory = new Inventory();
             Item item = new Item("Item");
             Potion potion = new Potion("Potion");
             Weapon weapon = new Weapon("Weapon");
             Armor armor = new Armor("Armor");
             Accessory accessory = new Accessory("Accessory");
             Food food = new Food("Food");
             
             Item [] items = [potion, weapon, armor, accessory, food];
             Random random = new();

            
            while (true)
            {
                inventory.InventoryShow();

                ConsoleKeyInfo key = Console.ReadKey(true);
                int push = int.Parse(key.KeyChar.ToString());

                if (push == 0)
                {
                    inventory.InvenAdd(items[random.Next(items.Length)]);
                }
                else
                {
                    inventory.InvenRemove(ref push);
                }
            }


        }


    }

}


class Inventory
{

    List<Item> list = new();


    public void InventoryShow()
    {


        if (list.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("========인벤토리========");
            Console.WriteLine("인벤토리가 비어있습니다.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("========인벤토리========");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

            }

        }

    }

    public void InvenAdd(Item item)
    {
        if (list.Count < 9)
        {
            list.Add(item);
        }
    }

    public void InvenRemove(ref int push)
    {
        switch (push)  // removeat으로 더 줄이기 가능
        {
            case 1:
                if (list.Count > 0)
                {
                    list.Remove(list[0]);
                }
                break;
            case 2:
                if (list.Count > 1)
                {
                    list.Remove(list[1]);
                }
                break;
            case 3:
                if (list.Count > 2)
                {
                    list.Remove(list[2]);
                }
                break;
            case 4:
                if (list.Count > 3)
                {
                    list.Remove(list[3]);
                }
                break;
            case 5:
                if (list.Count > 4)
                {
                    list.Remove(list[4]);
                }
                break;
            case 6:
                if (list.Count > 5)
                {
                    list.Remove(list[5]);
                }
                break;
            case 7:
                if (list.Count > 6)
                {
                    list.Remove(list[6]);
                }
                break;
            case 8:
                if (list.Count > 7)
                {
                    list.Remove(list[7]);
                }
                break;
            case 9:
                if (list.Count > 8)
                {
                    list.Remove(list[8]);
                }
                break;
        }

    }

}


class Item
{
    private string name;
    private int itemType;

    public Item(string name)
    {
        this.name = name;
    }
}

class Potion : Item
{

    public Potion(string name) : base("Potion")
    {
    }
}
class Weapon : Item
{
    public Weapon(string name) : base("Weapon")
    {
    }
}
class Armor : Item
{
    public Armor(string name) : base("Armor")
    {
    }
}
class Accessory : Item
{
    public Accessory(string Name) : base("Accessory")
    {
    }
}
class Food : Item
{
    public Food(string Name) : base("Food")
    {
    }
}
    
   
      