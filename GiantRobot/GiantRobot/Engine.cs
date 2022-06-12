using System;

namespace GiantRobot
{
    public class Engine
    {
        public static int rounds = 1;
        public static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to Giant Killer Robot game!" + Environment.NewLine);

            Console.ResetColor();
            planetSelection();
        }

        public static void planetSelection()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please choose a planet where to fight!" + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Available planets are Earth, Mars and Pluto." + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Please type your choice here --> ");
            Planet.choice = Console.ReadLine();

            Console.ResetColor();

            if (Planet.choice != "Earth" && Planet.choice != "Mars" && Planet.choice != "Pluto")
            {
                Console.WriteLine(Environment.NewLine + Planet.choice + " is not available. Please be careful at spelling! Press any key to try again!");
                Console.ReadKey();
                Console.Clear();
                StartGame();
            }
        }
        public static void Round(Enemy enemy, Robot robot)
        {
            while (robot.IsAlive && enemy.IsAlive)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("          Round: "+rounds);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("   Robot          " + enemy.name);
                Console.WriteLine("Health: " + robot.health + "     " + " Health: " + enemy.health);
                Console.WriteLine("Damage: " + robot.damage + "     " + " Damage: " + enemy.damage);
                Console.WriteLine();

                enemy.Health -= robot.damage;
                robot.Health -= enemy.damage;
                
                rounds++;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (robot.IsAlive == false)
                Console.WriteLine(enemy.Name + " is the winner!");
            else if (enemy.IsAlive == false)
                Console.WriteLine("Giant Robot is the winner!");
            else if (robot.IsAlive == false && enemy.IsAlive == false)
                Console.WriteLine("Tie! No one is the winner!");
            Console.ResetColor();
        }
    }
}