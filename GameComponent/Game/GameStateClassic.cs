using GameComponent.Game.Object;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game
{
    public class GameStateClassic : GameState
    {
        public GameStateClassic() : base()
        { }
        public override bool IsGameOver(bool isMove = false)
        {
            return !(Grid.IsRowEmpty(0) && Grid.IsRowEmpty(1));
        }
        public bool IsPositionLegit()
        {
            foreach (Position p in _currentblock.PositionInTiles())
            {
                if (!Grid.IsEmpty(p.Row, p.Column))
                    return false;
            }
            return true;
        }
        public bool BlockRotate90()
        {
            _currentblock.Rotate90();
            if (!IsPositionLegit())
            {
                _currentblock.Rotate270();
                return false;
            }
            return true;
        }
        public bool MoveLeft()
        {
            _currentblock.Move(0, -1);
            if (!IsPositionLegit())
            {
                _currentblock.Move(0, 1);
                return false;
            }
            return true;
        }
        public bool MoveRight()
        {
            _currentblock.Move(0, 1);
            if (!IsPositionLegit())
            {
                _currentblock.Move(0, -1);
                return false;
            }
            return true;
        }
        public override int PlaceBlock()
        {
            foreach (Position p in _currentblock.PositionInTiles())
                Grid[p.Row, p.Column] = CurrentBlock.Id;

            if (IsGameOver())
                GameOver = true;
            else
            {
                _currentblock = Queue.GetBlock();
                while (Hold != null && _currentblock.Id == Hold.Id)
                {
                    _currentblock = Queue.GetBlock();
                }    
            }

            return Grid.MarkedFullRow();
        }
        int DropDistance(Position p)
        {
            int drop = 0;
            while (Grid.IsEmpty(p.Row + drop + 1, p.Column))
                drop++;
            return drop;
        }

        public int BlockDropDistance()
        {
            int drop = Grid.Row;
            foreach (Position p in _currentblock.PositionInTiles())
                drop = System.Math.Min(drop, DropDistance(p));
            return drop;
        }
        public int Drop()
        {
            _currentblock.Move(BlockDropDistance(), 0);
            return PlaceBlock();
        }
        public void HoldBlock()
        {
            if (Hold != null)
                return;
            Hold = _currentblock;
            Hold.Reset();
            _currentblock = Queue.GetBlock();
        }
        public void ChangeBlock()
        {
            if (Hold == null)
                return;
            Queue.NextBlock = _currentblock;
            Queue.NextBlock.Reset();
            _currentblock = Hold;
            Hold = null;
        }
    }
}
