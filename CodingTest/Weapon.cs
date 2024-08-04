using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    public enum AttackSpeed { Fast, Normal, Slow }
    public enum AttackRange { Long, Short, VeryShort }

    public class Weapon
    {
        public String name;
        public AttackSpeed speed;
        public int atk;
        public AttackRange range;
        public bool TakeScar;
        public Weapon()
        {
            this.name = "아이템";

        }

    }
}
