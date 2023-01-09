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
        //private int _experience;
        //private int _maxExperience;
        //private inventory _inventory; //TODO add this after completed project

        //Properties - Poeple
        public int Life { get { return _life; } set { _life = value; } }

        public string Name { get { return _name; } set { _name = value; } }

        public int HitChance { get { return _hitChance; } set { _hitChance = value; } }

        public int Block { get { return _block; } set { _block = value; } }

        public int MaxLife { get { return _maxLife; } set { _maxLife = value; } }

        //Constructors - Collect

        public Character(string name, int maxLife, int hitChance, int block)
        {
            Name = name;
            MaxLife = maxLife;
            Life = maxLife;
            HitChance = hitChance;
            Block = block;
        }

        //Methods - Monkeys
        public virtual int CalcBlock()
        {
            int block = 0; //TODO change to do calculations
            
            return block;
        }

        public virtual int CalcHitChance()
        {
            //TODO make calcultaions for hit or not
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