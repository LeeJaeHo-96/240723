using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreater
{
    internal class Program
    {
        public class Trainer
        {
            public string Name;
            public int HaveMonster;


            public Trainer(string name, int haveMonster)
            {
                Name = name;
                HaveMonster = haveMonster;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Trainer Name : {Name}");
                Console.WriteLine($"Monster maximum reserves : {HaveMonster}");
            }
        }
        class Monster
        {
            int Hp;

            public Monster(int hp)
            {
                Hp = hp;
            }

            public void SummonMonster()
            {
                Console.WriteLine($"{Hp}의 체력을 가진 몬스터를 소환하였습니다.");
            }

        }
        static void Main(string[] args)
        {
            
            Trainer ziwoo = new Trainer("김지우", 6);
            ziwoo.PrintInfo();
            Monster mon = new Monster(50);
            mon.SummonMonster();

        }
    }
}
