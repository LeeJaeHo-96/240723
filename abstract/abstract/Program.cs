using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        //추상클래스 : 추상 메소드가 존재하는 클래스
        //오버라이딩 : 같은 이름의 메소드를 동시에 사용할 수 있게 해주는 키워드
        //오버로딩   : 상속되는 메소드를 다른 메소드로 대체하는 키워드

        static void Main(string[] args)
        {
            Overlord name;
        }


        abstract class Zerg
        {
            public string name;
            public float hp = 0;
            public int atk = 0;

            public void Bionic()
            {
                bool bionic = true;
            }

            public abstract void GroundUnit();

            public abstract void Attackable();


            public Zerg(string name1, float hp1, int atk1)
            {
                name = name1;
                hp = hp1;
                atk = atk1;
            }


        }


        class Zergling : Zerg
        {
            string name1 = "Zergling";
            float hp1 = 35.0f;
            int atk1 = 5;

            public Zergling(string name1, float hp1, int atk1) : base(name1, hp1, atk1)
            {
            }

            public override void GroundUnit()
            {
                bool ground = true;

                if (ground == true)
                {
                    //해당 유닛의 타입은 지상 유닛
                }
                else
                {
                    //해당 유닛의 타입은 지상 유닛이 아님
                }
            }

            public override void Attackable()
            {
                bool attackable = true;

                if (attackable == true)
                {
                    //공격 버튼 생성됨
                }
                else
                {
                    // 공격 버튼 생성되지 않음
                }

            }
        }

        class Drone : Zerg
        {
            string name = "Drone";
            float hp = 40.0f;
            int atk = 5;

            public Drone(string name1, float hp1, int atk1) : base(name1, hp1, atk1)
            {
            }

            public override void GroundUnit()
            {
                bool ground = true;

                if (ground == true)
                {
                    //해당 유닛의 타입은 지상 유닛
                }
                else
                {
                    //해당 유닛의 타입은 지상 유닛이 아님
                }
            }
            public override void Attackable()
            {
                bool attackable = true;

                if (attackable == true)
                {
                    //공격 버튼 생성됨
                }
                else
                {
                    // 공격 버튼 생성되지 않음
                }

            }

        }

        class Hydralisk : Zerg
        {
            string name = "hydralisk";
            float hp = 80.0f;
            int atk = 10;

            public Hydralisk(string name1, float hp1, int atk1) : base(name1, hp1, atk1)
            {
            }

            public override void GroundUnit()
            {
                bool ground = true;

                if (ground == true)
                {
                    //해당 유닛의 타입은 지상 유닛
                }
                else
                {
                    //해당 유닛의 타입은 지상 유닛이 아님
                }
            }
            public override void Attackable()
            {
                bool attackable = true;

                if (attackable == true)
                {
                    //공격 버튼 생성됨
                }
                else
                {
                    // 공격 버튼 생성되지 않음
                }

            }
        }

        class Overlord : Zerg
        {
            public string name = "Overlord";
            float hp = 200.0f;
            int atk = 0;

            
            public Overlord(string name1, float hp1, int atk1) : base(name1, hp1, atk1)
            {
            }

            public override void GroundUnit()
            {
                bool ground = false;

                if (ground == true)
                {
                    //해당 유닛의 타입은 지상 유닛
                }
                else
                {
                    //해당 유닛의 타입은 지상 유닛이 아님
                }
            }

            public override void Attackable()
            {
                bool attackable = false;

                if (attackable == true)
                {
                    //공격 버튼 생성됨
                }
                else
                {
                    // 공격 버튼 생성되지 않음
                }

            }
            
            
        }

        class Mutalisk : Zerg
        {
            string name = "Mutalisk";
            float hp = 120.0f;
            int atk = 9;

            public Mutalisk(string name1, float hp1, int atk1) : base(name1, hp1, atk1)
            {
            }

            public override void GroundUnit()
            {
                bool ground = false;

                if (ground == true)
                {
                    //해당 유닛의 타입은 지상 유닛
                }
                else
                {
                    //해당 유닛의 타입은 지상 유닛이 아님
                }
            }
            public override void Attackable()
            {
                bool attackable = true;

                if (attackable == true)
                {
                    //공격 버튼 생성됨
                }
                else
                {
                    // 공격 버튼 생성되지 않음
                }

            }
        }
        
    }
}



