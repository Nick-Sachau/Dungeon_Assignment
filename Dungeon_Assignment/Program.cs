using DungeonLibrary;
using System.Diagnostics;
using System.Numerics;

namespace Dungeon_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title / Introduction
            Console.Title = "DUNGEON OF DOOM!";
            Console.WriteLine("Your journey begins...\n");
            #endregion

            #region Player Creation
            //TODO Variable to keep score
            int score = 0;

            //TODO Create a weapon object
            Weapon w1 = new Weapon(1, 8, "long sword", 10, true, WeaponType.Sword);

            //TODO Create a player
            Player player = new Player("Jeremy Huber", 70, 5, 40, 40, w1);
            #endregion


            #region Main Game Loop
            bool quit = false;
            do
            {

                //TODO Generate a random room
                Monster monster = Monster.GetMonster();
                string room = GetRoom(monster);
                Console.WriteLine(room);
                //TODO Generate a random monster


                //inner loop:
                #region Gameplay Menu Loop
                bool reload = false;
                do
                {
                    #region Menu
                    Console.WriteLine("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    string menuChoice = Console.ReadKey(true).Key.ToString();
                    //menu switch
                    switch (menuChoice)
                    {
                        case "A":
                            //TODO Combat
                            Console.Clear();
                            Console.WriteLine(room);
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"You killed {monster.Name}!");
                                Console.ResetColor();
                                score += 1;
                                player.Life += (player.MaxLife / 5);
                                //Leave the inner loop and get a new monster and room
                                reload = true;
                            }
                            break;

                        case "R":
                            //TODO Run Away -- give the monster an attack of opportunity
                            Console.WriteLine("Run Away!");
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            reload = true; //generate a new monster and a new room
                            break;//exit 1 loop

                        case "P":
                            //TODO Display player info
                            Console.Clear();
                            Console.WriteLine(room);
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters Slain: " + score);
                            break;

                        case "M":
                            //TODO Display Monster info
                            Console.Clear();
                            Console.WriteLine(room);
                            Console.WriteLine(monster);
                            break;

                        case "X":
                        case "E":
                        case "Escape":
                            Console.Clear();
                            quit = true;
                            Console.WriteLine("No one likes a quitter...\n\n");
                            break;//exit both loops

                        default:
                            Console.Clear();
                            Console.WriteLine(room);
                            Console.WriteLine("Thou hast chosen an improper option. Triest thou again.");
                            break;
                    }//end switch
                    #endregion

                    //TODO Check player life
                    if (player.Life == 0)
                    {
                        Console.WriteLine("You died\a");
                        quit = true;
                    }
                } while (!reload && !quit);
                #endregion
            } while (!quit);
            #endregion

            //Output the final score and say goodbye
            Console.WriteLine($"You have defeated {score} monsters. Thanks for playing try again next time.");
        }//end Main()

        #region  Custom Methods
        //TODO Create a custom GetRoom() for random room generation
        private static string GetRoom(Monster monsterName)
        {
            string[] rooms = { $"You made it to a Prison. Built by an ambitious queen of old.\nIt is guarded by {monsterName}.\nIf you defeat the {monsterName}\nYou will receive the Wand of Famous Witch or Wizard.\n",

                //$"You made it to a Temple, made from a natural cave.\nYou find rats everywhere and get a aberrant presence.\nYou notice that the ceilings are unstable and are about to fall.\nYou have to make it accross to earn the artifact of an elvish hero or escape.\n",

                $"You made it to the Palace built by the powerful noble family, surrounded by lava flows and steam vents.\nIt's located beneath a cold mountain you might want a jacket.\nIts protected by the monstrous orc warlordand and his rats.\nIf you defeat the monstrous orc warlord and make it into the palace you will achive the weapon of a legendary warrior\n",

                $"You have found the Temple of religious zealots, its is underground a well-known castle or monastery.\nIt is guarded by {new Random().Next(1, 10000)} tiny spiders.\nIf you can defeat all the tiny spiders before the ceiling falls.\nYou will achive {new Random().Next(1, 5)} bags of gold.\n",

                $"You found a Maze that was built by a Dark Sorceress.\nYou see 3 different enemies in towers in the maze.\nTheres an ultra dark demon, small group of Zomies, and a Giant wielding a longsword \nYou see a sign at the front that has a reward on it. You look and its the treasury of an ancient dwarvish realm.\n",

                $"You have found a lair thats filled with a weak family associated to the theives guild.\nIts located deep in the forest. You walk walk up and see an Elemental Guardian and an Orc\nIf you take over the lair you will aquire {new Random().Next(1, 10)} chests of gold carried by a stolen wagon.\n",
            };
            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            string room = rooms[index];
            return room;
            //possible refactor 
            //return rooms[new Random().next(rooms.length)]
        }
        #endregion
    }
}
}