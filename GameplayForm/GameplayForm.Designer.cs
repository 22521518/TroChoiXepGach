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
            this.FirePicBox = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PenguinPicBox = new System.Windows.Forms.PictureBox();
            this.ScorePicture = new System.Windows.Forms.PictureBox();
            this.WallRight = new System.Windows.Forms.PictureBox();
            this.WallLeft = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.BlockBox = new System.Windows.Forms.PictureBox();
            this.PlaceBlock = new System.Windows.Forms.Timer(this.components);
            this.Clear = new System.Windows.Forms.Timer(this.components);
            this.Line = new System.Windows.Forms.Label();
            this.PauseIcon = new System.Windows.Forms.PictureBox();
            this.SettingIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FirePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenguinPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScorePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Black;
            this.Score.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(477, 117);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(242, 58);
            this.Score.TabIndex = 26;
            this.Score.Text = "0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // BlockBox
            // 
            this.BlockBox.Location = new System.Drawing.Point(537, 553);
            this.BlockBox.Name = "BlockBox";
            this.BlockBox.Size = new System.Drawing.Size(128, 128);
            this.BlockBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BlockBox.TabIndex = 28;
            this.BlockBox.TabStop = false;
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
            this.Line.Location = new System.Drawing.Point(603, 386);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(104, 33);
            this.Line.TabIndex = 29;
            this.Line.Text = "0";
            this.Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PauseIcon
            // 
            this.PauseIcon.Image = ((System.Drawing.Image)(resources.GetObject("PauseIcon.Image")));
            this.PauseIcon.Location = new System.Drawing.Point(711, 758);
            this.PauseIcon.Name = "PauseIcon";
            this.PauseIcon.Size = new System.Drawing.Size(30, 30);
            this.PauseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PauseIcon.TabIndex = 30;
            this.PauseIcon.TabStop = false;
            this.PauseIcon.Click += new System.EventHandler(this.PauseIcon_Click);
            // 
            // SettingIcon
            // 
            this.SettingIcon.Image = ((System.Drawing.Image)(resources.GetObject("SettingIcon.Image")));
            this.SettingIcon.Location = new System.Drawing.Point(666, 758);
            this.SettingIcon.Name = "SettingIcon";
            this.SettingIcon.Size = new System.Drawing.Size(30, 30);
            this.SettingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingIcon.TabIndex = 31;
            this.SettingIcon.TabStop = false;
            this.SettingIcon.Click += new System.EventHandler(this.SettingIcon_Click);
            // 
            // GameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(40F, 97F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(765, 800);
            this.Controls.Add(this.SettingIcon);
            this.Controls.Add(this.PauseIcon);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.BlockBox);
            this.Controls.Add(this.Score);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
            ((System.ComponentModel.ISupportInitialize)(this.BlockBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox FirePicBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox PenguinPicBox;
        private System.Windows.Forms.PictureBox ScorePicture;
        private System.Windows.Forms.PictureBox WallRight;
        private System.Windows.Forms.PictureBox WallLeft;
        private System.Windows.Forms.PictureBox Ground;
        public System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.PictureBox BlockBox;
        private System.Windows.Forms.Timer PlaceBlock;
        private System.Windows.Forms.Timer Clear;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.PictureBox PauseIcon;
        private System.Windows.Forms.PictureBox SettingIcon;
    }
}

