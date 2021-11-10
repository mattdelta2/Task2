namespace Task2
{
     class Obstacle
    {
        private int v;
        private int i;
        private object obstacle;

        public Obstacle(int v, int i, object obstacle)
        {
            this.v = v;
            this.i = i;
            this.obstacle = obstacle;
        }

        public Obstacle(int _X, int _Y, string _SYMBOL, TileType _TYPEOFTILE) 
        {

        }
    }
}