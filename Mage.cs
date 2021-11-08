using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Mage
    {

        public Mage(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL = "G", int _DAMAGE = 5, int _STARTINGHP = 5, int _MAXHP = 5)
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





 
