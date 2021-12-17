using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp4
{
    public partial class GhostAttack : Form
    {
        bool goRight = false;
        bool goLeft = false;
        bool goUp = false;
        bool goDown = false;
        int spriteLeftRight = 1;
        int spriteUpDown = 1;
        int spriteCoin = 1;
        Random rand = new Random();
        int speed = 25;
        int score = 0;
        int enemyVolume = 0;
        int level = 1;
        int time = 0;
        bool placeBomb = false;
        int allCoins = 0;
        int tempCoin;


        public GhostAttack()
        {
            InitializeComponent();
            spawnGold();
        }

        private void restartGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    this.Controls.Remove(x);
                    x.Dispose();
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "coin")
                {
                    this.Controls.Remove(x);
                    x.Dispose();
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bomb")
                {
                    this.Controls.Remove(x);
                    x.Dispose();
                }
            }
            time = 0;
            ball.Left = 50;
            ball.Top = 50;
            goRight = false;
            goLeft = false;
            goUp = false;
            goDown = false;
            spriteLeftRight = 1;
            spriteUpDown = 1;
            speed = 25;
            score = 0;
            enemyVolume = 0;
            level = 1;
            gameTimer.Start();
            labelRestart.Hide();
            time = 0;
            placeBomb = false;
            allCoins = 0;
            spawnGold();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                goRight = true;
            if (e.KeyCode == Keys.Left)
                goLeft = true;
            if (e.KeyCode == Keys.Up)
                goUp = true;
            if (e.KeyCode == Keys.Down)
                goDown = true;
            if (e.KeyCode == Keys.R)
            {
                gameTimer.Stop();
                restartGame();
            }
            if (e.KeyCode == Keys.E)
                Application.Exit();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (goRight)
                goRight = false;
            if (goLeft)
                goLeft = false;
            if (goUp)
                goUp = false;
            if (goDown)
                goDown = false;
        }

        private void GoRigth()
        {
            ball.Left += speed;
            spriteLeftRight++;
            if (spriteLeftRight == 5)
                spriteLeftRight = 1;
            updateSpriteLeftRight(spriteLeftRight);
        }
        private void GoLeft()
        {
            ball.Left -= speed;
            spriteLeftRight--;
            if (spriteLeftRight == 0)
                spriteLeftRight = 4;
            updateSpriteLeftRight(spriteLeftRight);
        }
        private void GoUp()
        {
            ball.Top -= speed;
            spriteUpDown++;
            if (spriteUpDown == 5)
                spriteUpDown = 1;
            updateSpriteUpDown(spriteUpDown);
        }
        private void GoDown()
        {
            ball.Top += speed;
            spriteUpDown--;
            if (spriteUpDown == 0)
                spriteUpDown = 4;
            updateSpriteUpDown(spriteUpDown);
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "coin")
                {
                    coinSprite(spriteCoin, x);
                    spriteCoin++;
                    if (spriteCoin == 7)
                        spriteCoin = 1;
                }
            }
        }
        private int coinSprite(int x, Control y)
        {
            if (x == 1)
                y.BackgroundImage = Properties.Resources.coin1;
            if (x == 2)
                y.BackgroundImage = Properties.Resources.coin2;
            if (x == 3)
                y.BackgroundImage = Properties.Resources.coin3;
            if (x == 4)
                y.BackgroundImage = Properties.Resources.coin4;
            if (x == 5)
                y.BackgroundImage = Properties.Resources.coin3;
            if (x == 6)
                y.BackgroundImage = Properties.Resources.coin2;
            return x++;
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {

            this.Text = "GHOST ATTACK! Level: " + level + " Score: " + score + " Enemy: " + enemyVolume + " AllCoins: " + allCoins;

            time++;

            if (time % 50 == 0 )
            {
                if (!placeBomb)
                {
                    makeBomb();
                    placeBomb = true;
                }
            }
          
                    
            if (enemyVolume == 0 && score == allCoins && ball.Bounds.IntersectsWith(finishBox.Bounds))
            {
                gameTimer.Stop();
                labelRestart.Text = "You Win! Press \"R\" to restart game!";
                labelRestart.Visible = true;
            }

            if (goRight)
                GoRigth();
            if (goLeft)
                GoLeft();
            if (goUp)
                GoUp();
            if (goDown)
                GoDown();
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    moveEnemy(x, level);
                    if (ball.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        gameTimer.Stop();
                        labelRestart.Text = "You Die! Press \"R\" to restart game!";
                        labelRestart.Visible = true;
                    }
                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && y.Tag == "bomb")
                        {
                            
                            if (ball.Bounds.IntersectsWith(y.Bounds) && y.Visible)
                            {
                                x.Dispose();
                                y.Dispose();
                                placeBomb = false;
                                enemyVolume--;
                                level++;
                                time = 0;
                            }
                            
                        }
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "grass")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (ball.Left >= x.Left && goLeft)
                            ball.Left = x.Left + ball.Width;
                        if (ball.Left <= x.Left && goRight)
                            ball.Left = x.Left - ball.Width;
                        if (ball.Top >= x.Top && goUp)
                            ball.Top = x.Top + ball.Height;
                        if (ball.Top <= x.Top && goDown)
                            ball.Top = x.Top - ball.Height;
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Dispose();
                        score++;
                        if (score % 2 == 0)
                        {
                            enemyVolume++;
                            makeEnemy();
                        }
                    }
                }
            }
            
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "sky")
                {
                    speedSky(x);
                    if (x.Left >= 800)
                    {
                        int temp = rand.Next(0, 551);
                        x.Left = 0 - x.Width;
                        x.Top = temp;
                    }
                }
            }
        }

        private int updateSpriteLeftRight(int x)
        {
            if (x == 1)
                ball.BackgroundImage = Properties.Resources.ball1;
            if (x == 2)
                ball.BackgroundImage = Properties.Resources.ball2;
            if (x == 3)
                ball.BackgroundImage = Properties.Resources.ball3;
            if (x == 4)
                ball.BackgroundImage = Properties.Resources.ball4;
            return x++;
        }
        private int updateSpriteUpDown(int x)
        {
            if (x == 1)
                ball.BackgroundImage = Properties.Resources.ball1;
            if (x == 2)
                ball.BackgroundImage = Properties.Resources.ball5;
            if (x == 3)
                ball.BackgroundImage = Properties.Resources.ball3;
            if (x == 4)
                ball.BackgroundImage = Properties.Resources.ball6;
            return x++;
        }


        private void moveEnemy(Control x, int lvl)
        {
            int y = rand.Next(-2, 3);
            int z = rand.Next(-2, 3);
            x.Left += y * lvl;
            x.Top += z * lvl;
        }

        private void speedSky(Control x)
        {
            int y = rand.Next(10, 20);
            x.Left += y;
        }

        private void spawnGold()
        {
            tempCoin = rand.Next(6, 11);
            for (int i = 0; i < tempCoin; i++)
            {
                makeGold();
                allCoins++;
            }
        }
        private void makeGold()
        {
            PictureBox gold = new PictureBox();
            gold.Tag = "coin";
            gold.BackgroundImage = Properties.Resources.coin1;
            gold.Left = rand.Next(60, 715);
            gold.Top = rand.Next(60, 465);
            gold.SizeMode = PictureBoxSizeMode.Zoom;
            gold.Size = new Size(25, 25);
            this.Controls.Add(gold);
            gold.BringToFront();
        }
        private void makeBomb()
        {
            PictureBox bomb = new PictureBox();
            bomb.Tag = "bomb";
            bomb.BackgroundImage = Properties.Resources.bomb;
            bomb.Left = rand.Next(150, 700);
            bomb.Top = rand.Next(150, 450);
            bomb.SizeMode = PictureBoxSizeMode.Zoom;
            bomb.Size = new Size(50, 50);
            this.Controls.Add(bomb);
            bomb.BringToFront();
        }

        private void makeEnemy()
        {
            PictureBox enemy = new PictureBox();
            enemy.Tag = "enemy";
            enemy.BackgroundImage = Properties.Resources.ghost;
            enemy.Left = rand.Next(150, 700);
            enemy.Top = rand.Next(150, 450);
            enemy.SizeMode = PictureBoxSizeMode.Zoom;
            enemy.Size = new Size(50, 50);
            this.Controls.Add(enemy);
            enemy.BringToFront();
        }

    }
}
