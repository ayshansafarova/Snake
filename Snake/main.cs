using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class main
    {
        protected int x, y, width;
        public main()
        {
            width = 10;
        }

        /// <summary>
        /// bir child class-la diger child classin kesishib-kesihmemesini yoxlayir. 
        /// </summary>
        /// <param name="otherChild"></param>
        /// <returns>sert qaytarir</returns>
        public Boolean intersection(main otherChild)
        {
            int difX = Math.Abs(this.x - otherChild.x);
            int difY = Math.Abs(this.y - otherChild.y);

            if (difX >= 0 && difX < width && difY >= 0 && difY < width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}