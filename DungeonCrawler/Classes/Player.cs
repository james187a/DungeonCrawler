namespace DungeonCrawler.Classes
{
    public class Player : IBeing
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public Room CurrentRoom { get; set; }

        public Player(string name, int healthPoints, Room currentRoom)
        {
            Name = name;
            HealthPoints = healthPoints;
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