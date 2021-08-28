using System;

namespace rummy_v2.Models
{
    public class Tile : TileBase, IVisitorTile
    {
        int _value;
        string _color;

        public Tile(int value, string color)
        {
            this._value = value;
            this._color = color;
        }

        public override bool HasDistanceOne(TileBase tile)
        {
            return tile.HasDistanceOneAccept(this);
        }

        public override bool HasDistanceOneAccept(IVisitorTile visitor)
        {
            return visitor.HasDistanceOneVisit(this);
        }

        public bool HasDistanceOneVisit(WildCardTile tile)
        {
            return true;
        }

        public bool HasDistanceOneVisit(Tile tile)
        {
            return this._value +1 == tile._value;
        }

        public override bool IsSameValueDiffColor(TileBase tile)
        {
            return tile.IsSameValueDiffColorAccept(this);
        }

        public bool IsSameValueDiffColor(WildCardTile tile)
        {
            return true;
        }

        public bool IsSameValueDiffColor(Tile tile)
        {
            return tile._color!=this._color && tile._value == this._value;
        }

        public override bool IsSameValueDiffColorAccept(IVisitorTile visitor)
        {
            return visitor.IsSameValueDiffColor(this);
        }
    }
}