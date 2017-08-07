using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Animal : main
    {
        Animal Tail;
        public Animal(int x, int y)
        {
            this.x = x;
            this.y = y;
            Tail = null;
        }
        public void draw(Graphics g)
        {
            if (Tail != null)
            {
                Tail.draw(g);
            }
            g.FillRectangle(new SolidBrush(Color.Blue), this.x, this.y, this.width, this.width);
        }
        public void setCoordinate(int x, int y)
        {
            if (Tail != null)
            {
                Tail.setCoordinate(this.x, this.y);
            }
            this.x = x;
            this.y = y;
        }

        public void setAgain()
        {
            if (Tail == null)
            {
                Tail = new Animal(this.x, this.y);
            }
            else
            {
                Tail.setAgain();
            }
        }

        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }
        public Animal getTail()
        {
            return Tail;
        }
    }
}
