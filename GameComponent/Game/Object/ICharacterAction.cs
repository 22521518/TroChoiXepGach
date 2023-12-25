using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game.Object
{
    internal interface ICharacterAction
    {
        IEnumerable<Position> PositionInTiles();
        void MoveForward(int x = 1);
        void MoveBackward();
        void Jump(int y);
        void Landed();
        void TurnLeft(bool dir);
    }
}
