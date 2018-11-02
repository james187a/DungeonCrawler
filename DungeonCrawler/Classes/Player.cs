namespace DungeonCrawler.Classes
{
    public class Player : IBeing
    {
        public string Name { get; }
        public int Level { get; }
        public int CurrentHitPoints { get; }
        public int MaxHitPoints { get; }
        public Room CurrentRoom { get; set; }

        public Player(string name, int level, int maxHitPoints, Room currentRoom)
        {
            Name = name;
            Level = level;
            CurrentHitPoints = maxHitPoints;
            MaxHitPoints = maxHitPoints;
            CurrentRoom = currentRoom;
        }

        public void MoveNorth()
        {
            if (CurrentRoom.HasNorthernWall) return;

            SetRoom(new Coordinates(CurrentRoom.Coordinates.LocX, CurrentRoom.Coordinates.LocY - 1));
        }

        public void MoveEast()
        {
            if (CurrentRoom.HasEasternWall) return;

            SetRoom(new Coordinates(CurrentRoom.Coordinates.LocX + 1, CurrentRoom.Coordinates.LocY));
        }

        public void MoveSouth()
        {
            if (CurrentRoom.HasSouthernWall) return;

            SetRoom(new Coordinates(CurrentRoom.Coordinates.LocX, CurrentRoom.Coordinates.LocY + 1));
        }

        public void MoveWest()
        {
            if (CurrentRoom.HasWesternWall) return;

            SetRoom(new Coordinates(CurrentRoom.Coordinates.LocX - 1, CurrentRoom.Coordinates.LocY));
        }

        private void SetRoom(Coordinates coordinates)
        {
            CurrentRoom = Globals.Dungeon.GetRoom(coordinates);
        }
    }
}