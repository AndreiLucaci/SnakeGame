using System;
using System.Drawing;
using BoxFever.Engine.Models.Implementations;
using BoxFever.Engine.Models.Interfaces;
using BoxFever.Engine.Util;

namespace BoxFever.Engine.Models
{
	public class Board
	{
		public int Width { get; set; }
		public int Height { get; set; }

		private readonly int _cols;
		private readonly int _rows;

		public IBlock Food { get; set; }

		public Board(int width, int height)
		{
			Width = width/GameConstants.Scale;
			Height = height/GameConstants.Scale;

			_cols = Height - GameConstants.BlockSize;
			_rows = Width - GameConstants.BlockSize;

			PlaceRandomFood();
		}

		public void PlaceRandomFood()
		{
			var rnd = new Random();
			var rX = (int)Math.Floor((decimal) rnd.Next(0, _cols));
			var rY = (int)Math.Floor((decimal) rnd.Next(0, _rows));

			if (Food == null)
			{
				Food = new StationaryBlock {X = rX, Y = rY, Color = Color.Red};
			}
			else
			{
				Food.X = rX;
				Food.Y = rY;
			}
		}
	}
}
