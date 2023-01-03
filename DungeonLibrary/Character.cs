namespace DungeonLibrary
{
    public abstract class Character
    {
        //Fields - Funny
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
        private int _experience;
        private int _maxExperience;
        private int _level;
        //private object _inventory; // add this after completed project

        //Properties - Poeple
        public int Life { get { return _life; } set { _life = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int HitChance { get { return _hitChance; } set { _hitChance = value; } }
        public int Block { get { return _block; } set { _block = value; } }
        public int MaxLife { get { return _maxLife; } set { _maxLife = value; } }
        public int Experience { get { return _experience; } set { _experience = value; } }
        public int MaxExperience { get { return _maxExperience; } set { _maxExperience = value; } }
        public int Level { get { return _level; } set { _level = value; } }

        //Constructors - Collect
        public Character()
        {

        }

        public Character(string name, int hitChance, int block, int maxLife)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = maxLife;
        }

        //Methods - Monkeys
        public virtual int CalcBlock()
        {
            int block = 0;
            return block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public abstract int CalcDamage();

        public override string ToString()
        {
            //return base.ToString();
            return $"--------- {Name} ---------\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}";
        }
    }
}