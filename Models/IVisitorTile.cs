namespace rummy_v2.Models
{
    public interface IVisitorTile
    {
        bool HasDistanceOneVisit(WildCardTile tile);
        bool HasDistanceOneVisit(Tile tile);
        bool IsSameValueDiffColor(WildCardTile tile);
        bool IsSameValueDiffColor(Tile tile);
        
    }
}