
namespace LevelTest2
{
    internal class Program
    {
        void Main(string[] args)
        {
            Monster[] monsters = new Monster[5];
            monsters[0] = new Pikachu();
            monsters[1] = new Charmander();
            monsters[2] = new Squirtle();
            monsters[3] = new Bulbasaur();
            monsters[4] = new Pikachu("털뭉치");

            foreach (Monster monster in monsters)
            {
                
                Console.WriteLine($"{monster.name} 공격해!");
                Monster.Attack();
                Console.WriteLine();
            }

        }
        
        class Monster
        {
            public string name;
           

             public Monster(string name)
             {
                 this.name = name;
                 
             }

            public virtual void Attack()
            { 
            }
            
           

        }
           class Pikachu : Monster
           {
            
               public Pikachu(string name = "Pikachu") : base(name)
               {
                   this.name = name;
                   this.name = "피카츄";
               }
            public override void Attack()
            {
                Console.WriteLine("백만볼트 !");
            }
            
           }
        
           class Charmander : Monster
           {

            public Charmander(string name = "Charmander") : base(name)
            {
                this.name = "파이리";
            }
            public override void Attack()
            {
                Console.WriteLine("화염방사 !");
            }
        }
        
           class Squirtle : Monster
           {

            public Squirtle(string name = "Squirtle") : base(name)
            {
                this.name = "꼬부기";
            }
            public override void Attack()
            {
                Console.WriteLine("물총발사 !");
            }
        }
           class Bulbasaur : Monster
           {

            public Bulbasaur(string name = "Bulbasaur") : base(name)
            {
                this.name = "이상해씨";
            }
            public override void Attack()
            {
                Console.WriteLine("덩굴채찍 !");
            }
        }
        
    }
}








