using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameComponent.Game.Object;
namespace GameComponent.Game
{
    public class GameStateHuman : GameState, ICharacterMovement
    {
        public Character Human { get; }
        public GameStateHuman () : base (true) 
        { 
            Human = new Character ();
        }
        public override bool IsGameOver(bool isMove = false)
        {
            Position head1 = new Position(Human.Body[2]);
            Position head2 = new Position(Human.Body[3]);
            Position body1 = new Position(Human.Body[0]);
            Position body2 = new Position(Human.Body[1]);
            if (Human.JumpSteps == 2)
            {
                head1.Row--;
                head2.Row--;

            }
            if ((!Grid.IsEmpty(head1) || !Grid.IsEmpty(head2) || !Grid.IsEmpty(body1) || !Grid.IsEmpty(body2)) && !isMove)
            {
                GameOver = true;
                return true;
            }
            foreach (Position pos in _currentblock.PositionInTiles())
            {

                if (pos == head1 || pos == head2 || pos == body1 || pos == body2)
                {
                    GameOver = true;
                    return true;
                }
            }
            GameOver = (!(Grid.IsRowEmpty(0) && Grid.IsRowEmpty(1)));
            return GameOver;
        }
        public bool IsPositionLegit()
        {
            foreach (Position p in Human.PositionInTiles())
                if (!Grid.IsEmpty(p.Row, p.Column))
                    return false;
            return true;
        }
        public bool MoveLeft()
        {
            Human.TurnLeft(true);
            if (HitYourHead(-1) && Human.Steps == 0)
                return false;
            Human.MoveForward(-1);
            if (IsGameOver(true))
            {
                return false;
            }
            if (!IsPositionLegit())
                Human.MoveBackward();
            return true;
        }
        public bool MoveRight()
        {
            Human.TurnLeft(false);
            if (HitYourHead(1) && Human.Steps == 0)
                return false;
            Human.MoveForward(1);
            if (IsGameOver(true))
            {
                return false;
            }
            if (!IsPositionLegit())
                Human.MoveBackward();
            return true;
        }
        public bool HitYourHead(int c = 0)
        {
            if (Human.Body[2].Row == 2)
                return true;
            int RowAbove2, ColumnAbove2;
            int RowAbove3, ColumnAbove3;

            RowAbove2 = Human.Body[2].Row - 1;
            ColumnAbove2 = Human.Body[2].Column;
            RowAbove3 = Human.Body[3].Row - 1;
            ColumnAbove3 = Human.Body[3].Column;

            return !(Grid.IsEmpty(RowAbove2, ColumnAbove2 + c)) || !(Grid.IsEmpty(RowAbove3, ColumnAbove3 + c));
        }
        public bool Jump(int g = 1)
        {
            Human.Jump(-g);
            if (!IsPositionLegit())
            {
                Human.Jump(g);
                Human.Landed();
                return false;
            }
            if (HitYourHead() && Math.Abs(Human.JumpSteps) > 1)
                return false;
            if (IsGameOver(true))
            {
                return false;
            }
            return true;
        }
        public bool IsOnLand()
        {
            if (Human.Body[0].Row == Grid.Row - 1)
                return true;

            int RowBeneath, ColumnBeneath;
            int RowBeneath1, ColumnBeneath1;
            RowBeneath = Human.Body[0].Row + 1;
            ColumnBeneath = Human.Body[0].Column;
            RowBeneath1 = Human.Body[1].Row + 1;
            ColumnBeneath1 = Human.Body[1].Column;

            Human.IsLanded = !Grid.IsEmpty(RowBeneath, ColumnBeneath) || !Grid.IsEmpty(RowBeneath1, ColumnBeneath1);
            return Human.IsLanded;
        }
        public bool Fall(int g)
        {
            if (IsOnLand())
            {
                Human.Landed();
                return false;
            }
            Human.Jump(g);

            return true;
        }
        public void TakeBlock()
        {
            if (Hold != null)
                return;
            if (Human.Body[1].Column == 9 && !Human.IsLeft)
                return;
            if (Human.Body[1].Column == 0 && Human.IsLeft)
                return;
            int block = Human.IsLeft ? -1 : 1;
            if ((Human.Steps > 0 && Human.IsLeft) || (Human.Steps < 0 && !Human.IsLeft))
                block *= 2;
            if (Grid.IsEmpty(Human.Body[1].Row, Human.Body[1].Column + block))
                return;
            Grid[Human.Body[1].Row, Human.Body[1].Column + block] = 0;
            Grid.DropColumn(Human.Body[1].Row, Human.Body[1].Column + block);
            Hold = new DoteBlock();
        }
        public void DropBlock()
        {
            if (Hold == null)
                return;
            if (Human.Body[1].Column == 9 && !Human.IsLeft)
                return;
            if (Human.Body[1].Column == 0 && Human.IsLeft)
                return;
            int block = Human.IsLeft ? -1 : 1;
            if ((Human.Steps > 0 && Human.IsLeft) || (Human.Steps < 0 && !Human.IsLeft))
                block *= 2;
            if (!Grid.IsEmpty(Human.Body[1].Row, Human.Body[1].Column + block))
                return;
                foreach (Position p in _currentblock.PositionInTiles())
                    if (p.Row == Human.Body[1].Row && p.Column == Human.Body[1].Column + block)
                        return;
            Grid[Human.Body[1].Row, Human.Body[1].Column + block] = 1;
            Hold = null;
        }
        public override int PlaceBlock()
        {
            foreach (Position p in _currentblock.PositionInTiles())
                Grid[p.Row, p.Column] = CurrentBlock.Id;

            if (IsGameOver())
                GameOver = true;
            else
            {
                _currentblock = Queue.GetBlock(true);
            }

            return Grid.MarkedFullRow();
        }
    }
}
