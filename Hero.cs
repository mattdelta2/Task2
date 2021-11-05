using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Hero
    {
        public Hero(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL, int _HP, int _MAXHP, int _DAMAGE )
        {

        }

        public int Y { get; private set; }
        public int X { get; private set; }
        public object FileType { get; private set; }
        public IEnumerable<Tile> VISION { get; private set; }
        public object DAMAGE { get; private set; }
        public object HP { get; private set; }
        public object MAXHP { get; private set; }

        public override MovementDirection ReturnMove(MovementDirection CharacterMove  = MovementDirection.NoMovement)
        {
            if (CheckForValidMove(CharacterMove))
            {
                return CharacterMove;

            }
            else return MovementDirection.NoMovement;

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
