﻿using System;
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
}
