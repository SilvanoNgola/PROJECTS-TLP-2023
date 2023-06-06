using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gametimerevent(object sender, EventArgs e)
        {

            flappybird.Top += gravity;
            pipedown.Left -= pipeSpeed;
            pipetop.Left -= pipeSpeed;
            scoretxt.Text = "Score: " + score;

            if (pipedown.Left < -100)
            {
                pipedown.Left = 800;
                score++;
            }
            if (pipetop.Left < -100)
            {
                pipetop.Left = 950;
                score++;
            }

            if (flappybird.Bounds.IntersectsWith(pipedown.Bounds) || flappybird.Bounds.IntersectsWith(pipetop.Bounds) || flappybird.Bounds.IntersectsWith(ground.Bounds) || flappybird.Top < -25)
            {

                endGame();
            }

          
            /*if (score % 10 == 0 && score != 0)
            {
                pipeSpeed += 1;
            }*/
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

            if(e.KeyCode == Keys.Enter)
            {
                resetgame();
            }
        }

        private void endGame()
        {
            gametimer.Stop();
            scoretxt.Text += " PERDESTE!";
        }
        private void resetgame()
        {
            scoretxt.Text = "Score: 0";
            score = 0;

            pipeSpeed = 8;

            flappybird.Left = 79;
            flappybird.Top = 176;

            gametimer.Start();

        }


    }
}
