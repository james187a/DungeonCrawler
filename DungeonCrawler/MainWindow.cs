using DungeonCrawler.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DungeonCrawler
{
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            pnlDungeon.Paint += pnlDungeon_Paint;
        }

        private void pnlDungeon_Paint(object sender, PaintEventArgs e)
        {
            if (Globals.GameStarted)
            {
                Graphics g = e.Graphics;
                DrawDungeon(g, Globals.Dungeon);
                DrawCharacterLocation(g, Globals.Player.CurrentRoom.Coordinates);
            }
        }

        //public abstract class Being : GameObject
        //{
        //    //public Guid ID { get; }
        //    public string Name { get; protected set; }
        //    public int Level { get; protected set; }
        //    public int MaximumHp { get; protected set; }
        //    public int CurrentHp { get; protected set; }
        //    protected Room CurrentRoom { get; }
        //    //public List<Item> Items { get; set; }

        //    protected Being(string name, int level, int maximumHp, int currentHp, Room currentRoom)
        //    {
        //        //ID = Guid.NewGuid();
        //        Name = name;
        //        Level = level;
        //        MaximumHp = maximumHp;
        //        CurrentHp = currentHp;
        //        CurrentRoom = currentRoom;

        //        //currentRoom.Beings.Add(this);
        //    }
        //}


        //private class Player : Being
        //{
        //    private int Experience { get; }
        //    public Tuple<int, int> CurrentLocation { get; private set; }
        //public Dungeon Dungeon { get; set; }
        //private Being Target { get; set; }

        //public Player(string name, int level, int currentHp, int maximumHp, int experience) : base(name, level, currentHp, maximumHp)
        //{
        //    Experience = experience;
        //}

        //public DataTable LookAroundRoom()
        //{
        //    var room = Globals.Dungeon.Rooms.FirstOrDefault(r => Equals(r.Coordinates, CurrentLocation));
        //    //List<string> targets = new List<string>();
        //    var table = new DataTable();
        //    table.Columns.Add("Target Name", typeof(string));
        //    table.Columns.Add("Target Object", typeof(Being));

        //    if (room == null) return table;
        //    foreach (var being in room.Beings.Where(b => b.GetType() == typeof(Monster)))
        //    {
        //        var monster = (Monster) being;
        //        table.Rows.Add(monster.Name, monster);
        //        //targets.Add(monster.Name);
        //    }

        //    return table;
        //}

        // I think this should be split into two methods:
        // 1. Set the monster as the target.
        // 2. Return monster data.
        //public Being TargetMonster(ListControl lst)
        //{
        //    var target = (Being)lst.SelectedValue;
        //    var room = Globals.Dungeon.Rooms.FirstOrDefault(r => r.Coordinates.Equals(CurrentLocation));
        //    Target = room.Beings.FirstOrDefault(b => b.ID.Equals(target.ID));

        //    return Target;
        //}
        //}

        //private class Monster : Being
        //{
        //    public Monster(string name, int level, int maximumHp, int currentHp) : base(name, level, maximumHp, currentHp)
        //    {
        //        Name = $"Monster {name}";
        //        Level = level;
        //        MaximumHp = maximumHp;
        //        CurrentHp = currentHp;
        //    }
        //}

        //public class CharacterLocationMap : IEnumerable<KeyValuePair<Player, Room>>
        //{
        //    KeyValuePair<Player, Room> playerLocation = new KeyValuePair<Player, Room>();

        //    //private readonly IDictionary<Player, Room> _locations = new KayValuePair<Player, Room>();

        //    //public Room this[Player player]
        //    //{
        //    //    get { return playerLocation.Value }
        //    //    set { playerLocation.player, value); }
        //    //}

        //    //public IEnumerator<KeyValuePair<Player, Room>> GetEnumerator()
        //    //{
        //    //    return playerLocation.GetEnumerator();
        //    //}

        //    //System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        //    //{
        //    //    return GetEnumerator();
        //    //}
        //}

        //public void MonsterDie(Room room, Monster monster)
        //{
        //    //room.Monsters.Remove(monster);
        //}

        private void DrawCharacterLocation(Graphics g, Coordinates characterLocation)
        {
            var point = new Point(characterLocation.LocX * 50 + 10, characterLocation.LocY * 50 + 10);
            var size = new Size(30, 30);
            var brush = new SolidBrush(Color.Green);
            var rectangle = new Rectangle(point, size);

            g.FillRectangle(brush, rectangle);
        }

        private void DrawRoom(Graphics g, Room r)
        {
            var room = r;
            int locX = room.Coordinates.LocX;
            int locY = room.Coordinates.LocY;

            if ((locX >= 0) && (locX <= 5) && (locY >= 0) && (locY <= 6))
            {
                var wallPen = new Pen(Color.Black, 1);
                var doorPen = new Pen(Color.White, 1);

                if (room.HasNorthernWall)
                    g.DrawLine(wallPen, locX * 50, locY * 50, locX * 50 + 49, locY * 50);
                else if (!room.HasNorthernWall)
                    g.DrawLine(doorPen, locX * 50 + 1, locY * 50, locX * 50 + 49, locY * 50);                

                if (room.HasEasternWall)
                    g.DrawLine(wallPen, locX * 50 + 49, locY * 50, locX * 50 + 49, locY * 50 + 49);
                else if (!room.HasEasternWall)
                    g.DrawLine(doorPen, locX * 50 + 49, locY * 50 + 1, locX * 50 + 49, locY * 50 + 49);       

                if (room.HasSouthernWall)
                    g.DrawLine(wallPen, locX * 50, locY * 50 + 49, locX * 50 + 49, locY * 50 + 49);
                else if (!room.HasSouthernWall)
                    g.DrawLine(doorPen, locX * 50 + 1, locY * 50 + 49, locX * 50 + 48, locY * 50 + 49);                

                if (room.HasWesternWall)
                    g.DrawLine(wallPen, locX * 50, locY * 50, locX * 50, locY * 50 + 49);
                else if (!room.HasWesternWall)
                    g.DrawLine(doorPen, locX * 50, locY * 50 + 1, locX * 50, locY * 50 + 48);                
            }
        }

        private void DrawDungeon(Graphics g, Dungeon dungeon)
        {
            foreach (var room in dungeon.Rooms)
            {
                DrawRoom(g, room);
            }
        }

        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            var frm = new FrmNewGame();
            frm.ShowDialog();

            if (!frm.StartGameIsSuccessful) return;

            var name = frm.PlayerName;
            var dungeon = frm.SelectedDungeon;
            var currentRoom = dungeon.GetStartingRoom();

            var player = new Player(name, 1, 100, currentRoom);
            //dungeon.Rooms.FirstOrDefault(r => r.IsStartingLocation)?.Beings.Add(player);

            //PopulateCharacterInfo(player);

            Globals.Player = player;
            Globals.Dungeon = dungeon;
            Globals.GameStarted = true;

            pnlDungeon.Invalidate();
        }

        private void PopulateCharacterInfo(Player player)
        {
            txtCharacterName.Text = player.Name;
            txtCharacterLevel.Text = $"{player.Level.ToString()} / 60";
            prgCharacterHP.Maximum = player.MaxHitPoints;
            prgCharacterHP.Value = player.CurrentHitPoints;
            //txtCharacterCurrentLocation.Text = $"{player.CurrentLocation.Coordinates.Item1.ToString()}, {player.CurrentLocation.Coordinates.Item2.ToString()}";
        }

        //private void UpdateMonsterStats(Monster monster)
        //{
        //    txtMonsterID.Text = monster.ID.ToString();
        //    txtMonsterName.Text = monster.Name;
        //    txtMonsterLevel.Text = $"{monster.Level.ToString()} / 60";
        //    prgMonsterHP.Maximum = monster.MaximumHp;
        //    prgMonsterHP.Value = monster.CurrentHp;
        //}

        private void btnNorth_Click(object sender, EventArgs e)
        {
            Globals.Player.MoveNorth();
            //PopulateCharacterInfo(Globals.Player);
            pnlDungeon.Invalidate();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            Globals.Player.MoveEast();
            //PopulateCharacterInfo(Globals.Player);
            pnlDungeon.Invalidate();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            Globals.Player.MoveSouth();
            //PopulateCharacterInfo(Globals.Player);
            pnlDungeon.Invalidate();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            Globals.Player.MoveWest();
            //PopulateCharacterInfo(Globals.Player);
            pnlDungeon.Invalidate();
        }

        //private void roomSearched(Room room)
        //{

        //}

        //private void roomPartiallySearched(Room room)
        //{

        //}

        private void btnLookAroundRoom_Click(object sender, EventArgs e)
        {
            lstAvailableTargets.Items.Clear();
            txtChatWindow.AppendText("You see: ");

            //foreach (DataRow target in Globals.Player.LookAroundRoom().Rows)
            //{
            //    //txtChatWindow.AppendText($"{target.}\r\n");
            //    //lstAvailableTargets.Items.Add($"{target.Name}\r\n");
            //}
        }

        //private void ClearMonsterStats()
        //{
        //    txtMonsterID.Clear();
        //    txtMonsterName.Clear();
        //    txtMonsterLevel.Clear();
        //    prgMonsterHP.Value = 0;
        //}

        private void btnAttackTarget_Click(object sender, EventArgs e)
        {
            //PlayerAttacksMonster(Globals.Player.Target);
        }

        //private void PlayerAttacksMonster(Monster monster)
        //{
        //    //var damage = 10;

        //    //if (damage <= monster.CurrentHP)
        //    //{
        //    //    monster.CurrentHP -= 10;
        //    //    UpdateMonsterStats(monster);
        //    //    txtChatWindow.AppendText($"You hit {monster.Name} for 10 damage!\r\n");

        //    //    if (IsDead(monster))
        //    //    {
        //    //        MonsterDie(Globals.Dungeon.DungeonLayout[Globals.Player.CurrentLocation], monster);
        //    //        ClearMonsterStats();
        //    //    }
        //    //    else
        //    //        MonsterAttacksPlayer(Globals.Player);
        //    //}
        //    //else if (monster.CurrentHP > 0 && monster.CurrentHP < damage)
        //    //{
        //    //    monster.CurrentHP = 0;
        //    //    MonsterDie(Globals.Dungeon.DungeonLayout[Globals.Player.CurrentLocation], monster);
        //    //    ClearMonsterStats();
        //    //}
            
        //}

        //private void MonsterAttacksPlayer(Player player)
        //{
        //    //var damage = 10;

        //    //if (damage <= player.CurrentHP)
        //    //{
        //    //    player.CurrentHP -= 10;
        //    //    PopulateCharacterInfo(player);
        //    //    txtChatWindow.AppendText($"{player.Target.Name} hit you for 10 damage!\r\n");

        //    //    if (IsDead(player))
        //    //    {
        //    //        GameOver();
        //    //    }
        //    //}
        //    //else if (player.CurrentHP > 0 && player.CurrentHP < damage)
        //    //{
        //    //    player.CurrentHP = 0;
        //    //    GameOver();
        //    //}
        //}

        //private bool IsDead(Monster monster)
        //{
        //    if (monster.CurrentHp == 0)
        //        return true;

        //    return false;
        //}

        //private bool IsDead(Player player)
        //{
        //    //if (player.CurrentHP == 0)
        //    //    return true;

        //    return false;
        //}

        //private void GameOver()
        //{
        //    Globals.Dungeon = null;
        //    //Globals.Player = null;
        //    Globals.GameStarted = false;

        //    pnlDungeon.Invalidate();
        //    ClearPlayerStats();
        //    ClearMonsterStats();
        //}

        //private void ClearPlayerStats()
        //{
        //    txtCharacterName.Clear();
        //    txtCharacterLevel.Clear();
        //    txtCharacterCurrentLocation.Clear();
        //    prgCharacterHP.Value = 0;
        //}

        private void lstAvailableTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Monster monster = Globals.Player.TargetMonster((ListBox) sender);

            //UpdateMonsterStats(monster);
        }
    }
}