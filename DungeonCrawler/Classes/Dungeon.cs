using System.Collections.Generic;
using System.Linq;

namespace DungeonCrawler.Classes
{
    public class Dungeon
    {
        public string Name { get; }
        private Coordinates StartingLocation { get; }
        public List<Room> Rooms { get; }

        public Dungeon(string name, Coordinates startingLocation, List<Room> rooms)
        {
            Name = name;
            StartingLocation = startingLocation;
            Rooms = rooms;
        }

        public Room GetRoom(Coordinates coordinates)
        {
            return Rooms.FirstOrDefault(x => x.Coordinates.Equals(coordinates));
        }

        public Room GetStartingRoom()
        {
            return GetRoom(StartingLocation);
        }

        
    }
}