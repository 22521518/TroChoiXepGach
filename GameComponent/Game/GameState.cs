using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameComponent.Game.Object;

namespace GameComponent.Game
{
    public abstract class GameState
    {
        public readonly int[][] SpeedBlockDrop = new int[][]
        { 
            new int[] {6, 5, 4, 3 , 2},
            new int[] {12, 11, 10, 8, 6},
        };
        protected Block _currentblock;
        public int Level = 0;
        int[] ComboScore = {50, 100, 250, 600 };
        public int Score { get; protected set; }
        public int Line { get; protected set; }
        public Block Hold { get; protected set; }
        public bool GameOver { get; protected set; }
        public GameGrid Grid { get; }
        public QueueBlock Queue { get; }
        public Block CurrentBlock
        {
            get => _currentblock;
            protected set
            {
                _currentblock = value;
                _currentblock.Reset();
            }
        }
        public GameState(bool random = false)
        {
            Grid = new GameGrid();
            Queue = new QueueBlock();
            _currentblock = Queue.GetBlock(random);
            GameOver = false;
            Hold = null;
        }
        abstract public bool IsGameOver(bool isMove);
        abstract public int PlaceBlock();
        public bool MoveDown() //this for block
        {
            _currentblock.Move(1, 0);
            if (!IsBlockLegit())
            {
                _currentblock.Move(-1, 0);
                return false;
            }
            return true;
        }
        public bool IsBlockLegit()
        {
            foreach (Position p in _currentblock.PositionInTiles())
            {
                if (!Grid.IsEmpty(p.Row, p.Column))
                    return false;
            }
            return true;
        }
        public void ClearRow()
        {
            int row = Grid.ClearFullRow();
            Score += ComboScore[row - 1];
            Line += row;
            if (Line > 100)
            {
                Level = 4;
            }
            else if (Line > 70)
            {
                Level = 3;
            }
            else if (Line > 40)
            {
                Level = 2;
            }
            else if (Line > 20)
            {
                Level = 1;
            }
        }
    }
}
