﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponent.Game.Object
{
    public class OBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[] {new Position(0,0), new Position(0,1), new Position(1, 0), new Position(1,1)},
        };
        public override int Id => 4;
        protected override Position startOffSet => new Position(0, 4); // 0 < y < 9
        protected override Position[][] Tiles => tiles;
    }
}
