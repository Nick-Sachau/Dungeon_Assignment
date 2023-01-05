using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;

        public int MinDamage { get { return _minDamage; } set { _minDamage = value; } }
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int BonusHitChance { get { return _bonusHitChance; } set { _bonusHitChance = value; } }
        public bool IsTwoHanded { get { return _isTwoHanded; } set { _isTwoHanded = value; } }
        public WeaponType Type { get { return _type; } set { _type = value; } }

        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            //Any properties with business rules based off of OTHER properties MUST
            //come AFTER those other properties are set. MinDamage depens on MaxDamage, so man damage
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
        }

        //Methods - Monkeys
        public override string ToString()
        {
            //Add type to the ToString()
            //return base.ToString();
            return$"************* STATS *************\n" +
                  $"Item : {Name}\n" +
                  $"Min-Damage: {MinDamage}\n" +
                  $"Max-Damage: {MaxDamage}\n" +
                  $"Bonus Hit Chance: {BonusHitChance}\n" +
                  $"{(IsTwoHanded ? "Sword is two handed" : "")}\n";
        }
    }
}
