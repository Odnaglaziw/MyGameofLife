using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameofLife
{
    public partial class Form1 : Form
    {
        LifeGame game;
        int cellSize = 8;
        Timer timer;
        PanelX screen;
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            S_speed.Minimum = 16;
            S_speed.Maximum = 250;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            screen = new PanelX()
            {
                Location = Screen.Location,
                Parent = this,
                Size = Screen.Size
            };
            Controls.Add(screen);
            Screen.Dispose();
            game = new LifeGame(screen.Width/cellSize,screen.Height/cellSize);
            screen.Paint += Screen_Paint;
            screen.MouseClick += Screen_MouseClick;
            timer = new Timer();
            timer.Interval = 16;
            timer.Tick += (s, ev) =>
            {
                screen.Invalidate();
            };
            timer.Start();
        }

        private void Screen_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X/cellSize;
            int y = e.Y/cellSize;
            game.Alive(x, y);
        }

        private void Screen_Paint(object sender, PaintEventArgs e)
        {
            bool[,] states = game.State;
            Graphics g = e.Graphics;
            for (int y = 0; y < states.GetLength(1); y++)
            {
                for (int x = 0; x < states.GetLength(0); x++)
                {
                    if (states[x, y]) g.FillRectangle(Brushes.Black,x*cellSize,y*cellSize,cellSize,cellSize);
                    else g.DrawRectangle(Pens.Black, x * cellSize, y * cellSize, cellSize, cellSize);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (game != null) game.Enabled = checkBox1.Checked;
        }

        private void S_speed_Scroll(object sender, ScrollEventArgs e)
        {
            if (game != null) game.Speed = e.NewValue;
        }
    }
}
