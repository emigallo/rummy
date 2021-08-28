using System;
using System.Collections.Generic;

namespace rummy_v2.Models
{
    public class Table
    {
        const int NEW_GROUP = 0;
        List<TileGroup> _tileGroups;
        public Table()
        {
            _tileGroups = new List<TileGroup>();
        }

        public void AddTiles(List<TileBase> tiles, int destination)
        {
            if (destination != NEW_GROUP)
            {
                this._tileGroups[destination - 1].Add(tiles);
            }
            else
            {
                this._tileGroups.Add(new TileGroup(tiles));
            }
        }

        public bool IsValid()
        {
            foreach (TileGroup tileGroup in this._tileGroups)
            {
                if (!tileGroup.IsSerie() && !tileGroup.IsRun())
                {
                    return false;
                }
            }
            return true;
        }

        public void MoveTilesInTable(Movement movement)
        {
            TileGroup tileGroup = this._tileGroups[movement.Origin];
            List<TileBase> tiles = tileGroup.ExtractTile(movement.SelectedTiles.Split(" "));
            this.AddTiles(tiles, movement.Destination);
            if (tileGroup.IsEmpty())
            {
                this._tileGroups.Remove(tileGroup);
            }
        }
    }
}