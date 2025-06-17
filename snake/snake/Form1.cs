using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        enum Direction { Up, Down, Left, Right }
        class SnakePart
        {
            public int X, Y;
        }

        List<SnakePart> snake = new List<SnakePart>();
        Direction direction = Direction.Right;
        List<Point> foodList = new List<Point>();
        int cellSize = 20;
        int gridSize = 25;
        int score = 0;
        Random rand = new Random();
        bool gameRunning = false;
        int selectedLevel = 2;
        bool ateFood = false;

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(gridSize * cellSize, gridSize * cellSize + menuStrip1.Height + statusStrip1.Height);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.Paint += Form1_Paint;
            timer1.Tick += Timer1_Tick;
        }

        private void StartGame()
        {
            snake.Clear();
            snake.Add(new SnakePart { X = 10, Y = 10 });
            direction = Direction.Right;
            score = 0;
            foodList.Clear();
            toolStripStatusLabel1.Text = $"счет: {score}";
            GenerateFood();

            switch (selectedLevel)
            {
                case 1: timer1.Interval = 250;
                    break;
                case 2: timer1.Interval = 150;
                    break;
                case 3: timer1.Interval = 75;
                    break;
            }

            уровеньToolStripMenuItem.Enabled = false;

            gameRunning = true;
            timer1.Start();
            this.Invalidate();
        }

        void GenerateFood()
        {
            while (foodList.Count < 2)
            {
                int x = rand.Next(gridSize);
                int y = rand.Next(gridSize);
                if (!snake.Any(s => s.X == x && s.Y == y) &&
                    !foodList.Any(f => f.X == x && f.Y == y))
                {
                    foodList.Add(new Point(x, y));
                    break;
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ateFood = false;

            SnakePart head = new SnakePart { X = snake[0].X, Y = snake[0].Y };

            switch (direction)
            {
                case Direction.Up: head.Y--; break;
                case Direction.Down: head.Y++; break;
                case Direction.Left: head.X--; break;
                case Direction.Right: head.X++; break;
            }

            if (head.X < 0 || head.Y < 0 || head.X >= gridSize || head.Y >= gridSize || snake.Any(s => s.X == head.X && s.Y == head.Y))
            {
                timer1.Stop();
                gameRunning = false;

                уровеньToolStripMenuItem.Enabled = true;

                MessageBox.Show($"игра окончена! счет: {score}");
                return;
            }

            snake.Insert(0, head);


            for (int i = 0; i < foodList.Count; i++)
            {
                if (head.X == foodList[i].X && head.Y == foodList[i].Y)
                {
                    foodList.RemoveAt(i);
                    score++;
                    toolStripStatusLabel1.Text = $"Счет: {score}";
                    ateFood = true;
                    break;
                }
            }

            if (!ateFood)
            {
                snake.RemoveAt(snake.Count - 1);
            }
            else
            {
                GenerateFood();
            }

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (snake.Count == 0)
                return;

            int offsetY = menuStrip1.Height;

            foreach (var food in foodList)
            {
                g.FillRectangle(Brushes.Red, food.X * cellSize, food.Y * cellSize + offsetY, cellSize, cellSize);
            }

            Brush snakeColor = Brushes.Green;

            foreach (var part in snake)
            {
                g.FillRectangle(snakeColor, part.X * cellSize, part.Y * cellSize + offsetY, cellSize, cellSize);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: if (direction != Direction.Down) direction = Direction.Up; break;
                case Keys.Down: if (direction != Direction.Up) direction = Direction.Down; break;
                case Keys.Left: if (direction != Direction.Right) direction = Direction.Left; break;
                case Keys.Right: if (direction != Direction.Left) direction = Direction.Right; break;
            }
        }


        private void новаяИграToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StartGame();
        }

        private void легкийToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!gameRunning)
                SetLevel(1);
            return;
        }

        private void среднийToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!gameRunning)
            SetLevel(2);
            return;
        }

        private void тяжелыйToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!gameRunning)
            SetLevel(3);
            return;
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void SetLevel(int level)
        {
            selectedLevel = level;

            легкийToolStripMenuItem.Checked = false;
            среднийToolStripMenuItem.Checked = false;
            тяжелыйToolStripMenuItem.Checked = false;

            switch (level)
            {
                case 1:
                    легкийToolStripMenuItem.Checked = true;
                    break;
                case 2:
                    среднийToolStripMenuItem.Checked = true;
                    break;
                case 3:
                    тяжелыйToolStripMenuItem.Checked = true;
                    break;
            }
        }
    }
}
