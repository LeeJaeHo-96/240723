namespace hash
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<string, UnitData> unitData = new Dictionary<string, UnitData>();

       
            unitData.Add("저글링", new UnitData("저글링", Race.Zerg, true));
            unitData.Add("디파일러", new UnitData("디파일러", Race.Zerg, false));
            unitData.Add("마린", new UnitData("마린", Race.Terran, true));
            unitData.Add("사이언스베슬", new UnitData("사이언스베슬", Race.Terran, false));
            unitData.Add("질럿", new UnitData("질럿", Race.Protoss, true));
            unitData.Add("하이템플러", new UnitData("하이템플러", Race.Protoss, false));


            
            

           
            if (unitData.ContainsKey("저글링"))   
            {
                UnitData find = unitData["저글링"];  
                Console.WriteLine($"{find.name}, {find.race}, {find.attackable}");
            }
            if (unitData.ContainsKey("디파일러"))
            {
                UnitData find = unitData["디파일러"];
                Console.WriteLine($"{find.name}, {find.race}, {find.attackable}");
            }
            if (unitData.ContainsKey("마린"))   
            {
                UnitData find = unitData["마린"];  
                Console.WriteLine($"{find.name}, {find.race}, {find.attackable}");
            }
            if (unitData.ContainsKey("사이언스베슬"))    
            {
                UnitData find = unitData["사이언스베슬"];  
                Console.WriteLine($"{find.name}, {find.race}, {find.attackable}");
            }
            if (unitData.ContainsKey("질럿"))  
            {
                UnitData find = unitData["질럿"];   
                Console.WriteLine($"{find.name}, {find.race}, {find.attackable}");
            }
            if (unitData.ContainsKey("하이템플러"))    
            {
                UnitData find = unitData["하이템플러"];  
                Console.WriteLine($"{find.name}, {find.race}, {find.attackable}");
            }



        }
    }

    public enum Race { Zerg, Terran, Protoss }

    public class UnitData
    {
        public string name;
        public Race race;
        public bool attackable;

        public UnitData(string name, Race race, bool attackable)
        {
            this.name = name;
            this.race = race;
            this.attackable = attackable;
        }
    }
    public class Unit : UnitData
    {
        public string name;
        public Race race;
        public bool attackable;
        public Unit(string name, Race race, bool attackable) : base(name, race, attackable)
        {
            base.name = name;
            base.race = race;
            base.attackable = attackable;
        }
    }
}





