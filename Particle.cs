using System;
using System.Drawing;

namespace SixthLabWorkApp
{
    class Particle
    {
        public int Radius;
        public float X;
        public float Y;

        public float Direction;
        public float Speed;

        public static Random rand = new Random();

        public Particle()
        {
            Direction = rand.Next(360);
            Speed = 1 + rand.Next(10);
            Radius = 2 + rand.Next(10);
        }

        public void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            brush.Dispose();
        }
    }
}
