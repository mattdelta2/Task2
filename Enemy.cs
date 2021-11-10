using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2
{
      public abstract class Enemy
    {
        protected Random RANDOM_NUMBER_GENERATOR = new Random();

        protected Enemy(int _X, int _Y, TileType _TYPEOFFILE, string _SYMBOL, int _DAMAGE, int _STARTINGHP, int _MAXHP )
        {
            DAMAGE = _DAMAGE;
            HP = _STARTINGHP;
            MAXHP = _MAXHP; 

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

        public object HP { get; private set; }
        public int MAXHP { get; private set; }
        public object DAMAGE { get; private set; }

        public override string ToString()
        {
            string Info = GetType().Name + "\n";
            Info += "at [" + X.ToString() + "," + Y.ToString() + "] \n";
            Info += HP.ToString() + " HP \n";
            Info += "[" + DAMAGE.ToString() + "]";
            return Info;
        }

    }

    public class Goblin : Enemy
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
        private List<Tile> vision;
        public List<Tile> VISION
        {
            get { return vision; }
            set { vision = value; }


        }
        protected Random RANDOM_NUMBER_GENERATOR = new Random();




        public override MovementDirection ReturnMove(MovementDirtection CharacterMove = MovementDirtection.NoMovement)
        {
            int RandomTileIndex = RANDOM_NUMBER_GENERATOR.Next(0, VISION.Count);

            while (VISION[RandomTileIndex].TYPEOFFILE.Equals(typeof(EmptyTile)))
            {
                RandomTileIndex = RANDOM_NUMBER_GENERATOR.Next(0, VISION.Count);

            }

            if (VISION[RandomTileIndex].X > x) //moveRight
            {
                return MovementDirection.Right;


            }
            else if (VISION[RandomTileIndex].x < X) //MoveLeft
            {
                return MovementDirection.Left;
            }
            else if (VISION[RandomTileIndex].Y > y) //MoveDown
            {
                return MovementDirection.Down;
            }
            else if (VISION[RandomTileIndex].y < Y) //MoveUp
            {
                return MovementDirection.Up;
            }

            return MovementDirection.NoMovement;

        }
    }
    }


    public class Mage : Enemy
    {

            public Mage(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL = "G", int _DAMAGE = 5, int _STARTINGHP = 5, int _MAXHP = 5):
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
        private List<Tile> vision;
        public List<Tile> VISION
        {
            get { return vision; }
            set { vision = value; }


        }

        public object HP { get; private set; }
        public object DAMAGE { get; private set; }

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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string Info = GetType().Name + "\n";
            Info += "at [" + X.ToString() + "," + Y.ToString() + "] \n";
            Info += HP.ToString() + " HP \n";
            Info += "[" + DAMAGE.ToString() + "]";
            return Info;
        }
    }
    }
}
