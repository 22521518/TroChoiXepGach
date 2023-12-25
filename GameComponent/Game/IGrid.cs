using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameComponent.Game.Object;

namespace GameComponent.Game
{
    public interface IGrid
    {
        bool IsInside(int row, int column);
        bool IsEmpty(int row, int column);
        bool IsEmpty(Position block);
        bool IsRowEmpty(int row);
        int ClearFullRow();
        void DropColumn(int row, int column);
        int MarkedFullRow();
    }
}
