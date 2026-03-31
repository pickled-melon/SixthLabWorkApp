using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SixthLabWorkApp
{
    public partial class Form1 : Form
    {
        const int PARTICLE_COUNT = 500;

        List<Particle> particles = new List<Particle>();

        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            for (int i = 0; i < PARTICLE_COUNT; i++)
            {
                Particle particle = new Particle();

                particle.X = picDisplay.Image.Width / 2;
                particle.Y = picDisplay.Image.Height / 2;

                particles.Add(particle);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateState();

            using (Graphics g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);

                Render(g);
            }

            picDisplay.Invalidate();
        }

        private void UpdateState()
        {
            foreach (var particle in particles)
            {
                var directionInRadians = particle.Direction / 180 * Math.PI;

                particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
                particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadians));
            }
        }

        private void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                var directionInRadians = particle.Direction / 180 * Math.PI;
                particle.Draw(g);
            }
        }
    }
}
