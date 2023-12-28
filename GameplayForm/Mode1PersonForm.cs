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
    public partial class Mode1PersonForm : Form
    {
        public Mode1PersonForm()
        {
            InitializeComponent();

            TitleLabel.Font = new Font(MainWindow.cFont.Alkhemikal, 30, FontStyle.Bold);
            ClassicModeButton.Font = HumanModeButton.Font = ExitButton.Font = new Font(MainWindow.cFont.Alkhemikal, 10, FontStyle.Regular);

            HumanModeButton.DialogResult = DialogResult.OK;
            ClassicModeButton.DialogResult = DialogResult.Yes;
            ExitButton.DialogResult = DialogResult.Cancel;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
        }
    }
}
