using System.Drawing;
using BoxFever.Engine.Models.Interfaces;

namespace BoxFever.Engine.Models.Implementations
{
	public class StationaryBlock : IBlock
	{
		private int _x;
		private int _y;

		public int X
		{
			get { return _x; }
			set { PrevX = _x = value; }
		}

		public int Y
		{
			get { return _y; }
			set { PrevY = _y = value; }
		}

		public int PrevX { get; set; }
		public int PrevY { get; set; }
		public Color Color { get; set; }
	}
}
