using System;

namespace rummy_v2.Models
{
    public abstract class TileBase
    {
         public abstract bool HasDistanceOne(TileBase tile);
         public abstract bool IsSameValueDiffColor(TileBase tile);
         public abstract bool HasDistanceOneAccept(IVisitorTile visitor);
         public abstract bool IsSameValueDiffColorAccept(IVisitorTile visitor);
    }
}