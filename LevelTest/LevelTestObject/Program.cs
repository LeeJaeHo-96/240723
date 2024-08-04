
namespace LevelTestObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iLeft = 10;
            int iRight = 20;

            Util<int>.Swap(ref iLeft, ref iRight);

            Console.WriteLine("int 자료형을 사용한 Swap 함수");
            Console.WriteLine($"{iLeft}, {iRight}");

            Console.WriteLine("");

            double dLeft = 3.5;
            double dRight = 8.8;

            Util<double>.Swap(ref dLeft, ref dRight);

            Console.WriteLine("double 자료형을 사용한 Swap 함수");
            Console.WriteLine($"{dLeft}, {dRight}");
        }

    }
    public class Util<T>()
    {


        public static void Swap(ref T iLeft1, ref T iRight1)
        {
            T temp = iLeft1;
            iLeft1 = iRight1;
            iRight1 = temp;
        }


    }
}
