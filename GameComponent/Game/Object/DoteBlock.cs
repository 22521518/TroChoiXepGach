using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game.Object
{
    public class DoteBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[] {new Position(0, 0)},

        };
        public override int Id => 8;
        protected override Position startOffSet => new Position(0, 3); // 0 < y < 9
        protected override Position[][] Tiles => tiles;
    }
}
