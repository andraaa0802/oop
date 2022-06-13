using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BBG
{
    public class MonsterBall : Ball
    {
        private int radius, speedX, speedY;
        private Point position;
        private Color color;

        public Point Position { get { return position; } }
        public int Radius { get { return radius; } set { radius = value; } }

        public MonsterBall()
        {
            Random rnd = new Random();
            radius = rnd.Next(1, 25);
            position.X = rnd.Next(1,500); //canvas' width
            position.Y = rnd.Next(1,250); //canvas' height
            speedX = 0;
            speedY = 0;
            color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }
    }
}
