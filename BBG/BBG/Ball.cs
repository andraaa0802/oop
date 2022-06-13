using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace BBG
{
    public class Ball
    {
        private int radius, speedX, speedY;
        private Point position;
        private Color color;

        public Point Position { get { return position; } }
        public int Radius { get { return radius; } set { radius = value; } }
    }
}
