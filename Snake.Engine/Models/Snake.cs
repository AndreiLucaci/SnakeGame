using System;
using System.Collections.Generic;

namespace Snake.Engine.Models
{
	public class Snake
	{
		private readonly int _scale;
		private readonly int _bordWidth;
		private readonly int _bordHeight;
		private Direction _curretnDirection;

		public Direction CurretnDirection
		{
			get { return _curretnDirection; }
			set { Direction(value); }
		}

		public int X { get; set; }
		public int Y { get; set; }
		public int MX { get; set; }
		public int MY { get; set; }

		public Snake(int scale, int bordWidth, int bordHeight)
		{
			_scale = scale;
			_bordWidth = bordWidth;
			_bordHeight = bordHeight;
			X = 0;
			Y = 0;
			MX = 1;
			MY = 0;
			_curretnDirection = Models.Direction.LEFT;
		}

		public void Update()
		{
			X = ((X + MX) + _bordWidth) % _bordWidth; 
			Y = ((Y + MY) + _bordHeight) % _bordHeight;
		}

		public void Direction(Direction direction)
		{
			if (!IsOppositeDirection(direction))
			{
				switch (direction)
				{
					case Models.Direction.UP:
						MX = 0;
						MY = -1;
						break;
					case Models.Direction.DOWN:
						MX = 0;
						MY = 1;
						break;
					case Models.Direction.RIGHT:
						MX = 1;
						MY = 0;
						break;
					case Models.Direction.LEFT:
						MX = -1;
						MY = 0;
						break;
					case Models.Direction.Same:
						MX = MX;
						MY = MY;
						break;
					default:
						throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
				}
				_curretnDirection = direction;
			}
		}

		private static readonly Dictionary<Direction, Direction> _opositeDirections = new Dictionary<Direction, Direction>
		{
			{Models.Direction.UP, Models.Direction.DOWN },
			{Models.Direction.DOWN, Models.Direction.UP },
			{Models.Direction.LEFT, Models.Direction.RIGHT },
			{Models.Direction.RIGHT, Models.Direction.LEFT },
			{Models.Direction.Same, Models.Direction.Same }
		}; 

		private bool IsOppositeDirection(Direction direction)
		{
			return _opositeDirections[direction] == _curretnDirection;
		}
	}
}
