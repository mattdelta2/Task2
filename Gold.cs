using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Gold
    {

        private int GOLD;

        public int gold
        {
            get { return GOLD; }
            set { gold = value; }
        }

        protected Random RANDOM_NUMBER_GENERATOR = new Random();

        protected int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int y;
        public int Y
        {
            get { return y; }
            set { y = value; }

        }


    }
}
