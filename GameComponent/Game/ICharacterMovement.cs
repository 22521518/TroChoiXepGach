using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game
{
    public interface ICharacterMovement
    {
        bool IsPositionLegit();
        bool MoveLeft();
        bool MoveRight();
        bool HitYourHead(int c);
        bool Jump(int g);
        bool IsOnLand();
        bool Fall(int g);
        void TakeBlock();
        void DropBlock();
    }
}
