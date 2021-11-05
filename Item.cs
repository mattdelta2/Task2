using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Item
    {
        public Item(int _X, int _Y)
        {

        }
        
            private int x;
        public int _X
        {
            get { return x; }
            set { _X = value; }

        }
        private int y;
        public int _Y
        {
            get { return y; }
            set { _Y = value; }

        }
    }
}


