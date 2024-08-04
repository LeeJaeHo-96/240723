using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class GreatSword : Weapon
    {
        public GreatSword() { }
        public string name = "축복의 강철 대검";
        public AttackSpeed speed = AttackSpeed.Slow;
        public int atk = 1050;
        public AttackRange range = AttackRange.Short;
        public bool TakeScar = true;

        public void greatSword()
        {
            Console.WriteLine($"아이템 이름 : {name}");
            Console.WriteLine($"공격속도 : {speed}");
            Console.WriteLine($"공격력 : {atk}");
            Console.WriteLine($"사거리 : {range}");
            Console.WriteLine($"상처 입히기 가능 유무 : {TakeScar}");
            Console.WriteLine("오딘에게 축복받은 강철로 벼려진 대검," +
                "모든 것 을 벨 수 있다고 알려지있다.");


        }
    }
    }

