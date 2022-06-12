using System;
namespace GiantRobot
{
    internal class Planet
    {
        public static Random rnd = new Random();
        public static string choice;
        public static Enemy enemy;
        public static Robot robot = new Robot();
        public static void Select()
        {
            switch (choice)
            {
                case "Earth":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Environment.NewLine+"Nice choice! On Earth, your enemy is a Human!");
                    enemy = new Enemy("Human", 100, rnd.Next(1,10));
                    Console.ResetColor();
                    break;
                case "Mars":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Environment.NewLine + "Nice choice! On Mars, your enemy is a Superhero!");
                    enemy = new Enemy("Superhero", 100, rnd.Next(10,20));
                    Console.ResetColor();
                    break;
                case "Pluto":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Environment.NewLine + "Nice choice! On Pluto, your enemy is an Alien!");
                    enemy = new Enemy("Alien", 100, rnd.Next(1,20));
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
        public string getChoice
        {
            get { return choice; }
        }
    }
}