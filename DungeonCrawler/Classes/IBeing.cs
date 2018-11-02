namespace DungeonCrawler.Classes
{
    public interface IBeing
    {
        string Name { get; }
        int Level { get; }
        int CurrentHitPoints { get; }
        int MaxHitPoints { get; }
        Room CurrentRoom { get; set; }
        //IBeing TargetedBeing { get; set; }
        //void SelectTarget(IBeing being);
    }
}