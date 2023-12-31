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
        public Block GetBlockId(int id)
        {
            switch (id)
            {
                case 0: return new IBlock();
                case 1: return new JBlock();
                case 2: return new LBlock();
                case 3: return new OBlock();
                case 4: return new SBlock();
                case 5: return new TBlock();
                case 6: return new ZBlock();
            }
            return null;
        }
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
