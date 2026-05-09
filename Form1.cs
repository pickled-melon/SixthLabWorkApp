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
        List<Emitter> emitters = new List<Emitter>();

        Emitter emitter;

        GravityPoint point1;
        GravityPoint point2;

        bool isSimLaunched = true;

        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2
            };


            emitters.Add(this.emitter);

            point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };

            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            emitter.gravityPoints.Add(point1);
            emitter.gravityPoints.Add(point2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isSimLaunched)
                emitter.UpdateState();

            using (Graphics g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);

                emitter.Render(g, chkBoxDebug.Checked);
            }

            picDisplay.Invalidate();
        }



        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            point2.X = e.X;
            point2.Y = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}";
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
            point1.Power = tbGraviton.Value;
        }

        private void tbGraviton2_Scroll(object sender, EventArgs e)
        {
            point2.Power = tbGraviton2.Value;
        }

        private void chkBoxDebug_CheckedChanged(object sender, EventArgs e)
        {
            picDisplay.Invalidate();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            isSimLaunched = !isSimLaunched;

            //timer1.Enabled = isSimLaunched;

            if (isSimLaunched)
            {
                btnStartStop.Text = "Остановить";
                btnStepFrwd.Enabled = false;
            }
            else
            {
                btnStartStop.Text = "Запустить";
                btnStepFrwd.Enabled = true;
            }
                
        }

        private void btnStepFrwd_Click(object sender, EventArgs e)
        {
            if (!isSimLaunched)
            {
                emitter.UpdateState();

                using (Graphics g = Graphics.FromImage(picDisplay.Image))
                {
                    g.Clear(Color.Black);
                    emitter.Render(g, chkBoxDebug.Checked);
                }

                picDisplay.Invalidate();
            }
        }
    }
}
