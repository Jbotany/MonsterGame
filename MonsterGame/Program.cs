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
            // Instantiate a new Player.
            Player player = new Player();

            Console.WriteLine("Welcome in the game: \"Monster Fight Club\"");
            Console.WriteLine("Enter your player name :");
            string input = Console.ReadLine();
            player.Name = input;
            Console.WriteLine($"Hi {player.Name}, your life is {player.Life} press a key to start the game !");

            Random rand = new Random();
            Dice dice = new Dice();

            while (player.IsAlive == true)
            {
                int number = rand.Next(1, 3);
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
            

            Console.WriteLine("Game over");
            Console.WriteLine($"You earned {player.Points} points. You killed {player.EasyMonsterCounter} easy monsters and {player.DifficultMonsterCounter} difficult monsters");
            Console.Read();

        }
    }
}
