using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2
{
    public abstract class Tile
    {
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
        private TileType typeoftile;

        public TileType TYPEOFTILE
        {
            get { return typeoftile; }
            set { typeoftile = value; }


        }

        private string symbol;
        public string SYMBOL
        {
            get { return symbol; }
            set { symbol = value; }
        }


        public Tile(int _x, int _y,string _SYMBOL, TileType _TYPEOFTILE )
        {
            X = _x;
            Y = _y;
            SYMBOL = _SYMBOL;
            TYPEOFTILE = _TYPEOFTILE;


        }

        public static implicit operator Tile(Obstacle v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Tile(EmptyTile v)
        {
            throw new NotImplementedException();
        }

        protected Character(int _x, int _y, TileType _TYPEOFTILE, string _SYMBOL, int _HP, int _MAXHP, int _DAMAGE)
        {
            SYMBOL = _SYMBOL;
            HP
        }
    }
}
