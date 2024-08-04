using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float a = 10.1f;
            float b = 20.2f;

            Util.Swap(ref a, ref b);

            Console.WriteLine($"a = {a}, b = {b}");
        }

       
    }

    public static class Util
    {

        public static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        public static void Swap(ref float left, ref float right)
        {
            float temp = left;
            left = right;
            right = temp;
        }

    }
}
