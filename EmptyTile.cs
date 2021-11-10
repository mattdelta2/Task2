using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class EmptyTile
    {
        private int i;
        private int j;
        private TileType empty;

        public EmptyTile(int i, int j, TileType empty)
        {
            this.i = i;
            this.j = j;
            this.empty = empty;
        }

        public EmptyTile(int _X, int _Y, string _SYMBOL, TileType _TYPEOFTILE)
        { 

        }
    }
}
