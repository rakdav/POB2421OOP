using Lesson19._2.Properties;

namespace Lesson19._2
{
    public partial class FormGame : Form
    {
        private Player player;
        private Random random;
        public FormGame()
        {
            InitializeComponent();
            player=new Player(Resources.plain,500,700);
            random = new Random();
            UpdatePlayer();
            StartGame();
        }
        private void StartGame()
        {
            Enemy enemy = new Enemy(random.Next(0, this.Width), 0);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = enemy.GetImage();
            pictureBox.Location = new Point(enemy.X, enemy.Y);
            pictureBox.Width = 100;
            pictureBox.Height = 100;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox);
            while (true)
            {
                enemy.Down();
                pictureBox.Location = new Point(enemy.X, enemy.Y);
                Thread.Sleep(1000);
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
    }
}
