using System;
using System.Collections.Generic;

namespace rummy_v2.Models
{
    public class Player
    {
        Table table;
        List<Tile> _rack;

        public Player(Table table)
        {
            this.table = table;
            this._rack = new List<Tile>();
        }               

        public void PlayTurn()
        {
            throw new NotImplementedException();
        }

        public bool TileAddedToGroup()
        {
            throw new NotImplementedException();
        }

        public void ExtractTile(object p)
        {
            throw new NotImplementedException();
        }

        public bool IsWinner()
        {
            throw new NotImplementedException();
        }
    }
}