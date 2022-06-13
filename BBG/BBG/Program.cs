using System;
using System.Collections.Generic;

namespace BBG
{
    class Program
    {
        static void Main(string[] args)
        {
            int canvasWidth = 500;
            int canvasHeight = 250;

            List<Ball> ballsList = new List<Ball>();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("How many regular balls do you want?");
            int nrRegular = int.Parse(Console.ReadLine());
            List<RegularBall> regularList = new List<RegularBall>();
            for (int i = 0; i < nrRegular; i++)
            {
                RegularBall regBall = new RegularBall();
                regularList.Add(regBall);
                ballsList.Add(regBall);
            }

            Console.WriteLine("How many repelent balls do you want?");
            int nrRepelent = int.Parse(Console.ReadLine());
            List<RepelentBall> repelentList = new List<RepelentBall>();
            for (int i = 0; i < nrRepelent; i++)
            {
                RepelentBall repBall = new RepelentBall();
                repelentList.Add(repBall);
                ballsList.Add(repBall);
            }

            Console.WriteLine("How many monster balls do you want?");
            int nrMonster = int.Parse(Console.ReadLine());
            List<MonsterBall> monsterList = new List<MonsterBall>();
            for (int i = 0; i < nrMonster; i++)
            {
                MonsterBall monBall = new MonsterBall();
                monsterList.Add(monBall);
                ballsList.Add(monBall);
            }

        }
    }
}
