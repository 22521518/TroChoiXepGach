using GameComponent.Game.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game
{
    public class QueueBlock
    {
        private readonly Block[] queue = new Block[]
       {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
       };
        readonly Random random = new Random();
        public Block NextBlock { get; set; }
        public QueueBlock()
        {
            NextBlock = RandomBlock();
        }
        Block RandomBlock()
        {
            return queue[random.Next() % queue.Length];
        }
        public Block GetBlock(bool random = false)
        {
            Block temp = NextBlock;
            do
            {
                NextBlock = RandomBlock();
            } while (NextBlock.Id == temp.Id);
            NextBlock.Reset(random);
            return temp;
        }

    }
}
