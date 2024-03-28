﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApp
{
    public class TBlock: Block
    {

        private readonly Position[][] tiles = new Position[][]
        {
            new Position[] { new(0,1), new(1,0), new(1, 1), new(1, 2) },
            new Position[] { new(0,1), new(1,1), new(1, 2), new(2, 1) },
            new Position[] { new(1,0), new(1,1), new(1, 2), new(2, 1) },
            new Position[] { new(0,1), new(1,0), new(1, 1), new(2, 1) }
        };
        public override int ID => 6;
        protected override Position startOffSet => new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }
}
