using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            while (consoleKeyInfo.Key != ConsoleKey.D1 && consoleKeyInfo.Key != ConsoleKey.D2 && consoleKeyInfo.Key != ConsoleKey.NumPad1 && consoleKeyInfo.Key != ConsoleKey.NumPad2)
            {
                DisplayMenu();
                consoleKeyInfo = Console.ReadKey(true);
            }
            if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
                Game1();
            else
                Game2();
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Please, chose your game :");
            Console.WriteLine("\t1 : Monster Fight Club");
            Console.WriteLine("\t2 : Big Boss, Big Fight");
        }

        private static void Game1()
        {
            // Instantiate a new Player.
            Player player = new Player();

            Console.WriteLine("Welcome in the game: \"Monster Fight Club\"");
            Console.WriteLine("Enter your player name :");
            string input = Console.ReadLine();
            player.Name = input;
            Console.WriteLine($"Hi {player.Name}, your life is {player.Life} press a key to start the game !");

            while (player.IsAlive())
            {
                int number = Dice.RollTheDice(3);
                int monsterDamages = 0;
                int reward = 0;
                int monsterMagicalDamages = 0;

                Monster monster = null;

                // Instantiate a new monster.
                if (number == 1)
                {
                    EasyMonster easyMonster = new EasyMonster();
                    monsterDamages = easyMonster.PhysicalDamages;
                    reward = easyMonster.Reward;
                    monster = easyMonster;
                    Console.WriteLine("You encounter an easy monster");
                }
                else
                {
                    DifficultMonster difficultMonster = new DifficultMonster();
                    monsterDamages = difficultMonster.PhysicalDamages;
                    monsterMagicalDamages = difficultMonster.MagicalDamages();
                    reward = difficultMonster.Reward;
                    monster = difficultMonster;
                    Console.WriteLine("You encounter a difficult monster");
                }

                // Player attack
                if (player.Attack(monster))
                {
                    player.Points += reward;
                    if (monster is EasyMonster)
                        player.EasyMonsterCounter++;
                    else
                        player.DifficultMonsterCounter++;

                    Console.WriteLine("You won the fight");
                }
                else
                {
                    if (monster.Attack(player))
                    {
                        // If the shield is less than 2, the player does not receive any damage 
                        if (player.ShieldWorks())
                        {
                            player.Life -= monsterDamages;
                            player.Life -= monsterMagicalDamages;

                            Console.WriteLine("You lost the fight");
                            Console.WriteLine("Your current life is : " + player.Life);
                        }
                    }
                }
            }

            YouLoose(player, "the monsters");
            Console.WriteLine($"You earned {player.Points} points. You killed {player.EasyMonsterCounter} easy monsters and {player.DifficultMonsterCounter} difficult monsters");
            Console.Read();
        }

        private static void Game2()
        {
            Player player = new Player();
            Boss boss = new Boss(250);

            Console.WriteLine("Welcome in the game: \"Big Boss, Big Fight\"");
            Console.WriteLine("Enter your player name :");
            string input = Console.ReadLine();
            player.Name = input;
            Console.WriteLine($"Hi {player.Name}, your life is {player.Life} and the Boss life is {boss.LifePoints} (life is unfair isn't it ?). Press a key to start the game!");

            while (player.IsAlive() && boss.IsAlive())
            {
                // Player attack
                player.Attack(boss);

                if (boss.IsAlive())
                {
                    boss.Attack(player);
                }
            }

            if (player.IsAlive())
                Console.WriteLine("Nice job! You killed the Boss!");
            else
                YouLoose(player, "the boss");

            Console.Read();
        }

        private static void YouLoose(Player player, string name)
        {
            Console.WriteLine("Game over! Sorry {0}, {1} got you...", player.Name, name);
        }
    }
}
