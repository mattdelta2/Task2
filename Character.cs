using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Character
    {
        protected int hp;
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        protected int maxhp;
        public int MAXHP
        {
            get { return maxhp; }
            set { maxhp = value; }
        }

        protected int damage;
        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
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




        public Character(int _X, int _Y,string _SYMBOL, TileType _TYPEOFTILE, int _HP, int _MAXHP, int _DAMAGE)
        {
            X = _X;
            Y = _Y;
            SYMBOL = _SYMBOL;
            TYPEOFTILE = _TYPEOFTILE;
            HP = _HP;
            MAXHP = _MAXHP;
            DAMAGE = _DAMAGE;
            VISION = new List<Tile>();
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
            if (DistanceTo(Target) <= ReachableDistance)
            {
                return true;
            }
            else return false;
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
    }
}
