using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game.Object
{
    public class Position
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public Position(int row, int column)
        {
            this.Column = column;
            this.Row = row;
        }
        public Position(Position other)
        {
            this.Column = other.Column;
            this.Row = other.Row;
        }
        public static bool operator ==(Position a, Position b)
        {
            return a.Column == b.Column && a.Row == b.Row;
        }
        public static bool operator !=(Position a, Position b)
        {
            return a.Column != b.Column || a.Row != b.Row;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Position))
                return false;
            else
                return this == (Position)obj;
        }
        public override int GetHashCode()
        {
            return Row * 20 + Column;
        }
    }
}
