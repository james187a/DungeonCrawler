namespace DungeonCrawler.Classes
{
    public class Monster : IBeing
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public Room CurrentRoom { get; set; }

        public Monster(string name, int level, int maxHitPoints, Room currentRoom)
        {
            Name = name;
            Level = level;
            CurrentHitPoints = maxHitPoints;
            MaxHitPoints = maxHitPoints;
            CurrentRoom = currentRoom;
        }
    }
}
