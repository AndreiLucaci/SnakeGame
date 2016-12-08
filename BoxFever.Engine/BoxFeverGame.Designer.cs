namespace BoxFever.Engine
{
	partial class BoxFeverGame
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.board = new System.Windows.Forms.Panel();
			this.socre_lbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.player1_score_lbl = new System.Windows.Forms.Label();
			this.player2_score_lbl = new System.Windows.Forms.Label();
			this.game_clock = new System.Windows.Forms.Timer(this.components);
			this.game_time_lbl = new System.Windows.Forms.Label();
			this.reset_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// board
			// 
			this.board.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.board.Location = new System.Drawing.Point(12, 59);
			this.board.Name = "board";
			this.board.Size = new System.Drawing.Size(300, 300);
			this.board.TabIndex = 0;
			// 
			// socre_lbl
			// 
			this.socre_lbl.AutoSize = true;
			this.socre_lbl.Location = new System.Drawing.Point(264, 9);
			this.socre_lbl.Name = "socre_lbl";
			this.socre_lbl.Size = new System.Drawing.Size(48, 13);
			this.socre_lbl.TabIndex = 1;
			this.socre_lbl.Text = "Player 2:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Player 1:";
			// 
			// player1_score_lbl
			// 
			this.player1_score_lbl.AutoSize = true;
			this.player1_score_lbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.player1_score_lbl.Location = new System.Drawing.Point(12, 33);
			this.player1_score_lbl.Name = "player1_score_lbl";
			this.player1_score_lbl.Size = new System.Drawing.Size(0, 16);
			this.player1_score_lbl.TabIndex = 3;
			// 
			// player2_score_lbl
			// 
			this.player2_score_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.player2_score_lbl.AutoSize = true;
			this.player2_score_lbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.player2_score_lbl.Location = new System.Drawing.Point(292, 33);
			this.player2_score_lbl.Name = "player2_score_lbl";
			this.player2_score_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.player2_score_lbl.Size = new System.Drawing.Size(56, 16);
			this.player2_score_lbl.TabIndex = 4;
			this.player2_score_lbl.Text = "123123";
			this.player2_score_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// game_clock
			// 
			this.game_clock.Enabled = true;
			this.game_clock.Interval = 1000;
			this.game_clock.Tick += new System.EventHandler(this.game_clock_Tick);
			// 
			// game_time_lbl
			// 
			this.game_time_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.game_time_lbl.AutoSize = true;
			this.game_time_lbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.game_time_lbl.Location = new System.Drawing.Point(137, 6);
			this.game_time_lbl.Name = "game_time_lbl";
			this.game_time_lbl.Size = new System.Drawing.Size(0, 16);
			this.game_time_lbl.TabIndex = 5;
			// 
			// reset_btn
			// 
			this.reset_btn.FlatAppearance.BorderSize = 0;
			this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reset_btn.Location = new System.Drawing.Point(136, 33);
			this.reset_btn.Name = "reset_btn";
			this.reset_btn.Size = new System.Drawing.Size(45, 20);
			this.reset_btn.TabIndex = 6;
			this.reset_btn.Text = "Reset";
			this.reset_btn.UseVisualStyleBackColor = true;
			this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
			// 
			// BoxFeverGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 362);
			this.Controls.Add(this.reset_btn);
			this.Controls.Add(this.game_time_lbl);
			this.Controls.Add(this.player2_score_lbl);
			this.Controls.Add(this.player1_score_lbl);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.socre_lbl);
			this.Controls.Add(this.board);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(344, 400);
			this.MinimumSize = new System.Drawing.Size(344, 400);
			this.Name = "BoxFeverGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "s|n\'s Box Fever";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Panel board;
		private System.Windows.Forms.Label socre_lbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label player1_score_lbl;
		private System.Windows.Forms.Label player2_score_lbl;
		private System.Windows.Forms.Timer game_clock;
		private System.Windows.Forms.Label game_time_lbl;
		private System.Windows.Forms.Button reset_btn;
	}
}

