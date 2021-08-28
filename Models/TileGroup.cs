using System;
using System.Collections.Generic;

namespace rummy_v2.Models
{
    public class TileGroup
    {
        const int MAX_SIZE_SERIE = 4;
        const int MAX_SIZE_RUN = 13;
        private List<TileBase> _tiles;
        public TileGroup(List<TileBase> tiles)
        {
            this._tiles = tiles;
        }

        public void Add(List<TileBase> tiles)
        {
            this._tiles.AddRange(tiles);
        }

        public List<TileBase> ExtractTile(string[] selectedTiles)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return this._tiles.Count == 0;
        }

        public bool IsSerie()
        {
            if (!this.IsGroup() || this._tiles.Count > MAX_SIZE_SERIE)
                return false;
            List<string> colors = new List<string>();
            int i = 0;
            while (i < this._tiles.Count - 1 && this.GetTile(i).IsSameValueDiffColor(this.GetTile(i+1)))
            {
                i++;
            }
            return this.GetTile(i).IsSameValueDiffColor(this.GetTile(i+1));

        }        

        public bool IsRun()
        {
            /*if (!this.IsGroup() || this._tiles.Count > MAX_SIZE_RUN)
                return false;
            this.Sort();
            int i = 0;
            while(i<this._tiles.Count -1  && this.GetTile(i).HasDistanceOne(this.GetTile(i+1))){
                i++;
            }
            return this.GetTile(i).HasDistanceOne(this.GetTile(i+1));*/
            if (!this.IsGroup() || this._tiles.Count > MAX_SIZE_RUN)
                return false;
            this.Sort();
            int i = 0;
            while(i<this._tiles.Count -1  && this.GetTile(i).Accept(this, this.GetTile(i+1))){
                i++;
            }
            return this.GetTile(i).Accept(this, this.GetTile(i+1));
        }

        public bool Visit(Tile tile, TileBase tilebase){
            return tile.HasDistanceOne(tilebase);
        }

        public bool Visit(WildCardTile tile, TileBase tileBase){
            return tile.HasDistanceOne(tileBase);
        }
        

        private TileBase GetTile(int i)
        {
            return this._tiles[i];
        }

        private void Sort()
        {
            //TODO: Not implemented
        }

        private bool IsGroup()
        {
            return this._tiles.Count >= 3;
        }
        
    }
}