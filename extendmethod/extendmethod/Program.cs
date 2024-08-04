using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extendmethod
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Inventory<Potion> potioninventory = new(10);

            potioninventory.Add(new Potion("체력 포션"));
            potioninventory.Add(new Potion("마나 포션"));
            potioninventory.Add(new Potion("경험치 포션"));
            potioninventory.Add(new Potion("활력 포션"));

            potioninventory.Remove();
            potioninventory.Remove();

            potioninventory.PrintitemNames();
        }
        public abstract class Item
        {
            public string Name { get; private set; }

            public Item(string name)
            {
                Name = name;
            }
        }
        public class Potion : Item
        {
            public Potion(string name) : base(name) { }
        }

        public class Inventory<T> where T : Item //T에는 Item 상속 받은 클래스만 넣을 수 있다.
        {
            private T[] list;
            private int index;


            public Inventory(int size)
            {
                list = new T[size];
            }

            public void Add(T item)
            {
                if (index < list.Length)
                {
                    list[index] = item;
                    index++;
                }
            }

            public void Remove()
            {
                if (index < 0)
                {
                    index--;
                    list[index] = null;
                }
            }

            public void PrintitemNames()
            {
                Console.WriteLine(" 아이템 목록 :");

                foreach(T item in list)
                {
                    if (item != null)
                    {
                        Console.WriteLine(item.Name);
                    }
                }

            }
        }
    }
}
