using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForm.Assets
{
    public class CustomFont
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        public readonly FontFamily Alkhemikal;
        public readonly FontFamily Font;
        public readonly FontFamily ArcadeOut;
        public readonly FontFamily ArcadeIn;
        public readonly FontFamily PixelOlde;

        public CustomFont()
        {
            pfc.AddFontFile(@".\assets\font\pixolde.ttf");
            pfc.AddFontFile(@".\assets\font\alkhemikal.ttf");   
            pfc.AddFontFile(@".\assets\font\font.ttf");         
            pfc.AddFontFile(@".\assets\font\8-bit Arcade Out.ttf");         
            pfc.AddFontFile(@".\assets\font\8-bit Arcade In.ttf");


            PixelOlde = pfc.Families[4];
            Alkhemikal = pfc.Families[3];
            Font = pfc.Families[2];
            ArcadeOut = pfc.Families[1];
            ArcadeIn = pfc.Families[0];
        }
    }
}
