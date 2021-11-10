using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Gold
    {

        int RANDOMNUMBERGENERATOR = new Random().Next(1, 6);

        public Gold(int x, int y, TileType tileType, Tile[] tiles, char symbol = '$') : base(x,
                                                                                             y,
                                                                                             symbol,
                                                                                             tileType)
        {

        }

        private int GoldAmount(Character target)
        {
            return Math.Abs(X - target.X) + Math.Abs(Y - target.Y);
        }


    }


}
}
