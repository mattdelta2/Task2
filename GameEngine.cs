using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GameEngine
    {
        private Random RANDOMNUMBERGENERATOR;
        public Tile[,] Map;

        private Hero hero;

        public Hero Hero
        {
            get { return hero; }
            set { hero = value; }
        }



        private int Enemies;

        private int GoldSpawn;

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


        public int X { get; private set; }
        public int Y { get; private set; }

        public GameEngine(int _enemies, int _MAPWIDTH, int _MAPHEIGHT, int _SPAWNGOLD)
        {
            CHARACTERS = new List<Character>();
            RANDOMNUMBERGENERATOR = new Random();
            Enemies = _enemies;
            GoldSpawn = _SPAWNGOLD;
            this.MAPWIDTH = _MAPWIDTH;
            this.MAPHEIGHT = _MAPHEIGHT;
            CreateMap();
            SpawnGold();
        }

        private void CreateMap()
        {
            throw new NotImplementedException();
        }

        private void SpawnGold()
        {
            throw new NotImplementedException();
        }

        private void initEngine()
        {
            Map = new Tile[MAPWIDTH, MAPHEIGHT];
            for (int i = 0; i < MAPWIDTH; i++)
            {
                for (int j = 0; j < MAPHEIGHT; j++)
                {
                    Map[i, j] = new EmptyTile(i, j, TileType.Empty);
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
            initEngine();

            Hero = new Hero(0, 0, TileType.Hero,
                50, 50, new Tile[]
                {
                    
                });
            CHARACTERS.Add((Character)Hero);
            randomlyPlaceObject(Hero);
            for (int i = 0; i < GoldSpawn; i++)
            {
                var gold = SpawnGold();
                randomlyPlaceObject(gold);

            }

            for (int i = 0; i < Enemies; i++)
            {
                var goblin = CreateGoblin();
                CHARACTERS.Add(goblin);
                randomlyPlaceObject(goblin);

                var mage = CreateMage();
                CHARACTERS.Add(mage);
                randomlyPlaceObject(mage);



            }

            CHARACTERS.ForEach(UpdateVision);

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

        private Gold spawnGold()
        {
            return new Gold(0, 0, TileType.Enemy, new Tile[]
            {
                null,null,null,null
            });
        }


        private void MovePlayer(Movement MoveChar)
        {
            switch (MoveChar)
            {
                case MoveChar.Down:
                    Y -= 1;

                    break;

                case MoveChar.Left:

                    X -= 1;

                    break;

                case MoveChar.Right:
                    X += 1;

                    break;

                case MoveChar.Up:
                    Y += 1;

                    break;

                case MoveChar.noMovement:

                    break;

            }
            if (TileType == '$')
            {
                for (int i = 0; i < 10; i++)
                {

                }
            }

        }


        private void MoveEnemies()
        {
            foreach (Character character in CHARACTERS)
            {
                if (typeof(Action).IsAssignableFrom(typeof(Mage)))
                {
                    CHARACTERS.ForEach(UpdateVision);
                }

                else if (typeof(Action).IsAssignableFrom(typeof(Goblin)))
                {
                    character.Move();
                    CHARACTERS.ForEach(UpdateVision);
                }
            }
        }


        private void EnemyAttacks()
        {
            foreach (Character actor in CHARACTERS)
            {
                if (typeof(Action).IsAssignableFrom(typeof(Mage)))
                {
                    actor.Attack();

                }

                else if (typeof(Action).IsAssignableFrom(typeof(Goblin)))
                {
                    actor.Attack();
                }
            }
        }
    



        Load()
        {

        }

        Save()
        {

        }
    }
}
