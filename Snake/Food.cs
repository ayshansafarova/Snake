using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Food : main
    {
        public Food()
        {
            this.x = 50;
            this.y = 50;
        }
        public void draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Magenta), this.x, this.y, this.width, this.width);
        }
        /// <summary>
        /// bu her defe qidanin yerini "randomise" edir. Bu zaman qida her defesinde muxtelif yerlerde cixir.
        /// </summary>
        public void randomise()
        {
            Random random = new Random();
            this.x = random.Next(0, 92) * 10;
            this.y = random.Next(0, 48) * 10;
        }
    }
}