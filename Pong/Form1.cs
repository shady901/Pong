﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Pong
{
    public partial class Frm_Pong : Form
    {
        int round;
        int player1Points,player2Points;
        static int playerMoveSpeed = 5;
        static Keys key;
        Random direction = new Random();
        static int ballSpeed = 10;
        int currentLeft;
         int currentTop;
       public Rectangle ball =new Rectangle(350,300, 20, 20);
        bool startRound = true;


        public Frm_Pong()
        {
            InitializeComponent();
            
        }

        private void Frm_Pong_Load(object sender, EventArgs e)
        {
            
        }


        //put every updateing method in here

        private void Update_Tick(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Frm_Pong.ActiveForm.BackColor);
            PointManager();
            UpdateText();
            PlayerMovement();
            WallCheck();
            BallMovement();
            Draw();
           
        }

        public void Draw()
        {
            SolidBrush myBrush = new SolidBrush(Color.White);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush,ball);
            myBrush.Dispose();
            formGraphics.Dispose();
        


        }

        private void BallMovement()
        {
            //if moving left or right move that direction
            if (currentLeft==1)
            {
                ball.X += ballSpeed; //right
            }
            else if(currentLeft == 2)
            {
                ball.X -= ballSpeed; //left
            }
           
            //if moving up or down move that direction
            if (currentTop==1)
            {
                ball.Y += ballSpeed; //down
            }
            else if (currentTop == 2)
            {
                ball.Y -= ballSpeed; //up
            }
            else if (currentTop == 3)
            {
                ball.Y = ball.Y; // y axis movement
            }

         
           
                //checks if ball is on the same x axis
            if ((ball.Location.X<pb_player1.Right))
            {
                if (((ball.Location.Y >= pb_player1.Location.Y) && (ball.Location.Y <= pb_player1.Location.Y + pb_player1.Height)))
                {
                    BallChangeInDirection();
                    if (((ball.Location.Y >= pb_player1.Location.Y) && (ball.Location.Y <= pb_player1.Location.Y + 36)))
                    {
                        currentTop = 2;
                    }
                    else if (((ball.Location.Y <= pb_player1.Location.Y + pb_player1.Height) && (ball.Location.Y >= pb_player1.Location.Y + pb_player1.Height - 36)))
                    {
                        currentTop = 1;
                    }
                }

            }
            else if ((ball.Location.X + ball.Width > pb_player2.Left))
            {
                if (((ball.Location.Y >= pb_player2.Location.Y) && (ball.Location.Y <= pb_player2.Location.Y + pb_player2.Height)))
                {
                    BallChangeInDirection();
                    if (((ball.Location.Y >= pb_player2.Location.Y) && (ball.Location.Y <= pb_player2.Location.Y + 36)))
                    {
                        currentTop = 2;
                    }
                    else if (((ball.Location.Y <= pb_player2.Location.Y + pb_player2.Height) && (ball.Location.Y >= pb_player2.Location.Y + pb_player2.Height - 36)))
                    {
                        currentTop = 1;
                    }
                }
            }
                
               

            //if ball hits top or bottom
            if ((ball.Location.Y <= 0) || (ball.Location.Y >= 800))
            {
                
                if (currentTop == 1)
                {
                    currentTop = 2;
                }
                else if (currentTop == 2)
                {
                    currentTop = 1;
                }
               
            }

            



        }

        public void PointManager()
        {
            RoundStart();
            if (ball.Location.X <= 0)
            {
                player2Points++;
                startRound = true;

            }
            else if (ball.Location.X >= 780)
            {
                player1Points++;
                startRound = true;
            }
        }

        public void RoundStart()
        {
            if (startRound)
            {
                round++;
                //when round start random direction
                ball.Y = 300;
                ball.X = 350;
                if (direction.Next(1, 3) == 1)
                {
                    currentLeft = 1;
                }
                else
                {
                    currentLeft = 2;
                }
                startRound = false;
            }
               
        }
            
        

        public void BallChangeInDirection()
        {

            //change x
            if (currentLeft == 1)
            {
                currentLeft = 2;
            }
            else
            {
                currentLeft = 1;
            }
            //change y

            if (currentTop == 1)
            {
                currentTop = 2;
            }
            else if (currentTop == 2)
            {
                currentTop = 1;
            }
           
        }

        private void PlayerMovement()
        {
            //player1
            if (Keys.W==key)
            {
                
                pb_player1.Top -= playerMoveSpeed;
            }
            if (Keys.S == key)
            {
                pb_player1.Top += playerMoveSpeed;
            }


            //player2
            if (Keys.NumPad8 == key)
            {

                pb_player2.Top -= playerMoveSpeed;
            }
            if (Keys.NumPad5 == key)
            {
                pb_player2.Top += playerMoveSpeed;
            }


        }


        private void WallCheck()
        {
            if (pb_player1.Location.Y>=700-pb_player1.Height)
            {
                pb_player1.Top = 700 - pb_player1.Height;
            }
            if (pb_player1.Location.Y <= 0 )
            {
                pb_player1.Top = 0;
            }
            if (pb_player2.Location.Y >= 700 - pb_player2.Height)
            {
                pb_player2.Top = 700 - pb_player2.Height;
            }
            if (pb_player2.Location.Y <= 0)
            {
                pb_player2.Top = 0;
            }
        }


        private void Frm_Pong_KeyDown(object sender, KeyEventArgs e)
        {
          key = e.KeyCode;            
        }
        public void UpdateText()
        {
            lbl_player1.Text = Convert.ToString("Player 1: " + player1Points);
            lbl_player2.Text = Convert.ToString("Player 2: " + player2Points);
            lbl_Round.Text = Convert.ToString("ROUND: " + round);

        }

    }
}
