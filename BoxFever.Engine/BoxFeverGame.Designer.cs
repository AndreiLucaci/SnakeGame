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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.board = new System.Windows.Forms.Panel();
			this.socre_lbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.time_lbl = new System.Windows.Forms.Label();
			this.minus10 = new System.Windows.Forms.Button();
			this.plus10 = new System.Windows.Forms.Button();
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
			this.socre_lbl.Location = new System.Drawing.Point(265, 9);
			this.socre_lbl.Name = "socre_lbl";
			this.socre_lbl.Size = new System.Drawing.Size(47, 13);
			this.socre_lbl.TabIndex = 1;
			this.socre_lbl.Text = "Score: 0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Time:";
			// 
			// time_lbl
			// 
			this.time_lbl.AutoSize = true;
			this.time_lbl.Location = new System.Drawing.Point(84, 9);
			this.time_lbl.Name = "time_lbl";
			this.time_lbl.Size = new System.Drawing.Size(25, 13);
			this.time_lbl.TabIndex = 4;
			this.time_lbl.Text = "100";
			// 
			// minus10
			// 
			this.minus10.CausesValidation = false;
			this.minus10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minus10.Location = new System.Drawing.Point(41, 4);
			this.minus10.Name = "minus10";
			this.minus10.Size = new System.Drawing.Size(37, 23);
			this.minus10.TabIndex = 5;
			this.minus10.TabStop = false;
			this.minus10.Text = "-10";
			this.minus10.UseVisualStyleBackColor = true;
			this.minus10.Click += new System.EventHandler(this.minus10_Click);
			// 
			// plus10
			// 
			this.plus10.CausesValidation = false;
			this.plus10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.plus10.Location = new System.Drawing.Point(115, 4);
			this.plus10.Name = "plus10";
			this.plus10.Size = new System.Drawing.Size(35, 23);
			this.plus10.TabIndex = 6;
			this.plus10.TabStop = false;
			this.plus10.Text = "+10";
			this.plus10.UseVisualStyleBackColor = true;
			this.plus10.Click += new System.EventHandler(this.plus10_Click);
			// 
			// BoxFeverGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 362);
			this.Controls.Add(this.plus10);
			this.Controls.Add(this.minus10);
			this.Controls.Add(this.time_lbl);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.socre_lbl);
			this.Controls.Add(this.board);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(344, 400);
			this.MinimumSize = new System.Drawing.Size(344, 400);
			this.Name = "BoxFeverGame";
			this.Text = "s|n\'s Endless Player Game";
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
		private System.Windows.Forms.Label time_lbl;
		private System.Windows.Forms.Button minus10;
		private System.Windows.Forms.Button plus10;
	}
}

