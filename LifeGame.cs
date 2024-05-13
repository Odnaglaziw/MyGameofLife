using System;
using System.Windows.Forms;

namespace GameofLife
{
    public class LifeGame
    {
        Timer timer;
        bool[,] cellsState;
        public bool Enabled
        {
            get 
            {
                if (timer != null) return timer.Enabled;
                else return false;
            }
            set
            {
                if (timer != null)
                {
                    if (value)
                    {
                        timer.Start();
                    }
                    else
                    {
                        timer.Stop();
                    }
                }
            }
        }
        public bool[,] State
        {
            get { return cellsState; }
        }
        public int Speed
        {
            get
            {
                if (timer != null) return timer.Interval;
                else return -1;
            }
            set
            {
                if (timer != null) timer.Interval = value;
                else throw new InvalidOperationException("Таймер не объявлен.");
            }
        }
        public LifeGame(int width, int height)
        {
            Init(width,height,100);
        }
        public LifeGame(int width, int height, int speed)
        {
            Init(width,height,speed);
        }
        void Init(int width, int height, int speed)
        {
            timer = new Timer()
            {
                Interval = speed,
                Enabled = false,
            };
            timer.Tick += NextGen;
            cellsState = new bool[width,height];
        }
        public void NextGen(object sender, EventArgs e)
        {
            int width = cellsState.GetLength(0);
            int height = cellsState.GetLength(1);
            int[,] livingNeighbor = new int[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int livingNeighbors = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (j == 0 && i == 0) continue;

                            int _x = x + i;
                            int _y = y + j;

                            if (_x < 0 || _x >= width || _y < 0 || _y >= height) continue;

                            if (cellsState[_x, _y])
                                livingNeighbors++;
                        }
                    }
                    livingNeighbor[x, y] = livingNeighbors;
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int livingNeighbors = livingNeighbor[x, y];

                    if (cellsState[x, y])
                    {
                        if (livingNeighbors == 2 || livingNeighbors == 3)
                            cellsState[x, y] = true;
                        else
                            cellsState[x, y] = false;
                    }
                    else
                    {
                        if (livingNeighbors == 3)
                            cellsState[x, y] = true;
                    }
                }
            }
        }
        public void Alive(int x, int y)
        {
            cellsState[x, y] = true;
        }
    }
}
