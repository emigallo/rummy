using System;

namespace rummy_v2.Models
{
    public class Tile : TileBase
    {
        int _value;
        string _color;

        public Tile(int value, string color)
        {
            this._value = value;
            this._color = color;
        }

        public override bool Accept(TileGroup tileGroup, TileBase tileBase)
        {
            return tileGroup.Visit(this, tileBase);
        }

        public override bool HasDistanceOne(TileBase tile)
        {
            return (this._value + 1 == ((Tile) tile)._value);
        }

        public override bool IsSameValueDiffColor(TileBase tile)
        {
            throw new NotImplementedException();
        }
    }
}