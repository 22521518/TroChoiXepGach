using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game.Object
{
    public class Character : ICharacterAction
    {
        readonly int ratio = 4;
        public Position[] Body = new Position[4];
        int _steps = 0, _jumpsteps = 0;
        public int Steps { get => _steps; }
        public int JumpSteps { get => _jumpsteps; }
        public bool IsLanded = true;
        public bool IsLeft { get; private set; }
        public bool Hold { set; get; }
        public Character(int x = 21, int y = 4)
        {
            Hold = false;
            IsLeft = true;
            IsLanded = true;
            Body[0] = Body[1] = Body[2] = Body[3] = new Position(x, y);
        }
        public Character(Character other)
        {
            for (int i = 0; i < 4; i++)
                this.Body[i] = new Position(other.Body[i]);

            this.IsLanded = other.IsLanded;
        }
        public IEnumerable<Position> PositionInTiles()
        {
            foreach (Position p in Body)
            {
                yield return new Position(p.Row, p.Column);
            }
        }
        public void MoveForward(int x = 1)
        {
            Body[0].Row += x / 4;
            if (_jumpsteps != 0)
                Body[2].Row += x / 4;
            if ((_steps + x) % ratio == 0 && _steps + x != 0)
            {
                if (_jumpsteps != 0)
                {
                    Body[2] = Body[3];
                    Body[0] = Body[1];
                }
                else
                {
                    Body[2] = Body[3] = Body[0] = Body[1];
                }
                _steps = 0;
                return;
            }
            else if (_steps == 0)
            {
                int next = x >= 0 ? 1 : -1;
                Body[3] = new Position(Body[2].Row, Body[2].Column + next);
                Body[1] = new Position(Body[0].Row, Body[0].Column + next);
            }

            _steps += x;

            if (_steps == 0)
            {
                Body[3] = Body[2];
                Body[1] = Body[0];
            }

        }
        public void MoveBackward()
        {
            if (_jumpsteps != 0)
            {
                Body[3] = Body[2];
                Body[1] = Body[0];
            }
            else
            {
                Body[3] = Body[2] = Body[1] = Body[0];
            }

            _steps = 0;
        }
        public void Jump(int y)
        {
            IsLanded = false;
            if ((_jumpsteps + y) % ratio == 0 && _jumpsteps + y != 0)
            {
                if (_steps != 0) 
                {
                    Body[1] = Body[3];
                    Body[0] = Body[2];
                }
                else
                {
                    Body[1] = Body[3] = Body[0] = Body[2];
                }
                _jumpsteps = 0;
                return;
            }
            else if (_jumpsteps == 0)
            {
                int next = y >= 0 ? 1 : -1;
                Body[3] = new Position(Body[1].Row + next, Body[1].Column);
                Body[2] = new Position(Body[0].Row + next, Body[0].Column);
            }

            _jumpsteps += y;

            if (_jumpsteps == 0)
            {
                Body[3] = Body[1];
                Body[2] = Body[0];
            }
        }
        public void Landed()
        {
            IsLanded = true;
            _jumpsteps = 0;
            if (_steps != 0)
                Body[3] = Body[1];
            Body[2] = Body[0];
        }
        public void TurnLeft(bool dir)
        {
            IsLeft = dir;
        }
    }
}
