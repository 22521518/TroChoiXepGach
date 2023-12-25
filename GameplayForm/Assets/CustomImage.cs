using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForm.Assets
{
    public class CustomImage
    {
        Bitmap _blockground = new Bitmap(@".\assets\character\BlockGround.png");
        Bitmap _blockblur = new Bitmap(@".\assets\character\BlockGround.png");
        Bitmap _human = new Bitmap(@".\assets\character\movements-sprite.png");
        public Image BlockGround { get => _blockground; }
        public Image BlockGroundBlur { get => _blockblur; }
        public Image Human { get => _human; }

        public CustomImage()
        {
            for (int w = 0; w < _blockblur.Width; w++)
                for (int h = 0; h < _blockblur.Height; h++)
                {
                    Color c = _blockblur.GetPixel(w, h);
                    Color newC = Color.FromArgb(50, c);
                    _blockblur.SetPixel(w, h, newC);
                }
        }
    }
}
