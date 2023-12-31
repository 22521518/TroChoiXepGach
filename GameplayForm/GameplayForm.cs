using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowForm.Assets;
using GameComponent.Game;
using GameComponent;
using GameComponent.Game.Object;
using GameComponent.Player;

namespace WindowForm
{
    public partial class GameplayForm : Form
    {
        CustomImage Img = new CustomImage();
        GameMode Mode;
        GameState GamePlay;
        readonly int GridX, GridY;
        int Speed;
        int CurrentFrame = 0;
        int Current;
        //CLASSIC

        //HUMAN
        readonly int CellSize = 36;
        bool HumanMovingLeft, HumanMovingRight;
        int HumanJump, HumanFall;

        int ColumnHuman = 5, RowHuman;
        //PvP
        bool BlockMovingLeft, BlockMovingRight;

        public GameplayForm()
        {
            
            InitializeComponent();
            InitializeGame();
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            ScoreLabel.Font = new Font(MainWindow.cFont.Alkhemikal, 28, FontStyle.Bold);
            Score.Font = new Font(MainWindow.cFont.Font, 26, FontStyle.Regular);
            Line.Font  = new Font(MainWindow.cFont.Font, 18, FontStyle.Regular);

            GridX = WallLeft.Width;
            GridY = Ground.Location.Y - CellSize * 22 + 5;

        }
        public void InitializeGame()
        {
            Mode = MainWindow.user.ModeID;
            switch (Mode)
            {
                case GameMode.Classic:
                    GamePlay = new GameStateClassic();
                    Speed = 6;
                    Score.Visible = true;
                    ScoreLabel.Visible = true;
                    Line.Visible = true;
                    break;
                case GameMode.Escape:
                    GamePlay = new GameStateHuman();
                    Speed = 12;
                    Score.Visible = true;
                    ScoreLabel.Visible = true;
                    Line.Visible = true;
                    break;
                case GameMode.PvP: 
                    GamePlay = new GameStatePvP();
                    Speed = 12;
                    Score.Visible = false;
                    ScoreLabel.Visible = false;
                    Line.Visible = false;
                    break;
                default: break;
            }
            //DelayKey.Enabled = (int)MainWindow.user.ModeID % 2 == 0 ? false : true;
            Current = 0;
            CurrentFrame = 0;
            HumanMovingLeft = false;
            HumanMovingRight = false;
            HumanJump = 0;
            HumanFall = 0;
            BlockMovingLeft = false;
            BlockMovingRight = false;

            Score.Text = GamePlay.Score.ToString();
            Line.Text = $"Line: {GamePlay.Line}";
        }
        private void GameplayForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int r = 0; r < GamePlay.Grid.Row; r++)
            {
                for (int c = 0; c < GamePlay.Grid.Column; c++)
                {
                    if (GamePlay.Grid[r,c] > 0)
                        g.DrawImage(Img.BlockGround, GridX + c * CellSize, GridY + r * CellSize, new Rectangle(0, 0, CellSize, CellSize), GraphicsUnit.Pixel);
                    if (GamePlay.Grid[r, c] < 0)
                        g.DrawImage(Img.BlockGroundBlur, GridX + c * CellSize, GridY + r * CellSize, new Rectangle(0, 0, CellSize, CellSize), GraphicsUnit.Pixel);
                }
            }

            foreach (Position p in GamePlay.CurrentBlock.PositionInTiles())
            {
                int r = GridY + CellSize * p.Row;
                int c = GridX + CellSize * p.Column;
                g.DrawImage(Img.BlockGround, c , r, new Rectangle(0, 0, CellSize + 1, CellSize), GraphicsUnit.Pixel);
            }

