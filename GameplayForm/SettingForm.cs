using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowForm.Assets;

namespace WindowForm
{
    public partial class SettingForm : Form
    {
        public SettingForm(int MusicValue, int EffectValue)
        {
            InitializeComponent();
            TitleLabel.Font = new Font(MainWindow.cFont.Alkhemikal, 40, FontStyle.Bold);
            MusicLabel.Font = EffectLabel.Font = new Font(MainWindow.cFont.Alkhemikal, 13, FontStyle.Regular);
            ExitButton.Font = new Font(MainWindow.cFont.Alkhemikal, 20, FontStyle.Regular);

            MusicTrackBar.Value = MusicValue / 10;
            EffectTrackBar.Value = EffectValue / 10;
        }

        private void EffectTrackBar_Scroll(object sender, EventArgs e)
        {
            MainWindow.Music.MouseEffect.settings.volume = EffectTrackBar.Value * 10;
        }

        private void MusicTrackBar_Scroll(object sender, EventArgs e)
        {
            MainWindow.Music.MenuBackground.settings.volume = MusicTrackBar.Value * 10;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
