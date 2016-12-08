using System;

namespace BoxFever.Engine.Models
{
	public class Board
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public static int Scale { get; set; } = 5;

		private readonly int _cols;
		private readonly int _rows;

		public Block Food { get; set; }

		public Board(int width, int height)
		{
			Width = width/Scale;
			Height = height/Scale;

			_cols = Height;
			_rows = Width;

			PlaceRandomFood();
		}

		public void PlaceRandomFood()
		{
			var rnd = new Random();
			var rX = (int)Math.Floor((decimal) rnd.Next(0, _cols));
			var rY = (int)Math.Floor((decimal) rnd.Next(0, _rows));

			Food = new Block {X = rX, Y = rY};
		}
	}
}
