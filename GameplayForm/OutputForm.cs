using GameComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForm
{
    public partial class OutputForm : Form
    {
        public OutputForm(string name, int score, GameMode mode)
        {
            InitializeComponent();

            this.PlayAgainButton.DialogResult = DialogResult.Retry;
            this.ExitButton.DialogResult = DialogResult.Cancel;

            TitleLabel.Font = new Font(MainWindow.cFont.Alkhemikal, 30, FontStyle.Bold);
            ModeLabel.Font = NameLabel.Font = ScoreLabel.Font = Score.Font = new Font(MainWindow.cFont.Alkhemikal, 13, FontStyle.Regular);

            PlayAgainButton.Font = ExitButton.Font = new Font(MainWindow.cFont.Alkhemikal, 18, FontStyle.Regular);

            MainWindow.user.Score = score;
            MainWindow.writerSQL.InsertNewScore(MainWindow.user);
            MainWindow.readerSQL.UpdateData();

            ModeLabel.Text = mode.ToString();
            NameLabel.Text = $"Name: {name}";
            Score.Text = score.ToString();
        }
    }
}
