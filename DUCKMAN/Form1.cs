using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUCKMAN
{
    public partial class Form1 : Form
    {

        bool cima, baixo, direita, esquerda, isGamerOver;
        int score, playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostSpeed;


        public Form1()
        {
            InitializeComponent();

            resetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            

            if(e.KeyCode == Keys.Up)
            {
                cima = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                baixo = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                esquerda = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                direita = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                cima = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                baixo = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                esquerda = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                direita = false;
            }

            if (e.KeyCode == Keys.Enter && isGamerOver == true)
            {
                resetGame();
               
                
                
            }
        }

        private void mainGamerTimer(object sender, EventArgs e)
        {
            txtscore.Text = "Score: " + score;

            if(esquerda == true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left;
            }
            if(direita == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right;
            }
            if(baixo == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down;
            }
            if(cima == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up;
            }

            if (pacman.Left < -10)
            {
                pacman.Left = 680;
            }
            if (pacman.Left > 680)
            {
                pacman.Left = -10;
            }

            if(pacman.Top < -10)
            {
                pacman.Top = 550;
            }
            if(pacman.Top > 550)
            {
                pacman.Top = 0;
            }


            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                    }

                    if((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("Perdeste");
                            lose.Visible = true;

                        }
                    }

                    if ((string)x.Tag == "fantasma")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("Perdeste!");
                            lose.Visible = true;


                        }
                       
                    }

                    if ((string)x.Tag == "lose")
                     {
                         x.Visible = false;
                     }
                    


                }
            }

            vermelho.Left += redGhostSpeed;
            if(vermelho.Bounds.IntersectsWith(pictureBox1.Bounds) || vermelho.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                redGhostSpeed = -redGhostSpeed;
            }

            amarelo.Left += yellowGhostSpeed;
            if (amarelo.Bounds.IntersectsWith(pictureBox3.Bounds) || amarelo.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                yellowGhostSpeed = -yellowGhostSpeed;
            }

            rosa.Left += pinkGhostSpeed;
            {
                if(rosa.Bounds.IntersectsWith(pictureBox5.Bounds) || rosa.Bounds.IntersectsWith(pictureBox6.Bounds))
                {
                    pinkGhostSpeed = -pinkGhostSpeed;
                }
            }

            if (score == 64)
            {
                gameOver("VENCESTE");
            }
        }

        private void resetGame()
        {

            txtscore.Text = "Score: 0";
            score = 0;  

            redGhostSpeed = 10;
            yellowGhostSpeed = 10;
            pinkGhostSpeed = 10;
            playerSpeed = 12;

            isGamerOver = false;

            pacman.Left = 22;
            pacman.Top = 55;

            vermelho.Left = 215;
            vermelho.Top = 78;

            amarelo.Left = 455;
            amarelo.Top = 413;

            rosa.Left = 526;
            rosa.Top = 226;


            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Visible = true;
                }
            }

            gameTimer.Start();

        }
        
        private void gameOver(string message)
        {
            isGamerOver= true;
            gameTimer.Stop();
            txtscore.Text = "Score: "+ score + Environment.NewLine + message;
        }

     
        }

    }


