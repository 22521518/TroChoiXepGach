using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game
{
    public interface IBlockMovement
    {
        bool MoveLeft();
        bool MoveRight();
    }
}
