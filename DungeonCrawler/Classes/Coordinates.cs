namespace DungeonCrawler.Classes
{
    public class Coordinates
    {
        public int LocX { get; }
        public int LocY { get; }

        public Coordinates(int locX, int locY)
        {
            LocX = locX;
            LocY = locY;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var coordinates = obj as Coordinates;

            return LocX == coordinates.LocX && LocY == coordinates.LocY;
        }
    }
}