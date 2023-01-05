using DungeonLibrary;

namespace Dungeon_Assignment
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(2, 8, "Long Sword", 2, true, WeaponType.Sword);
            Player player = new Player("Nick", 40, 6, 3, 40, weapon);
            Console.WriteLine(player);

            player.MaxExperience = player.LevelUp();

            Console.WriteLine(player);
        }
    }
}
