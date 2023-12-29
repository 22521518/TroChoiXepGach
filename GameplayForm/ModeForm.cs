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
    public partial class ModeForm : Form
    {
        public ModeForm()
        {
            InitializeComponent();

            TitleLabel.Font = new Font(MainWindow.cFont.Alkhemikal, 30, FontStyle.Bold);
            OnePersonButton.Font = TwoPersonButton.Font = ExitButton.Font = new Font(MainWindow.cFont.Alkhemikal, 12, FontStyle.Regular);

        }

        private void OnePersonButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mode1PersonForm form = new Mode1PersonForm();
            DialogResult Result = form.ShowDialog();
           
            if (Result != DialogResult.Cancel)
            {
                if (Result == DialogResult.OK)
                    MainWindow.user.ModeID = GameMode.Human;
                else if (Result == DialogResult.Yes)
                    MainWindow.user.ModeID = GameMode.Classic;

                MainWindow.OpenGamePlayWindow(this);
            }
            else
                Show();
        }

        private void TwoPersonButton_Click(object sender, EventArgs e)
        {
            MainWindow.user.ModeID = GameMode.PvP;
            MainWindow.OpenGamePlayWindow(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainWindow.OpenMenuWindow(this);
        }
    }
}
