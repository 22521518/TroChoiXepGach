namespace WindowForm
{
    partial class GameplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameplayForm));
            this.Score = new System.Windows.Forms.Label();
            this.LineLabel = new System.Windows.Forms.Label();
            this.FirePicBox = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PenguinPicBox = new System.Windows.Forms.PictureBox();
            this.ScorePicture = new System.Windows.Forms.PictureBox();
            this.WallRight = new System.Windows.Forms.PictureBox();
            this.WallLeft = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DelayKey = new System.Windows.Forms.Timer(this.components);
            this.PlaceBlock = new System.Windows.Forms.Timer(this.components);
            this.Clear = new System.Windows.Forms.Timer(this.components);
            this.Line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FirePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenguinPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScorePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Black;
            this.Score.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(506, 117);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(213, 58);
            this.Score.TabIndex = 26;
            this.Score.Text = "0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LineLabel
            // 
            this.LineLabel.BackColor = System.Drawing.Color.Black;
            this.LineLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.LineLabel.ForeColor = System.Drawing.Color.Violet;
            this.LineLabel.Location = new System.Drawing.Point(580, 385);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(68, 33);
            this.LineLabel.TabIndex = 25;
            this.LineLabel.Text = "Line: ";
            this.LineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirePicBox
            // 
            this.FirePicBox.BackColor = System.Drawing.Color.Black;
            this.FirePicBox.Image = ((System.Drawing.Image)(resources.GetObject("FirePicBox.Image")));
            this.FirePicBox.Location = new System.Drawing.Point(629, 426);
            this.FirePicBox.Name = "FirePicBox";
            this.FirePicBox.Size = new System.Drawing.Size(44, 44);
            this.FirePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FirePicBox.TabIndex = 24;
            this.FirePicBox.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BackColor = System.Drawing.Color.Black;
            this.ScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.ScoreLabel.Location = new System.Drawing.Point(465, 27);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(291, 63);
            this.ScoreLabel.TabIndex = 23;
            this.ScoreLabel.Text = "Score";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PenguinPicBox
            // 
            this.PenguinPicBox.BackColor = System.Drawing.Color.Black;
            this.PenguinPicBox.Image = ((System.Drawing.Image)(resources.GetObject("PenguinPicBox.Image")));
            this.PenguinPicBox.Location = new System.Drawing.Point(482, 402);
            this.PenguinPicBox.Name = "PenguinPicBox";
            this.PenguinPicBox.Size = new System.Drawing.Size(91, 69);
            this.PenguinPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PenguinPicBox.TabIndex = 22;
            this.PenguinPicBox.TabStop = false;
            // 
            // ScorePicture
            // 
            this.ScorePicture.Image = ((System.Drawing.Image)(resources.GetObject("ScorePicture.Image")));
            this.ScorePicture.Location = new System.Drawing.Point(441, 0);
            this.ScorePicture.Margin = new System.Windows.Forms.Padding(4);
            this.ScorePicture.Name = "ScorePicture";
            this.ScorePicture.Size = new System.Drawing.Size(317, 755);
            this.ScorePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScorePicture.TabIndex = 19;
            this.ScorePicture.TabStop = false;
            // 
            // WallRight
            // 
            this.WallRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WallRight.BackgroundImage")));
            this.WallRight.Location = new System.Drawing.Point(402, 0);
            this.WallRight.Margin = new System.Windows.Forms.Padding(4);
            this.WallRight.Name = "WallRight";
            this.WallRight.Size = new System.Drawing.Size(41, 755);
            this.WallRight.TabIndex = 21;
            this.WallRight.TabStop = false;
            // 
            // WallLeft
            // 
            this.WallLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WallLeft.BackgroundImage")));
            this.WallLeft.Location = new System.Drawing.Point(0, 0);
            this.WallLeft.Margin = new System.Windows.Forms.Padding(4);
            this.WallLeft.Name = "WallLeft";
            this.WallLeft.Size = new System.Drawing.Size(47, 755);
            this.WallLeft.TabIndex = 20;
            this.WallLeft.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ground.BackgroundImage")));
            this.Ground.Location = new System.Drawing.Point(0, 747);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(761, 46);
            this.Ground.TabIndex = 27;
            this.Ground.TabStop = false;
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 50;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(549, 549);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // DelayKey
            // 
            this.DelayKey.Interval = 1;
            this.DelayKey.Tick += new System.EventHandler(this.DelayKey_Tick);
            // 
            // PlaceBlock
            // 
            this.PlaceBlock.Interval = 120;
            this.PlaceBlock.Tick += new System.EventHandler(this.PlaceBlock_Tick);
            // 
            // Clear
            // 
            this.Clear.Interval = 50;
            this.Clear.Tick += new System.EventHandler(this.Clear_Tick);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.Black;
            this.Line.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.Line.ForeColor = System.Drawing.Color.Violet;
            this.Line.Location = new System.Drawing.Point(639, 386);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(68, 33);
            this.Line.TabIndex = 29;
            this.Line.Text = "0";
            this.Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(40F, 97F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(765, 800);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.LineLabel);
            this.Controls.Add(this.FirePicBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.PenguinPicBox);
            this.Controls.Add(this.ScorePicture);
            this.Controls.Add(this.WallRight);
            this.Controls.Add(this.WallLeft);
            this.Controls.Add(this.Ground);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 43.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(15, 18, 15, 18);
            this.MaximumSize = new System.Drawing.Size(765, 800);
            this.MinimumSize = new System.Drawing.Size(765, 800);
            this.Name = "GameplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRÒ CHƠI XẾP GẠCH";
            this.Activated += new System.EventHandler(this.GameplayForm_Activated);
            this.Deactivate += new System.EventHandler(this.GameplayForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameplayForm_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameplayForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameplayForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameplayForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameplayForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.FirePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenguinPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScorePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label LineLabel;
        private System.Windows.Forms.PictureBox FirePicBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox PenguinPicBox;
        private System.Windows.Forms.PictureBox ScorePicture;
        private System.Windows.Forms.PictureBox WallRight;
        private System.Windows.Forms.PictureBox WallLeft;
        private System.Windows.Forms.PictureBox Ground;
        public System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer DelayKey;
        private System.Windows.Forms.Timer PlaceBlock;
        private System.Windows.Forms.Timer Clear;
        private System.Windows.Forms.Label Line;
    }
}

