using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowForm.Assets;
using WMPLib;


namespace WindowForm
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            TitleLabel.Font = new Font(MainWindow.cFont.Alkhemikal, 60, FontStyle.Italic);
            StartLabel.Font = new Font(MainWindow.cFont.ArcadeIn, 40, FontStyle.Italic);

            MainWindow.Music.MenuBackground.controls.play();

        }
        private void StartLabel_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void SettingIcon_Click(object sender, EventArgs e)
        {
            SettingForm settingform = new SettingForm(MainWindow.Music.MenuBackground.settings.volume, MainWindow.Music.MouseEffect.settings.volume);
            settingform.ShowDialog();
        }
        private void LeaderBoardIcon_Click(object sender, EventArgs e)
        {
            LeaderBoardForm ldform = new LeaderBoardForm();
            ldform.ShowDialog();
        }
        async private void StartLabel_Click(object sender, EventArgs e)
        {
            MainWindow.Music.MouseEffect.controls.play();
            await Task.Delay(MainWindow.Music.MouseEffectDuration);
            MainWindow.Music.MouseEffect.controls.pause();


            InputForm inputForm = new InputForm();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                MainWindow.OpenModeWindow(this);
            }
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainWindow.Music.MenuBackground.controls.stop();
        }

        private void GuideIcon_Click(object sender, EventArgs e)
        {
            GuideForm guideForm = new GuideForm();
            guideForm.ShowDialog();
        }
    }
}
