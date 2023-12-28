using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameComponent.Player;

namespace WindowForm
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            this.ConfirmButton.DialogResult = DialogResult.OK;
            this.AcceptButton = ConfirmButton;

            TitleLabel.Font = new Font (MainWindow.cFont.Alkhemikal, 20, FontStyle.Bold);
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;

            ConfirmButton.Font = new Font(MainWindow.cFont.Alkhemikal, 20, FontStyle.Regular);
        }

        private void CloseIcon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            MainWindow.user = new Player(NameTextBox.Text == "" ? "anonymous" : NameTextBox.Text);
        }
    }
}
