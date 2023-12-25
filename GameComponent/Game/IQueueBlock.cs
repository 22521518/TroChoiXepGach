using GameComponent.Game.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game
{
    internal interface IQueueBlock
    {
        Block GetBlock(bool random);
    }
}
