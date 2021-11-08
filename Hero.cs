using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Hero : HeroBase
    {
        public Hero(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL, int _HP, int _MAXHP, int _DAMAGE )
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
        private List<Tile> vision;
        public List<Tile> VISION
        {
            get { return vision; }
            set { vision = value; }


        }

        private MovementDirtection movement;
        public MovementDirtection MOVEMENT
        {
            get { return movement; }
            set { movement = value; }
        }

        private bool CheckForValidMove(MovementDirection characterMove)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string INFO = "Player Stats: \n";
            INFO += "HP: " + HP.ToString() + "/" + MAXHP.ToString() + "\n";
            INFO += "Damage: " + DAMAGE.ToString();
        }

        bool CheckForValidMovement(MovementDirection CharacterMove)
        {
            bool IsValid = false;
            switch (CharacterMove)
            {
                case MovementDirection.Right:
                    foreach (Tile T in VISION)
                    {
                        if(T.X == X +1)
                        {
                            if(T.TYPEOFTILE == FileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }
                    break;

                case MovementDirection.Up:
                    foreach (Tile T in VISION)
                    {
                        if(T.Y == Y +1)
                        {
                            if(T.TYPEOFTILE == FileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }
                    break;
                case MovementDirection.Left:
                    foreach (Tile T in VISION)
                    {
                        if(T.X == X -1)
                        {
                            if (T.TYPEOFTILE == FileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }
                    break;

                case MovementDirection.Down:
                    foreach (Tile T in VISION)
                    {
                        if(T.Y == Y-1)
                        {
                            if(T.TYPEOFTILE == FileType.Empty)
                            {
                                IsValid = true;
                                break;

                            }
                        }
                    }
                    break;

            }
        }

    }
}
