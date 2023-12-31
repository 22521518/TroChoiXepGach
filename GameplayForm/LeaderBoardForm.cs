using GameComponent.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowForm.Assets;

namespace WindowForm
{
    public partial class LeaderBoardForm : Form
    {
        public LeaderBoardForm()
        {
            InitializeComponent();

            TitleLabel.Font = new Font (MainWindow.cFont.Alkhemikal, 15, FontStyle.Bold);

            ModeFilterLabel.Font = CloseButton.Font = AllModeButton.Font = ModeHumanFilterButton.Font = ModeClassicFilterButton.Font = new Font (MainWindow.cFont.Alkhemikal, 8, FontStyle.Regular);
            PlayerBoardButton.Font = NameFilterLabel.Font = NameFilterButton.Font = new Font (MainWindow.cFont.Alkhemikal, 8, FontStyle.Regular);
            LeaderBoard.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(MainWindow.cFont.Alkhemikal, 20, System.Drawing.FontStyle.Bold);
            LeaderBoard.DefaultCellStyle.Font = new System.Drawing.Font(MainWindow.cFont.Alkhemikal, 13, System.Drawing.FontStyle.Bold);

            LeaderBoard.DataSource = MainWindow.readerSQL.Scoreboard.Tables["DATA"];

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTextBox.Text = "" + NameTextBox.Text.Trim('\n');
            NameTextBox.SelectionStart = NameTextBox.Text.Length;
            NameTextBox.SelectionLength = 0;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModeHumanFilterButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            LeaderBoard.DataSource = MainWindow.readerSQL.ModeHumanboard.Tables["DATA"];
            AllModeButton.BackColor = System.Drawing.Color.Black;
            ModeHumanFilterButton.BackColor = System.Drawing.Color.DimGray;
            PlayerBoardButton.BackColor = System.Drawing.Color.Black;
            ModeClassicFilterButton.BackColor = System.Drawing.Color.Black;
        }

        private void ModeClassicFilterButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            LeaderBoard.DataSource = MainWindow.readerSQL.ModeClassicboard.Tables["DATA"];
            AllModeButton.BackColor = System.Drawing.Color.Black;
            ModeHumanFilterButton.BackColor = System.Drawing.Color.Black;
            PlayerBoardButton.BackColor = System.Drawing.Color.Black;
            ModeClassicFilterButton.BackColor = System.Drawing.Color.DimGray;

        }

        private void AllModeButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            LeaderBoard.DataSource = MainWindow.readerSQL.Scoreboard.Tables["DATA"];
            AllModeButton.BackColor = System.Drawing.Color.DimGray;
            ModeHumanFilterButton.BackColor = System.Drawing.Color.Black;
            PlayerBoardButton.BackColor = System.Drawing.Color.Black;
            ModeClassicFilterButton.BackColor = System.Drawing.Color.Black;
        }

        private void NameFilterButton_Click(object sender, EventArgs e)
        {
            LeaderBoard.DataSource = MainWindow.readerSQL.GetPlayerData(NameTextBox.Text).Tables["DATA"];
            AllModeButton.BackColor = System.Drawing.Color.Black;
            ModeHumanFilterButton.BackColor = System.Drawing.Color.Black;
            ModeClassicFilterButton.BackColor = System.Drawing.Color.Black;
            PlayerBoardButton.BackColor = System.Drawing.Color.Black;
        }

        private void PlayerBoardButton_Click(object sender, EventArgs e)
        {
            LeaderBoard.DataSource = MainWindow.readerSQL.Playerboard.Tables["DATA"];
            AllModeButton.BackColor = System.Drawing.Color.Black;
            ModeHumanFilterButton.BackColor = System.Drawing.Color.Black;
            ModeClassicFilterButton.BackColor = System.Drawing.Color.Black;
            PlayerBoardButton.BackColor = System.Drawing.Color.DimGray;
        }
    }
}
