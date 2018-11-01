namespace DungeonCrawler.Classes
{
    public class Room
    {
        public Coordinates Coordinates { get; }
        public bool HasNorthernWall { get; }
        public bool HasEasternWall { get; }
        public bool HasSouthernWall { get; }
        public bool HasWesternWall { get; }

        public Room(Coordinates coordinates, bool hasNorthernWall, bool hasEasternWall, bool hasWesternWall, bool hasSouthernWall)
        {
            Coordinates = coordinates;
            HasNorthernWall = hasNorthernWall;
            HasEasternWall = hasEasternWall;
            HasWesternWall = hasWesternWall;
            HasSouthernWall = hasSouthernWall;
        }
    }
}