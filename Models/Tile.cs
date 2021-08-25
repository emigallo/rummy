using System;

namespace rummy_v2.Models
{
    public class Tile
    {
        int _value;
        string _color;        

        public Tile(int value, string color)
        {
            this._value = value;
            this._color = color;
        }

        internal bool IsPrevious(Tile tile)
        {
            throw new NotImplementedException();
        }

        internal bool IsSameValueDiffColor(Tile tile)
        {
            throw new NotImplementedException();
        }
    }
}