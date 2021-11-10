using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2
{
    abstract class Item
    {
        
        
        
        

        
    }

    class Gold : Items
    {
        int RANDOMNUMBERGENERATOR = new Random().Next(1, 6);


        public Gold(int x, int y, TileType tileType, Tile[] tiles, string _symbol = "$") : base(x, y, _symbol, tileType)
        {

        }

        public int X { get; private set; }
        public int Y { get; private set; }

        private int GoldAmount(Character target)
        {
            return Math.Abs(X - target.X) + Math.Abs(Y - target.Y);
        }


    }
}

abstract class Items : Tile
    {
        public Items(int _x, int _y, TileType _TYPEOFTILE, string _SYMBOL = "#") : base(_x, _y, _SYMBOL, _TYPEOFTILE)
        {

        }

        public Items(int _x, int _y, string _SYMBOL, TileType _TYPEOFTILE) : base(_x, _y, _SYMBOL, _TYPEOFTILE)
        {
        }

        public override string ToString()
        {
            return $"Player Item:\r\nDamage:\r\n[{X},{Y}]";
        }
    }
}




