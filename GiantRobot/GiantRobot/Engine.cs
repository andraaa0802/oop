using System;

namespace GiantRobot
{
    public class Engine
    {
        public static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to Giant Killer Robot game!"+Environment.NewLine);
           
            Console.ResetColor();
            planetSelection();
        }

        public static void planetSelection()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please choose a planet where to fight!" + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Available planets are Earth, Mars and Pluto." +Environment.NewLine);
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
        
    }
}