using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler.Classes
{
    public interface IBeing
    {
        string Name { get; set; }
        int Level { get; set; }
        int CurrentHitPoints { get; set; }
        int MaxHitPoints { get; set; }
        Room CurrentRoom { get; set; }
        //IBeing TargetedBeing { get; set; }
        //void SelectTarget(IBeing being);
    }
}