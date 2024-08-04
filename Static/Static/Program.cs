using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static class MyCalculator
        {

            public static double Add(double x, double y)
            {
                double addnum = x + y;

                Console.WriteLine($"두 수의 합은 ({addnum})");

                return addnum;

            }

            public static double Subtract(double x, double y)
            {
                double subnum = x - y;

                Console.WriteLine($"두 수의 차는 ({subnum})");

                return subnum;
            }

            public static double Multiply(double x, double y)
            {
                double multiplynum = x * y;
                Console.WriteLine($"두 수의 곱은 ({multiplynum})");

                return multiplynum;
            }

            public static double Divide(double x, double y)
            {
                double dividenum = x / y;
                Console.WriteLine($"두 수의 나누기 결과는 ({dividenum})");

                return dividenum;
            }
            public static double Squared(double x, double y)
            {
                double squarednum = x;

                for (int i = 1; i < y; i++)
                {
                    squarednum = squarednum * x;

                }

                Console.WriteLine($" {x}를 {y} 번 곱한 결과는 {squarednum}");

                return squarednum;
            }



            static void Main(string[] args)
            {
                Console.WriteLine("계산할 작업을 골라주세요.");
                Console.WriteLine("1. 합 구하기");
                Console.WriteLine("2. 차 구하기");
                Console.WriteLine("3. 곱 구하기");
                Console.WriteLine("4. 나누기 구하기");
                Console.WriteLine("5. 제곱 구하기");

                double i = double.Parse(Console.ReadLine());

                switch (i)
                {

                    case 1:
                        Console.WriteLine("합을 구합니다.");
                        Console.WriteLine("두 숫자를 입력해주세요.");
                        double x = double.Parse(Console.ReadLine());
                        double y = double.Parse(Console.ReadLine());

                        Add(x, y);

                        break;

                    case 2:
                        Console.WriteLine("차를 구합니다.");
                        Console.WriteLine("두 숫자를 입력해주세요.");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());

                        Subtract(x, y);

                        break;

                    case 3:
                        Console.WriteLine("곱을 구합니다.");
                        Console.WriteLine("두 숫자를 입력해주세요.");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());

                        Multiply(x, y);

                        break;

                    case 4:
                        Console.WriteLine("나눗셈을 구합니다.");
                        Console.WriteLine("두 숫자를 입력해주세요.");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        if (y == 0)
                        {
                            Console.WriteLine("에러 입니다. 두 번째 숫자는 0을 제외하고 입력해주세요.");
                        }
                        else
                        {
                            Divide(x, y);
                        }
                        break;

                    case 5:
                        Console.WriteLine("제곱을 구합니다.");
                        Console.WriteLine("두 숫자를 입력해주세요.");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());

                        Squared(x, y);

                        break;



                    default:
                        Console.WriteLine("에러 입니다.");
                        break;
                }





            }
        }
    }
}
