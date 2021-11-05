using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
        public abstract class Goblin
    {

        

        public Goblin(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL = "G", int _DAMAGE = 1, int _STARTINGHP = 10, int _MAXHP = 10) :
            base(_X, _Y, _TYPEOFTILE, _SYMBOL, _DAMAGE, _STARTINGHP, _MAXHP)
        {
            

        }
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


        public Tile(int _x, int _y, string _SYMBOL, TileType _TYPEOFTILE)
        {
            X = _x;
            Y = _y;
            SYMBOL = _SYMBOL;
            TYPEOFTILE = _TYPEOFTILE;


        }




        public override MovementDirection ReturnMove(MovementDirtection CharacterMove = MovementDirtection.NoMovement)
        {
            int RandomTileIndex = RANDOM_NUMBER_GENERATOR.Next(0, VISION.Count);

            while (VISION[RandomTileIndex].TYPEOFFILE.Equals(typeof(EmptyTile)))
            {
                RandomTileIndex = RANDOM_NUMBER_GENERATOR.Next(0, VISION.Count);

            }

            if (VISION[RandomTileIndex].X > x ) //moveRight
            {
                return MovementDirection.Right;


            }
            else if (VISION[RandomTileIndex].x < X) //MoveLeft
            {
                return MovementDirection.Left;
            }
            else if(VISION[RandomTileIndex].Y > y) //MoveDown
            {
                return MovementDirection.Down;
            }
            else if(VISION[RandomTileIndex].y < Y) //MoveUp
            {
                return MovementDirection.Up;
            }

            return MovementDirection.NoMovement;

        }
    }
}
