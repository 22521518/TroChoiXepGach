using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game.Object
{
    public abstract class Block : IBlockAction
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position startOffSet { get; }

        public abstract int Id { get; } 

        public Position offset { set; get; } 
        public int rotationState;
        public Block(bool random = false)
        {
            Random r = new Random();
            if (random)
                offset = new Position(startOffSet.Row, r.Next(4) + 1);
            else
                offset = new Position(startOffSet.Row, startOffSet.Column);
        }
        public IEnumerable<Position> PositionInTiles()
        {
            foreach (Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offset.Row, (p.Column + offset.Column));
            }
        }
        public void Rotate90()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }
        public void Rotate270()
        {
            if (rotationState == 0)
                rotationState = Tiles.Length - 1;
            else
                rotationState--;
        }
        public void Move(int y, int x)
        {
            this.offset.Row += y;
            this.offset.Column += x;
        }
        public void Reset(bool random = false)
        {
            rotationState = 0;
            if (random)
            {
                Random r = new Random();
                offset.Row = startOffSet.Row; ;
                offset.Column = r.Next() % 6;
            }
            else
            {
                offset.Row = startOffSet.Row;
                offset.Column = startOffSet.Column;
            }


        }
    }
}
