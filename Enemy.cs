using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
