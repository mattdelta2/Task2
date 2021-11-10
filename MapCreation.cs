using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
     class MapCreation
    {
        private Tile[,] mapcontainer;
        public Tile[,] MAPCONTAINER
        {
            get { return mapcontainer; }
            set { mapcontainer = value; }
        }

        private Hero playercharacter;
        public Hero PLAYERCHARACTER
        {
            get { return playercharacter; }
            set { playercharacter = value; }
        }
        private List<Enemy> enemies;
        public List<Enemy> ENIMIES
        {
            get { return enemies; }
            set { enemies = value; }

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

        public int MAPWIDTH { get; private set; }
        public int MAPHEIGHT { get; private set; }

        protected Random RANDOM_NUMBER_GENERATOR = new Random();
        private int _NUMBEROFENEMIES;

        public MapCreation(int _MINWIDTH, int _MINHEIGHT, int _MAXWIDTH, int _MAXHEIGHT, int _NUMBEROFENEMIES)
        {
            MAPWIDTH = RANDOM_NUMBER_GENERATOR.Next(_MINWIDTH, _MAXWIDTH);
            MAPHEIGHT = RANDOM_NUMBER_GENERATOR.Next(_MINHEIGHT, _MAXHEIGHT);
            MAPCONTAINER = new Tile[MAPWIDTH, MAPHEIGHT];
            ENIMIES = new List<Enemy>();
            UpdateVision();
            
            
        }

        public void UpdateVision()
        {
            foreach (Enemy E in ENIMIES)
            {
                E.VISION.Clear();
                if (E.X > 0)
                {
                    E.VISION.Add(MAPCONTAINER[E.X - 1, E.Y]);

                }
            }
        }


        private Create(TileType.Hero)

        {
            for(int e = 0; e< _NUMBEROFENEMIES; e++)
            {
                Create(TileType.Enemy);
                return TileType.Enemy;
            }
        }

        public void Create(TileType TypeOfTile, int X = 0, int Y = 0)
        {
            switch(TypeOfTile)
            {
                case TileType.Barrier:
                    Obstacle NewBarrier = new Obstacle(X, Y, " ", TypeOfTile);
                    MAPCONTAINER[X, Y] = NewBarrier;
                    break;
                case TileType.Enemy:
                    EmptyTile NewEmptyTile = new EmptyTile(X, Y, " ", TypeOfTile);
                    MAPCONTAINER[X, Y] = NewEmptyTile;
                    break;

                case TileType.Hero:
                    int HeroY = RANDOM_NUMBER_GENERATOR.Next(1, MAPWIDTH);
                    int HeroX = RANDOM_NUMBER_GENERATOR.Next(1, MAPHEIGHT);
                    while (MAPCONTAINER[HeroX, HeroY].TYPEOFTILE != TileType.Empty)
                    {
                        HeroX = RANDOM_NUMBER_GENERATOR.Next(0, MAPWIDTH);
                        HeroY = RANDOM_NUMBER_GENERATOR.Next(0, MAPHEIGHT);
                    }
            }
            
        }

        


    }
}
