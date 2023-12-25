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
    public partial class Output2v2Form : Form
    {
        public Output2v2Form(bool playerLose)
        {
            InitializeComponent();

            this.PlayAgainButton.DialogResult = DialogResult.Retry;
            this.ExitButton.DialogResult = DialogResult.Cancel;

            TitleLabel.Font = new Font (MainWindow.cFont.Alkhemikal, 30, FontStyle.Bold);
            Paragraph.Font = new Font(MainWindow.cFont.Alkhemikal, 13, FontStyle.Regular);
            PlayAgainButton.Font = ExitButton.Font = new Font (MainWindow.cFont.Alkhemikal, 20, FontStyle.Regular);

            Paragraph.Text = playerLose ? "Block win" : "Human win";
        }

    }
}
