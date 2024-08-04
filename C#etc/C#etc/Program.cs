using System;

namespace Additional
{
    internal class Property
    {
        public class Player
        {
            private int hp;

            // <Getter Setter>
            // 맴버변수가 외부객체와 상호작용하는 경우 Get(가져오기) & Set(설정) 함수를 구현해 주는 것이 일반적
            // 1. Get & Set 함수의 접근제한자를 설정하여 외부에서 맴버변수의 접근을 캡슐화함
            // 2. Get & Set 함수를 거쳐 맴버변수에 접근할 경우 호출스택에 함수가 추가되어 변경시점을 확인 가능

            public int GetHP()
            {
                return hp;
            }

            private void SetHP(int hp)
            {
                this.hp = hp;

            }

            //속성(Property)를 이용해서 간소화 표현
            private int mp;
            public int MP
            {
                get { return mp; }
                set { mp = value; } //위랑 똑같은 역할
            }

            //AP 멤버변수를 선언과 동시에 get & set 속성 생성
            public int AP { get; set; }

            private float rate;

            public int TotalDamage => (int)(AP * (1 + rate));
        }

        public static void Main()
        {
            Player player = new Player();

            //플레이어 체력 바꾸는건 금지
            //player.SetHP(0);

            //플레이어 체력 읽는건 가능
            Console.WriteLine($"플레이어의 체력 {player.GetHP}");

            player.MP = 1;          //프로퍼티 set 호출
            int mp = player.MP;     //프로퍼티 get 호출

            player.AP = 1;          //간소화 표현 set
            int ap = player.AP;     //간소화 표현 get

            int totalDamage = player.TotalDamage;
        }
    }
}
