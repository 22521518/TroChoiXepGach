using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game.Object
{
    internal interface IBlockAction
    {
        IEnumerable<Position> PositionInTiles();
        void Rotate90();
        void Rotate270();
        void Move(int y, int x);
        void Reset(bool random);
    }
}
