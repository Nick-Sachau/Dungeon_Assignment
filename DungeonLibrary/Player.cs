using System.Numerics;

namespace DungeonLibrary
{
    public class Player : Character
    {
        public int Experience { get; set; }

        public int MaxExperience { get; set; }

        public int Level { get; set; }

        public Weapon EquipedWeapon { get; set; }

        public Player(string name, int hitChance, int block, int maxLife, int maxExperience, Weapon equipedWeapon)
            : base(name, hitChance, block, maxLife)
        {
            Experience = 0;
            MaxExperience = maxExperience;
            Level = 1;
            EquipedWeapon = equipedWeapon;
        }
        public int LevelUp()
        {
            Level += 1;
            Experience = 0;
            return MaxExperience + 30;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Level: {Level}\n" +
                   $"Experience: {Experience} of {MaxExperience}\n\n" +
                   $"Weapon:\n" +
                   $"{EquipedWeapon}";
        }

    }
}
