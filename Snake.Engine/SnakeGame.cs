using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Snake.Engine.Models;

namespace Snake.Engine
{
	public partial class SnakeGame : Form
	{
		private readonly Board _board;
		private readonly Models.Snake _snake;
		private int _time = 100;
		private int _score;

		public SnakeGame()
		{
			InitializeComponent();
			_board = new Board(board.Width, board.Height);
			_snake = new Models.Snake(Board.Scale, _board.Width, _board.Height);
			Task.Factory.StartNew(Draw, TaskCreationOptions.LongRunning);
			PaintFood();
			board.Focus();
		}

		private void PaintFood()
		{
			Task.Factory.StartNew(() =>
			{
				PaintBlock(_board.Food.X, _board.Food.Y, Color.Red);
			});
		}

		private void Draw()
		{
			while (true)
			{
				Thread.Sleep(_time);
				UpdateView();
			}
		}

		private void UpdateView()
		{
			_snake.Update();
			DrawRectangle(_snake.X, _snake.Y);
		}

		private void DrawRectangle(int x, int y)
		{
			Invoke(PaintBlock(x, y, Color.Black));
		}

		private Action PaintBlock(int x, int y, Color color)
		{
			return () =>
			{
				using (var g = board.CreateGraphics())
				{
					g.Clear(board.BackColor);
					var pen = new Pen(color, 2);
					var food = new Pen(Color.Red, 2);
					var brush = new SolidBrush(BackColor);

					g.FillRectangle(brush, board.Bounds);
					g.DrawRectangle(food, _board.Food.X * Board.Scale, _board.Food.Y * Board.Scale, Board.Scale, Board.Scale);
					g.DrawRectangle(pen, x*Board.Scale, y*Board.Scale, Board.Scale, Board.Scale);

					if (x == _board.Food.X && y == _board.Food.Y)
					{
						_board.PlaceRandomFood();
						Score();
					}

					pen.Dispose();
					brush.Dispose();
				}
			};
		}

		private void Score()
		{
			_score++;
			socre_lbl.Text = $"Score: {_score}";
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			Direction direction;
			switch (e.KeyCode)
			{
				case Keys.Up:
					direction =  Direction.UP;
					break;
				case Keys.Down:
					direction = Direction.DOWN;
					break;
				case Keys.Left:
					direction = Direction.LEFT;
					break;
				case Keys.Right:
					direction = Direction.RIGHT;
					break;
				default:
					direction = Direction.Same;
					break;
			}
			_snake.CurretnDirection = direction;
			e.Handled = true;
		}

		private void plus10_Click(object sender, EventArgs e)
		{
			_time = _time < 1000 ? _time + 10 : _time;
			time_lbl.Text = _time.ToString();
		}

		private void minus10_Click(object sender, EventArgs e)
		{
			_time = _time > 10 ? _time - 10 : _time;
			time_lbl.Text = _time.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (Control control in this.Controls)
			{
				control.PreviewKeyDown += new PreviewKeyDownEventHandler(Control_PreviewKeyDown);
			}
		}

		void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
			{
				e.IsInputKey = true;
			}
		}
	}
}