            if (Mode == GameMode.Classic)
            {
                GameStateClassic gsc = (GameStateClassic)GamePlay;
                int drop = gsc.BlockDropDistance();
                foreach (Position p in GamePlay.CurrentBlock.PositionInTiles())
                {
                    int r = GridY + CellSize * (p.Row + drop);
                    int c = GridX + CellSize * (p.Column);
                    g.DrawImage(Img.BlockGroundBlur, c, r, new Rectangle(0, 0, CellSize, CellSize), GraphicsUnit.Pixel);
                }
            }
            else
            {
                int r, c;
                int playerX, playerY;
                if (GamePlay is GameStateHuman)
                {
                    GameStateHuman gsh = (GameStateHuman)GamePlay;
                    r = CellSize * (gsh.Human.Body[0].Row);
                    c = CellSize * gsh.Human.Body[0].Column;
                    playerY = GridY + (r - 19) + gsh.Human.JumpSteps * CellSize / 4;
                    playerX = GridX + c + gsh.Human.Steps * CellSize / 4;
                }
                else
                {
                    GameStatePvP gsh = (GameStatePvP)GamePlay;
                    r = CellSize * (gsh.Human.Body[0].Row);
                    c = CellSize * gsh.Human.Body[0].Column;
                    playerY = GridY + (r - 19) + gsh.Human.JumpSteps * CellSize / 4;
                    playerX = GridX + c + gsh.Human.Steps * CellSize / 4;
                }
                g.DrawImage(Img.Human, playerX, playerY + 10, 
                    new Rectangle(ColumnHuman * 36, RowHuman * 55, 36, 55), GraphicsUnit.Pixel);
            }
            if (GamePlay.Hold == null)
            {
                BlockBox.Image = null;
            }
            else
                BlockBox.Image = Img.FullBlock[GamePlay.Hold.Id - 1];
        }
        private void GameplayForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (GamePlay is GameStateClassic)
            {
                KeyDownClassic(GamePlay, e);
            }
            else if (GamePlay is GameStateHuman)
            {
                KeyDownHuman(GamePlay, e);
            }
            else if (GamePlay is GameStatePvP)
            {
                KeyDownPvP(GamePlay, e);
            }
        }
        async void KeyDownClassic(GameState gameplay, KeyEventArgs e)
        {
            GameStateClassic gtclassic = (GameStateClassic)gameplay;
            if (GamePlay.GameOver)
            {
                MoveTimer.Stop();
                DialogResult Result = new OutputForm(MainWindow.user.Name, GamePlay.Score, Mode).ShowDialog();
                if (Result == DialogResult.Cancel)
                {
                    MainWindow.OpenMenuWindow(this);
                    return;
                }
                else
                {
                    InitializeGame();
                    MoveTimer.Start();
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                    case Keys.Left:
                        if (gtclassic.MoveLeft())
                        {
                            this.PlaceBlock.Enabled = false;
                        }
                        break;
                    case Keys.D:
                    case Keys.Right:
                        if (gtclassic.MoveRight())
                        {
                            this.PlaceBlock.Enabled = false;
                        }
                        break;
                    case Keys.S:
                    case Keys.Down:
                        gtclassic.MoveDown();
                        break;
                    case Keys.Up:
                    case Keys.W:
                        if (gtclassic.BlockRotate90())
                        {
                            this.PlaceBlock.Enabled = false;
                        }
                        break;
                    case Keys.Space:
                        int row = gtclassic.Drop();
                        if (row >= 1)
                        {
                            this.MoveTimer.Enabled = false;
                            this.Clear.Enabled = true;
                        }
                        break;
                    case Keys.C:
                        if (gtclassic.Hold == null)
                        {
                            gtclassic.HoldBlock();
                        }
                        else
                        {
                            gtclassic.ChangeBlock();
                        }
                        break;
                    default:
                        return;
                }
            }
            await Task.Delay(1);
            Invalidate();
        }
        void KeyDownHuman(GameState gameplay, KeyEventArgs e)
        {
            var gthuman = (GameStateHuman)gameplay;
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    HumanMovingLeft = true;
                    break;
                case Keys.Right:
                case Keys.D:
                    HumanMovingRight = true;
                    break;
                case Keys.Up:
                case Keys.W:
                    if (gthuman.IsOnLand())
                    {
                        HumanJump = 4;
                    }
                    break;
                case Keys.Space:
                    if (gthuman.Hold != null)
                    {
                        gthuman.DropBlock();
                    }
                    else
                    {
                        gthuman.TakeBlock();
                    }
                    break;
                default:
                    return;
            }
        }
        void KeyDownPvP(GameState gameplay, KeyEventArgs e)
        {
            var gspvp = (GameStatePvP) gameplay;
            //HUMAN
            switch (e.KeyCode)
            {
                case Keys.Left:
                    HumanMovingLeft = true;
                    break;
                case Keys.Right:
                    HumanMovingRight = true;
                    break;
                case Keys.Up:
                    if (gspvp.IsOnLand())
                    {
                        HumanJump = 4;
                    }
                    break;
                case Keys.ControlKey:
                    if (gspvp.Hold != null)
                    {
                        gspvp.DropBlock();
                    }
                    else
                    {
                        gspvp.TakeBlock();
                    }
                    break;
                default: break;
            }
            //------ BLOCK ------//
            switch (e.KeyCode)
            {
                case Keys.A:
                    BlockMovingLeft = true;
                    break;
                case Keys.D:
                    BlockMovingRight = true;
                    break;
                case Keys.W:
                    if (gspvp.BlockRotate90())
                    {
                        this.PlaceBlock.Enabled = false;
                    }
                    break;
            }
        }
        private void GameplayForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (GamePlay is GameStatePvP)
            {
                KeyUpPvP(e);
            }
            else
            {
                KeyUpOnePerson(e);
            }
        }
        void KeyUpPvP(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                BlockMovingLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                BlockMovingRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                HumanMovingLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                HumanMovingRight = false;
            }
        }
        void KeyUpOnePerson(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                BlockMovingLeft = false;
                HumanMovingLeft = false;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                BlockMovingRight = false;
                HumanMovingRight = false;
            }
        }
        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            if (GamePlay.GameOver)
            {
                MoveTimer.Stop();
                DialogResult Result;
                if (GamePlay is GameStatePvP)
                {
                    GameStatePvP gspvp = (GameStatePvP)GamePlay;
                    Result = new Output2v2Form(gspvp.IsHumanLose).ShowDialog();
                }
                else
                {
                    Result = new OutputForm(MainWindow.user.Name, GamePlay.Score, Mode).ShowDialog();
                }
                if (Result == DialogResult.Cancel)
                {
                    MainWindow.OpenMenuWindow(this);
                    return;
                }
                else
                {
                    InitializeGame();
                    MoveTimer.Start();
                }
            }
            else
            {
                if (CurrentFrame % Speed == 0)
                {
                    if(!GamePlay.MoveDown())
                    {
                        PlaceBlock.Enabled = true;
                    }
                }
                switch(Mode)
                {
                    case GameMode.Escape:
                        HandleAnimationHuman(GamePlay);
                        break;
                    case GameMode.PvP:
                        HandleAnimationPvP(GamePlay);
                        break;
                    default: break;
                }
                CurrentFrame = (CurrentFrame + 1) % Speed;
            }
            Invalidate();
        }
        void HandleAnimationHuman(GameState gameplay)
        {
            GameStateHuman gshuman = (GameStateHuman) gameplay;
            if (HumanJump > 0)
            {
                //Human animation
                ColumnHuman = 13 + HumanJump % 4;
                for (int i = 0; i < HumanJump; i++)
                {
                    if (!gshuman.Jump(1))
                    {
                        HumanJump = 1;
                        break;
                    }
                }
                HumanJump--;
            }
            else if (!gshuman.IsOnLand())
            {
                //Human animation
                ColumnHuman = 13 + 4 + HumanFall % 2;
                for (int i = 0; i < HumanFall; i++)
                {
                    if (!gshuman.Fall(1))
                    {
                        ColumnHuman = 12;
                        HumanFall = 0;
                    }
                }
                HumanFall = HumanFall > 2 ? HumanFall : HumanFall + 1;
            }
            if (HumanMovingLeft)
            {
                //Direction for human animation
                RowHuman = 0;
                if (gshuman.IsOnLand())
                {
                    //Human animation
                    ColumnHuman = (ColumnHuman + 1) % 13;
                }
                gshuman.MoveLeft();
            }
            if (HumanMovingRight)
            {
                //Direction for human animation
                RowHuman = 1;
                if (gshuman.IsOnLand())
                {
                    //Human animation
                    ColumnHuman = (ColumnHuman + 1) % 13;
                }
                gshuman.MoveRight();
            }
        }
        void HandleAnimationPvP(GameState gameplay)
        {
            GameStatePvP gspvp = (GameStatePvP)gameplay;
            IBlockMovement iBlock = gspvp;
            ICharacterMovement iHuman = gspvp;
            if (CurrentFrame % (Speed / 4) == 0)
            {
                if (BlockMovingLeft)
                {
                    if (iBlock.MoveLeft())
                    {
                        PlaceBlock.Enabled = false;
                    }
                }
                if (BlockMovingRight)
                {
                    if (iBlock.MoveRight())
                    {
                        PlaceBlock.Enabled = false;
                    }
                }
            }
            if (HumanJump > 0)
            {
                //Human animation
                ColumnHuman = 13 + HumanJump % 4;
                for (int i = 0; i < HumanJump; i++)
                {
                    if (!gspvp.Jump(1))
                    {
                        HumanJump = 0;
                    }
                }
                HumanJump--;
            }
            else if(!gspvp.IsOnLand())
            {
                //Human animation
                ColumnHuman = 13 + 4 + HumanFall % 2;
                for (int i = 0; i < HumanFall; i++)
                {
                    if (!gspvp.Fall(1))
                    {
                        HumanFall = 0;
                        ColumnHuman = 0;
                    }
                }
                HumanFall = HumanFall > 2 ? HumanFall : HumanFall + 1;
            }
            if (HumanMovingLeft)
            {
                //Direction for human animation
                RowHuman = 0;
                if (gspvp.IsOnLand())
                {
                    //Human animation
                    ColumnHuman = (ColumnHuman + 1) % 13;
                }
                iHuman.MoveLeft();
            }
            if (HumanMovingRight)
            {
                //Direction for human animation
                RowHuman = 1;
                if (gspvp.IsOnLand())
                {
                    //Human animation
                    ColumnHuman = (ColumnHuman + 1) % 13;
                }
                iHuman.MoveRight();
            }

        }

        private void GameplayForm_Activated(object sender, EventArgs e)
        {
            MoveTimer.Enabled = true;
        }

        private void PauseIcon_Click(object sender, EventArgs e)
        {
            MoveTimer.Stop();
            DialogResult res = MessageBox.Show("Do you want to quit", "Pause", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                InitializeGame();
                this.Hide();
                MainWindow.OpenMenuWindow(this);
            }
            else
                MoveTimer.Start();
        }

        private void SettingIcon_Click(object sender, EventArgs e)
        {
            MoveTimer.Stop();
            SettingForm settingform = new SettingForm(MainWindow.Music.MenuBackground.settings.volume, MainWindow.Music.MouseEffect.settings.volume);
            settingform.ShowDialog();
            MoveTimer.Start();
        }

        private void GameplayForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
                case Keys.Alt:
                    e.IsInputKey = false; 
                    break;
            }
        }

        private void GameplayForm_Deactivate(object sender, EventArgs e)
        {
            MoveTimer.Enabled = false;
        }
        private void PlaceBlock_Tick(object sender, EventArgs e)
        {
            int row = GamePlay.PlaceBlock();
            if (row > 0)
            {
                MoveTimer.Stop();
                Clear.Start();
            }
            PlaceBlock.Stop();
        }
        private void Clear_Tick(object sender, EventArgs e)
        {
            if (Current >= 5)
            {
                Current = 0;
                GamePlay.ClearRow();
                Speed = GamePlay.SpeedBlockDrop[(int) Mode][GamePlay.Level];
                Score.Text = GamePlay.Score.ToString();
                Line.Text = $"Line: {GamePlay.Line}";
                Clear.Stop();
                MoveTimer.Start();
            }
            else
            {
                GamePlay.Grid.MarkedFullRow();
                Current++;
            }
            Invalidate();
        }
        private void GameplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MoveTimer.Stop();
            InitializeGame();
            MainWindow.OpenMenuWindow(this);
        }
    }
}
