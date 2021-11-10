using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MapCreation
    {/*
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

        public void Create(TileType TypeOfTile, int X = 0, int Y = 0)
        {
            switch (TypeOfTile)
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


                    private void Create(TileType.Hero)
                    {


                        for (int e = 0; e < _NUMBEROFENEMIES; e++)
                        {
                            Create(TileType.Enemy);

                        }
                    }
        

       
            
        

        


        */

        private Random RANDOMNUMBERGENERATOR;
        public Tile[,] Map;
        private Hero Character;
        public Hero CHARACTER
        {
            get { return Character; }
            set { Character = value; }
        }

        private int Enemies;
        private int GoldDrop;


        private List<Character> characters;
        public List<Character> CHARACTERS
        {
            get { return characters; }
            set { characters = value; }
        }

        private int mapwidth;
        public int MAPWIDTH

        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }

        private int mapheight;
        public int MAPHEIGHT

        {
            get { return mapheight; }
            set { mapheight = value; }
        }

        public MapCreation(int enemies, int _MAPWIDTH, int _MAPHEIGHT, int _GoldDrops)
        {
            CHARACTERS = new List<Character>();
            RANDOMNUMBERGENERATOR = new Random();
            Enemies = enemies;
            GoldDrop = _GoldDrops;
            this.MAPWIDTH = _MAPWIDTH;
            this.MAPHEIGHT = _MAPHEIGHT;
            CreateMap();
            RendorMap();
            SpawnGold();
        }


        private void initMap()
        {
            Map = new Tile[MAPWIDTH, MAPHEIGHT];
            for (int a = 0; a < MAPWIDTH; a++)
            {
                for (int s = 0; s < MAPHEIGHT; s++)
                {
                    Map[a, s] = new EmptyTile(a, s, TileType.Empty);
                }
            }
        }


        public void UpdateVision(Character CHARACTERS)
        {
            CHARACTER.VISION[0] = Map[CHARACTER.X, CHARACTER.Y + 1];
            CHARACTER.VISION[1] = Map[CHARACTER.X + 1, CHARACTER.Y];
            CHARACTER.VISION[2] = Map[CHARACTER.X, CHARACTER.Y - 1];
            CHARACTER.VISION[3] = Map[CHARACTER.X - 1, CHARACTER.Y];

        }

        private void CreateMap()
        {
            Map = new Tile[MAPWIDTH, MAPHEIGHT];
            initMap();
            drawBorders(MAPWIDTH, MAPHEIGHT);
            Hero = new Hero(0, 0, TileType.Hero, 50, 50, new Tile[])
            {


            };
            CHARACTERS.Add(Hero);
            RandomlyPlaceObject(Hero);
            for (int a = 0; a < Enemies; a++)
            {
                var gold = SpawnGold();
                RandomlyPlaceObject(gold);
            }

            for (int k = 0; k < Enemieslk++)
            {
                var Goblin = CreateGoblin();
                CHARACTERS.Add(Hero);
                RandomlyPlaceObject(Goblin);

                var Mage = CreateMage();
                CHARACTERS.Add(Hero);
                RandomlyPlaceObject(Mage);


            }

            CHARACTERS.ForEach(UpdateVision);


        }

        private char[,] RenderMap()
        {
            char[,] res = new char[MAPWIDTH, MAPHEIGHT];
            for (int i = 0; i < MAPWIDTH; i++)
            {
                for (int j = 0; j < MAPHEIGHT; j++)
                {
                    res[i, j] = Map[i, j].SYMBOL;
                }
            }

            return res;
        }

        private void drawBorders(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                Map[i, 0] = new Obstacle(0, i, TileType.Obstacle);
                Map[y - 1, i] = new Obstacle(0, i, TileType.Obstacle);
            }

            for (int i = 0; i < y; i++)
            {
                Map[0, i] = new Obstacle(0, i, TileType.Obstacle);
                Map[x - 1, i] = new Obstacle(0, i, TileType.Obstacle);
            }
        }

        private Goblin CreateGoblin()
        {

            return new Goblin(0, 0, TileType.Enemy, new Tile[]
            {
                null,null,null,null
            });
        }

        private Mage CreateMage()
        {

            return new Mage(0, 0, TileType.Enemy, new Tile[]
            {
                null,null,null,null
            });
        }


        private void randomlyPlaceObject(Tile tile)
        {

            var x = RANDOMNUMBERGENERATOR.Next(0 + 1, MAPWIDTH - 1);
            var y = RANDOMNUMBERGENERATOR.Next(0 + 1, MAPHEIGHT - 1);
            if (Map[x, y].TileType == TileType.Empty)
            {
                tile.X = x;
                tile.Y = y;
                Map[x, y] = tile;
            }
            else
            {
                randomlyPlaceObject(tile);
            }
        }

        private Gold SpawnGold()
        {
            return new Gold(0, 0, TileType.Enemy, new Tile[]
            {
                null,null,null,null
            });
        }
        public Items GetItemAtPosition()
        {

            return new Gold(0, 0, TileType.Enemy, new Tile[]
            {
                null,null,null,null
            });







        }
    }
