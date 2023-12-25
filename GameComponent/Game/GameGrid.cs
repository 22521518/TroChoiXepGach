using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameComponent.Game.Object;

namespace GameComponent.Game
{
    public class GameGrid : IGrid
    {
        int _column;
        int _row;
        readonly int[,] _grid;

        public int Column { get => _column; }
        public int Row { get => _row; }
        public int this[int row, int column] { set => _grid[row, column] = value; get => _grid[row, column]; }
        public GameGrid(int row = 22, int column = 10)
        {
            _column = column;
            _row = row;
            _grid = new int[row, column];
        }
        void Swap (ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public bool IsInside(int row, int column)
        {
            return row >= 0 && row < _row && column >= 0 && column < _column;
        }
        public bool IsEmpty(int row, int column)
        {
            return IsInside(row, column) && _grid[row, column] == 0;
        }
        public bool IsEmpty(Position block)
        {
            return IsInside(block.Row, block.Column) && _grid[block.Row, block.Column] == 0;
        }
        public bool IsRowEmpty(int row)
        {
            for (int c = 0; c < Column; c++)
            {
                if (_grid[row, c] != 0)
                    return false;
            }
            return true;
        }
        private bool IsRowFull(int row)
        {
            for (int c = 0; c < Column; c++)
                if (_grid[row, c] == 0)
                    return false;
            return true;
        }
        private void MoveRow(int row, int numberOfRows)
        {
            for (int c = 0; c < Column; c++)
            {
                _grid[row + numberOfRows, c] = _grid[row, c];
                _grid[row, c] = 0;
            }
        }
        private void ClearRow(int row, int x = 0)
        {
            for (int c = 0; c < Column; c++)
                _grid[row, c] *= x;
        }
        public void DropColumn(int row , int c)
        {
            for (int r = row; r > 0; r--)
            {
                bool flag = false;
                if (_grid[r, c] == 0 && _grid[r - 1, c] != 0)
                {
                    Swap(ref _grid[r, c], ref _grid[r - 1, c]);
                    flag = true;
                }    
                if (!flag)
                    break;
            }
        }
        public int ClearFullRow()
        {   
            int rowNeedToClear = 0;
            for (int r = _row - 1; r >= 0; r--)
            {
                if (IsRowFull(r))
                {
                    rowNeedToClear++;
                    ClearRow(r);
                }
                else if (rowNeedToClear > 0)
                {
                    MoveRow(r, rowNeedToClear);
                }
            }
            return rowNeedToClear;
        }
        public int MarkedFullRow()
        {
            int cleared = 0;
            for (int r = Row - 1; r >= 0; r--)
            {
                if (IsRowFull(r))
                {
                    cleared++;
                    ClearRow(r, -1);
                }
            }

            return cleared; 
        }
    }
}
