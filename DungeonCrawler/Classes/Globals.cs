using System.Collections.Generic;

namespace DungeonCrawler.Classes
{
    public static class Globals
    {
        public static Dungeon Dungeon { get; set; }
        public static Player Player { get; set; }
        public static List<Monster> Monsters { get; set; }
        public static bool GameStarted { get; set; }
    }
}