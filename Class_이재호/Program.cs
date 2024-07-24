using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        class Character
        {
            public Character level;
            public Character Hp;
            public Character moveSpeed;
            public Character atk;

            void moveForward()
            {
                Console.WriteLine("앞으로 이동합니다.");
            }
            void moveBackward()
            {
                Console.WriteLine("뒤로 이동합니다.");
            }
            void leftside()
            {
                Console.WriteLine("90도 좌회전합니다.");
            }
            void rightside()
            {
                Console.WriteLine("90도 우회전합니다.");
            }
            void attack()
            {
                Console.WriteLine("공격합니다.");
            }
            void hit()
            {
                Console.WriteLine("피격 당했습니다");
            }

            class Monser : Character
            {

            }

            class PlayerCharacter : Character
            {

            }

            class PlayerManagement : Character
            {

            }
            static void Main(string[] args)
            {

            }
        }
    }
}
