using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new ("kim");
            MyClass b = new ("Lee");

            Util.Swap(ref a, ref b);

            Console.WriteLine(a.Name);
            Console.WriteLine(b.Name);
          
        }
    }

    public class MyClass
    {
        public string Name { get; private set; }

        public MyClass(string name)
        {
            Name = name;
        }
    }

    public static class Util
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
