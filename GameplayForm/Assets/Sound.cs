using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace WindowForm.Assets
{
    public class Sound
    {
        public WindowsMediaPlayer MenuBackground;
        public int MenuBackgroundDuration = 148500;
        public WindowsMediaPlayer MouseEffect;
        public int MouseEffectDuration = 10;

        public Sound()
        {
            MenuBackground = new WindowsMediaPlayer();
            MenuBackground.URL = @".\assets\audio\Cathedral.wav";
            MenuBackground.settings.autoStart = true;
            MenuBackground.settings.volume = 50;
            MenuBackground.settings.setMode("loop", true);

            MouseEffect = new WindowsMediaPlayer();
            MouseEffect.settings.autoStart = false;
            MouseEffect.URL = @".\assets\audio\MouseEffect.wav";
            MouseEffect.settings.volume = 100;
            MouseEffect.settings.setMode("loop", false);

        }
    }
}
