using System;

namespace rummy_v2.Models
{
    public abstract class TileBase
    {

        private int _value;
        private int _color;

        protected abstract bool IsEqualValue(int value);
        protected abstract bool IsEqualColor(TileBase tile);

        public bool HasSameColor(TileBase tile)
        {
            return tile.IsEqualColor(this);
        }

        public bool HasDistanceOne(TileBase tile)
        {
            return tile.IsEqualValue(this._value + 1);
        }
    }
}