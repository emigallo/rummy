namespace rummy_v2.Models
{
    public class WildCardTile : TileBase
    {
        public override bool HasDistanceOne(TileBase tile)
        {
           return true;
        }

        public override bool IsSameValueDiffColor(TileBase tile)
        {
            return true;
        }
    }
}