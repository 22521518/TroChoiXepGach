using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Player
{
    internal interface IWriterSQL
    {
        int InsertPlayer(string Name);
        void InsertNewScore(Player User);
    }
}
