namespace DungeonLibrary
{
    public class Monster : Character
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public string Description { get; set; }


        public Monster(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description)
            : base(name, hitChance, block, maxLife)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
        }

        public override int CalcDamage()
        {
            int rand = new Random().Next(MinDamage, MaxDamage + 1);
            return rand;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Min Damage: {MinDamage}\n" +
                   $"Max Damage: {MaxDamage}\n" +
                   $"Description: {Description}";
        }
        public static Monster GetMonster()
        {                               //Name, hit, block, max Life, min Damage, max Damage, description
            Monster gremlin = new Monster("Gremlin", 50, 25, 15, 4, 11, "This is a little gremlin");
            Monster elf = new Monster("Gremlin", 60, 30, 5, 2, 8, "This is a tiny weak elf");
            Monster dragon = new Monster("Gremlin", 30, 20, 60, 10, 23, "This is a massive frie breathing dragon that moves super slow");
            Monster mummy = new Monster("Gremlin", 10, 10, 30, 11, 20, "This is a mummy that stuggles to move");
            Monster frankensien = new Monster("Gremlin", 55, 30, 90, 15, 27, "This is a resereced human that is massive and strong, also struggles to move");
            List<Monster> monsters = new List<Monster> { gremlin, gremlin, gremlin, elf, dragon, dragon, dragon, mummy, mummy, frankensien };
            return monsters[new Random().Next(monsters.Count)];
        }
    }
}
