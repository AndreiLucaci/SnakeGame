using System;
using System.Collections.Generic;
using System.Drawing;
using BoxFever.Engine.Models.Interfaces;

namespace BoxFever.Engine.Models
{
	public class Player : IBlock
	{
		private readonly int _bordWidth;
		private readonly int _bordHeight;
		private Direction _currentDirection;
		private int _score;

		public string Name { get; set; }

		public Direction CurrentDirection
		{
			get { return _currentDirection; }
			set { Direction(value); }
		}

		public int Score
		{
			get { return _score; }
			set
			{
				_score = value;
				PlayerScores?.Invoke(this, new PlayerScoresEventArgs(value));
			}
		}

		public int X { get; set; }
		public int Y { get; set; }
		public int PrevX { get; set; }
		public int PrevY { get; set; }
		public Color Color { get; set; }
		public int MX { get; set; }
		public int MY { get; set; }

		public event EventHandler<PlayerScoresEventArgs> PlayerScores;

		public Player(int bordWidth, int bordHeight, string name, Color color)
		{
			Name = name;
			Color = color;
			_bordWidth = bordWidth -1;
			_bordHeight = bordHeight -1;
			X = 0;
			Y = 0;
			MX = 1;
			MY = 0;
			_currentDirection = Models.Direction.LEFT;
		}

		public void Update()
		{
			PrevX = X;
			PrevY = Y;
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
				_currentDirection = direction;
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
			return _opositeDirections[direction] == _currentDirection;
		}

		public override string ToString()
		{
			return Name;
		}
	}

	public class PlayerScoresEventArgs : EventArgs
	{
		public readonly int Value;

		public PlayerScoresEventArgs(int value)
		{
			Value = value;
		}
	}
}
