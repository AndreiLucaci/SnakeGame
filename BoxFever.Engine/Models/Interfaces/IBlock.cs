using System.Drawing;

namespace BoxFever.Engine.Models.Interfaces
{
	public interface IBlock
	{
		int X { get; set; }
		int Y { get; set; }
		int PrevX { get; set; }
		int PrevY { get; set; }
		Color Color { get; set; }
	}
}
