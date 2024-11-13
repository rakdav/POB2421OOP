using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19._2
{
    internal class Player
    {
        public int X {  get; set; }
        public int Y { get; set; }
        private Image image;
        public Player(Image _image,int _x,int _y) 
        {
            image = _image;
            X = _x;
            Y = _y;
        }
        public void Up()
        {
            Y -= 10;
        }
        public void Down() 
        {
            Y += 10;
        }
        public void Left()
        {
            X -= 10;
        }
        public void Right() 
        {
            X+= 10;
        }
    }
}
