using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoxFever.Engine.Models;
using BoxFever.Engine.Models.Interfaces;
using BoxFever.Engine.Util;
using BoxFever.EnginUtil;

namespace BoxFever.Engine
{
	public partial class BoxFeverGame : Form
	{
		private Board _board;
		private Player _player1;
		private Player _player2;
		private readonly List<IBlock> _entities = new List<IBlock>();
		
		private Task _gameTask;
		private CancellationTokenSource _tokenSource;
		private CancellationToken _cancellationToken;

		public const int TOTAL_TIME = 60 * 1;
		private int _gameTime = TOTAL_TIME;

		public const int TIME = 50;

		public BoxFeverGame()
		{
			InitializeComponent();
			InitializeEntities();

			ResetGame();
		}

		private void InitializeEntities()
		{
			_board = new Board(board.Width, board.Height);
			_player1 = new Player(_board.Width, _board.Height, "Player 1", Color.Black);
			_player2 = new Player(_board.Width, _board.Height, "Player 2", Color.Blue);

			_entities.AddRange(new[] { _player1, _player2, _board.Food });

			_player1.PlayerScores += (sender, args) => player1_score_lbl.Text = args.Value.ToString();
			_player2.PlayerScores += (sender, args) => player2_score_lbl.Text = args.Value.ToString();
		}

		private void Draw(CancellationToken token)
		{
			while (!token.IsCancellationRequested)
			{
				if (token.IsCancellationRequested)
				{
					token.ThrowIfCancellationRequested();
				}
				Thread.Sleep(TIME);
				UpdateView();
			}
		}

		private void UpdateView()
		{
			_player1.Update();
			_player2.Update();

			DrawEntities();
		}

		private void DrawEntities()
		{
			Invoke(PaintBlocks());
		}

		private Action PaintBlocks()
		{
			return () =>
			{
				using (var g = board.CreateGraphics())
				{
					g.Clear(board.BackColor);

					foreach (var entity in _entities)
					{
						PaintBlock(entity, g);
						UpdateScore(entity);
					}
				}
			};
		}

		private void PaintBlock(IBlock entity, Graphics g)
		{
			using (var pen = new Pen(entity.Color, GameConstants.BlockSize))
			{
				g.DrawRectangle(pen, entity.X * GameConstants.Scale, entity.Y * GameConstants.Scale, GameConstants.Scale,
					GameConstants.Scale);
			}
		}

		private void UpdateScore(IBlock entity)
		{
			if ((entity as Player) != null && entity.IsInProximityOf(_board.Food))
			{
				_board.PlaceRandomFood();
				Score((Player)entity);
			}
		}

		private void Score(Player player)
		{
			player.Score++;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			var activePlayer = e.KeyCode.IsPlayer1() ? _player1 : _player2;
			ComputeDirectionForPlayer(activePlayer, e.KeyCode);
			e.Handled = true;
		}

		public void ComputeDirectionForPlayer(Player player, Keys key)
		{
			var direction = player.CurrentDirection;
			switch (key)
			{
				case Keys.Up:
				case Keys.W:
					direction = Direction.UP;
					break;
				case Keys.Down:
				case Keys.S:
					direction = Direction.DOWN;
					break;
				case Keys.Left:
				case Keys.A:
					direction = Direction.LEFT;
					break;
				case Keys.Right:
				case Keys.D:
					direction = Direction.RIGHT;
					break;
			}
			player.CurrentDirection = direction;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (Control control in Controls)
			{
				control.PreviewKeyDown += Control_PreviewKeyDown;
			}
		}

		private static void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			e.IsInputKey = e.KeyCode.IsValidInputKey();
		}

		private void game_clock_Tick(object sender, EventArgs e)
		{
			game_time_lbl.Text = TimeSpan.FromSeconds(_gameTime).ToString(@"mm\:ss");
			_gameTime--;
			if (_gameTime < 0)
			{
				game_clock.Enabled = false;
				_tokenSource.Cancel();
				MessageBox.Show(ShowResults());
			}
		}

		private string ShowResults()
		{
			return
				_player1.Score == _player2.Score
					? "It's a draw."
					: $"Player {(_player1.Score > _player2.Score ? 1 : 2)} won.";
		}

		private void reset_btn_Click(object sender, EventArgs e)
		{
			ResetGame();
		}

		private void ResetGame()
		{
			CancelTask();

			ResetGraphics();
			ResetPlayers();
			ResetTimer();

			StartGame();
		}

		private void ResetGraphics()
		{
			using (var g = board.CreateGraphics())
			{
				g.Clear(board.BackColor);
			}

			_board.PlaceRandomFood();
		}

		private void CancelTask()
		{
			if (_gameTask != null)
			{
				_tokenSource.Cancel();
			}
		}

		private void StartGame()
		{
			_tokenSource = new CancellationTokenSource();
			_cancellationToken = _tokenSource.Token;
			game_clock.Enabled = true;
			_gameTask = Task.Factory.StartNew(() => Draw(_cancellationToken), _cancellationToken);
		}

		private void ResetTimer()
		{
			_gameTime = TOTAL_TIME;
		}

		private void ResetPlayers()
		{
			if (_player1 != null)
			{
				_player1.Score = _player1.X = _player1.Y = 0;
				_player1.CurrentDirection = Direction.RIGHT;
			}
			if (_player2 != null)
			{
				_player2.Score = 0;
				_player2.X = board.Width;
				_player2.Y = board.Height;
				_player2.CurrentDirection = Direction.LEFT;
			}
		}
	}
}