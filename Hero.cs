using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Hero
    {
        public Hero(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL, int _HP, int _MAXHP, int _DAMAGE)
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

        public Hero(int x, int y, TileType tYPEOFTILE, string sYMBOL)
        {
            this.x = x;
            this.y = y;
            typeoftile = tYPEOFTILE;
            symbol = sYMBOL;
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

        private int DistanceTo(Character target)
        {
            return Math.Abs(X - target.X) + Math.Abs(Y - target.Y);
        }

        public void Move(MovementDirtection CharacterMove)
        {
            switch (CharacterMove)
            {
                case MovementDirtection.Up:
                    Y--;
                    break;
                case MovementDirtection.Down:
                    Y++;
                    break;
                case MovementDirtection.Left:
                    X--;
                    break;
                case MovementDirtection.Right:
                    X++;
                    break;

            }

        }

        public abstract MovementDirtection ReturnMove(MovementDirtection CharacterMove = 0);
        public abstract override string ToString();


        public static void Pickup(Item i)
        {

        }
    }
    public class Character : Hero
    {
        public Character(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL, int _HP, int _MAXHP, int _DAMAGE) :
        base(_X, _Y, _TYPEOFTILE, _SYMBOL)
        {


        }

        public virtual void Attack(Character Target)
        {
            Target.HP -= DAMAGE;
        }

        public bool IsDead()
        {
            if (HP <= 0)
            {
                return true;
            }
            else return false;
        }

        public virtual bool CheckRange(Character Target)
        {
            int ReachableDistance = 1;
            if (DistanceTo(Target) > ReachableDistance)
                return false;
            else
            {
                return true;
            }
        }

        private int DistanceTo(Character target)
        {
            return Math.Abs(X - target.X) + Math.Abs(Y - target.Y);
        }

        public abstract override string ToString();
    }


}
