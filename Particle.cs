using System;
using System.Drawing;

namespace SixthLabWorkApp
{
    public class Particle
    {
        public int Radius;
        public float X;
        public float Y;

        public float SpeedX;
        public float SpeedY;
        
        public float Life;

        public static Random rand = new Random();

        public Particle()
        {
            var direction = (double) rand.Next(360);
            var speed = 1 + rand.Next(10);

            SpeedX = (float) (Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = (float) (Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 2 + rand.Next(10);
            Life = 20 + rand.Next(100);
        }

        public virtual void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);

            int alpha = (int)(k * 255);

            var color = Color.FromArgb(alpha % 255, Color.Black);

            SolidBrush brush = new SolidBrush(color);

            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            brush.Dispose();
        }

        public virtual void DrawSpeedVector(Graphics g)
        {
            float length = (float)Math.Sqrt(SpeedX * SpeedX + SpeedY * SpeedY);

            if (length < 0.001f)
                return;

            float dirX = SpeedX / length;
            float dirY = SpeedY / length;

            float endX = X + dirX * Radius;
            float endY = Y + dirY * Radius;

            using (Pen pen = new Pen(Color.LimeGreen, 2))
            {
                g.DrawLine(pen, X, Y, endX, endY);
            }
        }
    }

    public class ParticleColorful : Particle
    {
        public Color FromColor;
        public Color ToColor;

        public static Color MixColor(Color color1, Color color2, float k)
        {
            if (k < 0) k = 0;
            if (k > 1) k = 1;

            int a = (int)(color2.A * k + color1.A * (1 - k));
            int r = (int)(color2.R * k + color1.R * (1 - k));
            int g = (int)(color2.G * k + color1.G * (1 - k));
            int b = (int)(color2.B * k + color1.B * (1 - k));

            a = a < 0 ? 0 : (a > 255 ? 255 : a);
            r = r < 0 ? 0 : (r > 255 ? 255 : r);
            g = g < 0 ? 0 : (g > 255 ? 255 : g);
            b = b < 0 ? 0 : (b > 255 ? 255 : b);

            return Color.FromArgb(a, r, g, b);
        }

        public override void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);

            var color = MixColor(FromColor, ToColor, k);
            var brush = new SolidBrush(color);

            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            brush.Dispose();
         }
    }
}
