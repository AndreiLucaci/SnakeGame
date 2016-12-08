using System.Drawing;
using BoxFever.Engine.Models;
using BoxFever.Engine.Models.Interfaces;

namespace BoxFever.Engine.Util
{
	public static class BlocksExtender
	{
		public static bool IsInProximityOf(this IBlock block1, IBlock block2)
		{
			var r1 = new Rectangle(block1.X, block1.Y, GameConstants.BlockSize, GameConstants.BlockSize);
			var r2 = new Rectangle(block2.X, block2.Y, GameConstants.BlockSize, GameConstants.BlockSize);
			return r1.IntersectsWith(r2);
		}
	}
}
