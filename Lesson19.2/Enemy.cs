using Lesson19._2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19._2
{
    internal class Enemy
    {
        private Image image;
        public int X {  get; set; }
        public int Y { get; set; }
        public Enemy(int x, int y)
        {
            this.image = Resources.enemy;
            X = x;
            Y = y;
        }
        public Image GetImage() { return image; }
        public void Down()
        {
            Y += 10;
        }
    }
}
