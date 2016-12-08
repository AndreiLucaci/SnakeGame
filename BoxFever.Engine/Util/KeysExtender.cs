using System.Collections.Generic;
using System.Windows.Forms;

namespace BoxFever.EnginUtil
{
	public static class KeysExtender
	{
		private static readonly List<Keys> _player1Controls = new List<Keys> { Keys.Up, Keys.Down, Keys.Left, Keys.Right };

		public static bool IsPlayer1(this Keys key)
		{
			return _player1Controls.Contains(key);
		}

		public static bool IsValidInputKey(this Keys key)
			=> key == Keys.Up || key == Keys.Down || key == Keys.Left || key == Keys.Right
			   || key == Keys.W || key == Keys.S || key == Keys.A || key == Keys.D;
	}
}
