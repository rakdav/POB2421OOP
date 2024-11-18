using Lesson19._2.Properties;
using System;

namespace Lesson19._2
{
    public partial class FormGame : Form
    {
        private Player player;
        private Random random;
        private int countEnemy = 5;
        private List<Enemy> enemies;
        private List<PictureBox> pictureBoxes;
        public FormGame()
        {
            InitializeComponent();
            enemies = new List<Enemy>(countEnemy);
            pictureBoxes = new List<PictureBox>(countEnemy);
            player = new Player(Resources.plain, 500, 700);
            random = new Random();
            UpdatePlayer();
            StartGame();
            timer1.Start();
        }
        private void StartGame()
        {
            for (int i = 0; i < enemies.Capacity; i++)
            {
                PictureBox pictureBox = new PictureBox();
                Enemy enemy = new Enemy(random.Next(0, this.Width-pictureBox.Width), -random.Next(600));
                pictureBox.Image = enemy.GetImage();
                pictureBox.Location = new Point(enemy.X, enemy.Y);
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pictureBox);
                pictureBoxes.Add(pictureBox);
                enemies.Add(enemy);   
            }
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        player.Up();

                    }
                    break;
                case Keys.Down:
                    {
                        player.Down();
                    }
                    break;
                case Keys.Left:
                    {
                        player.Left();
                    }
                    break;
                case Keys.Right:
                    {
                        player.Right();
                    }
                    break;
            }
            UpdatePlayer();
        }
        private void UpdatePlayer()
        {
            pictureBoxPlayer.Location = new Point(player.X, player.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Down();
                pictureBoxes[i].Location = new Point(enemies[i].X, enemies[i].Y);
                if (enemies[i].Y > this.Height + pictureBoxes[i].Height)
                {
                    enemies[i].X = random.Next(0, this.Width - pictureBoxes[i].Width);
                    enemies[i].Y = -random.Next(600);
                }
            }
           
        }
    }
}
