using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DungeonCrawler
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            pnlDungeon.Paint += new PaintEventHandler(pnlDungeon_Paint);
        }

        private static class Globals
        {
            public static Dungeon Dungeon { get; set; }
            public static Player Player { get; set; }
            public static bool GameStarted { get; set; }
        }

        private void pnlDungeon_Paint(object sender, PaintEventArgs e)
        {
            if (Globals.GameStarted)
            {
                Graphics g = e.Graphics;
                DrawDungeon(g, Globals.Dungeon);
                DrawCharacterLocation(g, Globals.Player.CurrentLocation);
            }
        }

        public void StartGame()
        {
            string harryPotter = @"C:\Users\james\Desktop\Harry Potter's Revenge.json";
            string zelda = @"C:\Users\james\Desktop\The Legend of Zelda.json";
            string firionaVie = @"C:\Users\james\Desktop\The Hunt for Firiona Vie.json";

            using (StreamReader r = new StreamReader(firionaVie))
            {
                string json = r.ReadToEnd();
                Dungeon dungeon = JsonConvert.DeserializeObject<Dungeon>(json);
                Globals.Dungeon = dungeon;
                Globals.GameStarted = true;
                pnlDungeon.Invalidate();
            }
        }

        public abstract class GameObject
        {
            public Guid ID { get; }
            public List<Dungeon> Dungeons { get; }

            public GameObject()
            {
                ID = Guid.NewGuid();
            }
        }

        public class Dungeon : GameObject
        {
            public string Name { get; }
            public List<Room> Rooms { get; }

            public Dungeon(string name, List<Room> rooms) : base()
            {
                //ID = Guid.NewGuid();
                Name = name;
                Rooms = rooms;

                Dungeons.Add(this);
            }
        }

        public class Room : GameObject
        {
            private static Random _randomNumber = new Random();

            //public Guid ID { get; }
            public Tuple<int, int> Coordinates { get; }
            public bool IsStartingLocation { get; }
            public bool HasNorthernWall { get; }
            public bool HasEasternWall { get; }
            public bool HasSouthernWall { get; }
            public bool HasWesternWall { get; }
            public List<Being> Beings { get; set; }

            public Room(Tuple<int, int> coordinates, bool isStartingLocation, bool hasNorthernWall, bool hasEasternWall, bool hasSouthernWall, bool hasWesternWall) : base()
            {
                //ID = Guid.NewGuid();
                Coordinates = coordinates;
                IsStartingLocation = isStartingLocation;
                HasNorthernWall = hasNorthernWall;
                HasEasternWall = hasEasternWall;
                HasSouthernWall = hasSouthernWall;
                HasWesternWall = hasWesternWall;

                Beings = new List<Being>();

                //if (IsStartingLocation)
                //{
                //    Beings.Add(new Player("Test", 1, 100, 100, 0));
                //}

                for (var i = 0; i <= _randomNumber.Next(0, 3); i++)
                {
                    Beings.Add(new Monster(i.ToString(), 1, 20, 20));
                }
            }
        }

        public abstract class Being : GameObject
        {
            //public Guid ID { get; }
            public string Name { get; set; }
            public int Level { get; set; }
            public int MaximumHP { get; set; }
            public int CurrentHP { get; set; }
            public Room CurrentRoom { get; set; }
            //public List<Item> Items { get; set; }

            protected Being(string name, int level, int maximumHP, int currentHP) : base()
            {
                //ID = Guid.NewGuid();
                Name = name;
                Level = level;
                MaximumHP = maximumHP;
                CurrentHP = currentHP;

                //currentRoom.Beings.Add(this);
            }
        }

        
        public class Player : Being
        {
            public int Experience { get; set; }
            public Tuple<int, int> CurrentLocation { get; set; }
            //public Dungeon Dungeon { get; set; }
            public Being Target { get; set; }

            public Player(string name, int level, int currentHP, int maximumHP, int experience) : base(name, level, currentHP, maximumHP)
            {
                Experience = experience;
            }

            public void MoveNorth()
            {
                if (!CurrentRoom.HasNorthernWall)
                    Globals.Player.CurrentLocation = new Tuple<int, int>(CurrentLocation.Item1, CurrentLocation.Item2 - 1);
            }

            public void MoveEast()
            {
                Room room = Globals.Dungeon.Rooms.Where(r => r.Coordinates.Equals(CurrentLocation)).FirstOrDefault<Room>();

                if (!room.HasEasternWall)
                    Globals.Player.CurrentLocation = new Tuple<int, int>(CurrentLocation.Item1 + 1, CurrentLocation.Item2);
            }

            public void MoveSouth()
            {
                Room room = Globals.Dungeon.Rooms.Where(r => r.Coordinates.Equals(CurrentLocation)).FirstOrDefault<Room>();

                if (!room.HasSouthernWall)
                    Globals.Player.CurrentLocation = new Tuple<int, int>(CurrentLocation.Item1, CurrentLocation.Item2 + 1);
            }

            public void MoveWest()
            {
                Room room = Globals.Dungeon.Rooms.Where(r => r.Coordinates.Equals(CurrentLocation)).FirstOrDefault<Room>();

                if (!room.HasWesternWall)
                    Globals.Player.CurrentLocation = new Tuple<int, int>(CurrentLocation.Item1 - 1, CurrentLocation.Item2);
            }

            public DataTable LookAroundRoom()
            {
                Room room = Globals.Dungeon.Rooms.Where(r => r.Coordinates == CurrentLocation).FirstOrDefault<Room>();
                //List<string> targets = new List<string>();
                DataTable table = new DataTable();
                table.Columns.Add("Target Name", typeof(string));
                table.Columns.Add("Target Object", typeof(Being));

                foreach (Monster monster in room.Beings.Where(b => b.GetType() == typeof(Monster)))
                {
                    table.Rows.Add(monster.Name, monster);
                    //targets.Add(monster.Name);
                }

                return table;
            }

            // I think this should be split into two methods:
            // 1. Set the monster as the target.
            // 2. Return monster data.
            public Being TargetMonster(ListBox lst)
            {
                Being target = (Being)lst.SelectedValue;
                Room room = Globals.Dungeon.Rooms.Where(r => r.Coordinates.Equals(CurrentLocation)).FirstOrDefault<Room>();
                Target = room.Beings.Where(b => b.ID.Equals(target.ID)).FirstOrDefault<Being>();

                return Target;
            }
        }

        public class Monster : Being
        {
            public Monster(string name, int level, int maximumHP, int currentHP) : base(name, level, maximumHP, currentHP)
            {
                Name = $"Monster {name}";
                Level = level;
                MaximumHP = maximumHP;
                CurrentHP = currentHP;
            }
        }

        public class CharacterLocationMap : IEnumerable<KeyValuePair<Player, Room>>
        {
            KeyValuePair<Player, Room> playerLocation = new KeyValuePair<Player, Room>();

            //private readonly IDictionary<Player, Room> _locations = new KayValuePair<Player, Room>();

            public Room this[Player player]
            {
                get { return playerLocation.Value }
                set { playerLocation.player, value); }
            }

            public IEnumerator<KeyValuePair<Player, Room>> GetEnumerator()
            {
                return playerLocation.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public void MonsterDie(Room room, Monster monster)
        {
            //room.Monsters.Remove(monster);
        }

        private void DrawCharacterLocation(Graphics g, Tuple<int, int> characterLocation)
        {
            var point = new Point(characterLocation.Item1 * 50 + 10, characterLocation.Item2 * 50 + 10);
            var size = new Size(30, 30);
            var brush = new SolidBrush(Color.Green);
            var rectangle = new Rectangle(point, size);

            g.FillRectangle(brush, rectangle);
        }

        private void DrawRoom(Graphics g, Room r)
        {
            Room room = r;
            int xCoordinate = room.Coordinates.Item1;
            int yCoordinate = room.Coordinates.Item2;

            if (((xCoordinate >= 0) && (xCoordinate <= 5)) && ((yCoordinate >= 0) && (yCoordinate <= 6)))
            {
                var wallPen = new Pen(Color.Black, 1);
                var doorPen = new Pen(Color.White, 1);

                if (room.HasNorthernWall)
                    g.DrawLine(wallPen, xCoordinate * 50, yCoordinate * 50, xCoordinate * 50 + 49, yCoordinate * 50);
                else if (!room.HasNorthernWall)
                    g.DrawLine(doorPen, xCoordinate * 50 + 1, yCoordinate * 50, xCoordinate * 50 + 49, yCoordinate * 50);                

                if (room.HasEasternWall)
                    g.DrawLine(wallPen, xCoordinate * 50 + 49, yCoordinate * 50, xCoordinate * 50 + 49, yCoordinate * 50 + 49);
                else if (!room.HasEasternWall)
                    g.DrawLine(doorPen, xCoordinate * 50 + 49, yCoordinate * 50 + 1, xCoordinate * 50 + 49, yCoordinate * 50 + 49);       

                if (room.HasSouthernWall)
                    g.DrawLine(wallPen, xCoordinate * 50, yCoordinate * 50 + 49, xCoordinate * 50 + 49, yCoordinate * 50 + 49);
                else if (!room.HasSouthernWall)
                    g.DrawLine(doorPen, xCoordinate * 50 + 1, yCoordinate * 50 + 49, xCoordinate * 50 + 48, yCoordinate * 50 + 49);                

                if (room.HasWesternWall)
                    g.DrawLine(wallPen, xCoordinate * 50, yCoordinate * 50, xCoordinate * 50, yCoordinate * 50 + 49);
                else if (!room.HasWesternWall)
                    g.DrawLine(doorPen, xCoordinate * 50, yCoordinate * 50 + 1, xCoordinate * 50, yCoordinate * 50 + 48);                
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
            frmNewGame frm = new frmNewGame();
            frm.ShowDialog();

            if (frm.StartGameIsSuccessful)
            {
                var name = frm.PlayerName;
                Dungeon dungeon = frm.selectedDungeon;

                Player player = new Player(name, 1, 100, 100, 0);
                dungeon.Rooms.Where(r => r.IsStartingLocation).FirstOrDefault<Room>().Beings.Add(player);

                PopulateCharacterInfo(player);

                Globals.Player = player;
                Globals.Dungeon = dungeon;
                Globals.GameStarted = true;

                pnlDungeon.Invalidate();
            }
        }

        private void PopulateCharacterInfo(Player player)
        {
            txtCharacterName.Text = player.Name;
            txtCharacterLevel.Text = $"{player.Level.ToString()} / 60";
            prgCharacterHP.Maximum = player.MaximumHP;
            prgCharacterHP.Value = player.CurrentHP;
            txtCharacterCurrentLocation.Text = $"{player.CurrentLocation.Coordinates.Item1.ToString()}, {player.CurrentLocation.Coordinates.Item2.ToString()}";
        }

        private void UpdateMonsterStats(Monster monster)
        {
            txtMonsterID.Text = monster.ID.ToString();
            txtMonsterName.Text = monster.Name;
            txtMonsterLevel.Text = $"{monster.Level.ToString()} / 60";
            prgMonsterHP.Maximum = monster.MaximumHP;
            prgMonsterHP.Value = monster.CurrentHP;
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            Globals.Player.MoveNorth();
            PopulateCharacterInfo(Globals.Player);
            pnlDungeon.Invalidate();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            Globals.Player.MoveEast();
            PopulateCharacterInfo(Globals.Player);
            pnlDungeon.Invalidate();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            Globals.Player.MoveSouth();
            PopulateCharacterInfo(Globals.Player);
            pnlDungeon.Invalidate();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            Globals.Player.MoveWest();
            PopulateCharacterInfo(Globals.Player);
            pnlDungeon.Invalidate();
        }

        private void roomSearched(Room room)
        {

        }

        private void roomPartiallySearched(Room room)
        {

        }

        private void btnLookAroundRoom_Click(object sender, EventArgs e)
        {
            lstAvailableTargets.Items.Clear();
            txtChatWindow.AppendText("You see: ");

            foreach (DataRow target in Globals.Player.LookAroundRoom().Rows)
            {
                txtChatWindow.AppendText($"{target.}\r\n");
                lstAvailableTargets.Items.Add($"{target.Name}\r\n");
            }
        }

        public void ClearMonsterStats()
        {
            txtMonsterID.Clear();
            txtMonsterName.Clear();
            txtMonsterLevel.Clear();
            prgMonsterHP.Value = 0;
        }

        private void btnAttackTarget_Click(object sender, EventArgs e)
        {
            //PlayerAttacksMonster(Globals.Player.Target);
        }

        private void PlayerAttacksMonster(Monster monster)
        {
            //var damage = 10;

            //if (damage <= monster.CurrentHP)
            //{
            //    monster.CurrentHP -= 10;
            //    UpdateMonsterStats(monster);
            //    txtChatWindow.AppendText($"You hit {monster.Name} for 10 damage!\r\n");

            //    if (IsDead(monster))
            //    {
            //        MonsterDie(Globals.Dungeon.DungeonLayout[Globals.Player.CurrentLocation], monster);
            //        ClearMonsterStats();
            //    }
            //    else
            //        MonsterAttacksPlayer(Globals.Player);
            //}
            //else if (monster.CurrentHP > 0 && monster.CurrentHP < damage)
            //{
            //    monster.CurrentHP = 0;
            //    MonsterDie(Globals.Dungeon.DungeonLayout[Globals.Player.CurrentLocation], monster);
            //    ClearMonsterStats();
            //}
            
        }

        private void MonsterAttacksPlayer(Player player)
        {
            //var damage = 10;

            //if (damage <= player.CurrentHP)
            //{
            //    player.CurrentHP -= 10;
            //    PopulateCharacterInfo(player);
            //    txtChatWindow.AppendText($"{player.Target.Name} hit you for 10 damage!\r\n");

            //    if (IsDead(player))
            //    {
            //        GameOver();
            //    }
            //}
            //else if (player.CurrentHP > 0 && player.CurrentHP < damage)
            //{
            //    player.CurrentHP = 0;
            //    GameOver();
            //}
        }

        private bool IsDead(Monster monster)
        {
            if (monster.CurrentHP == 0)
                return true;

            return false;
        }

        private bool IsDead(Player player)
        {
            //if (player.CurrentHP == 0)
            //    return true;

            return false;
        }

        private void GameOver()
        {
            Globals.Dungeon = null;
            //Globals.Player = null;
            Globals.GameStarted = false;

            pnlDungeon.Invalidate();
            ClearPlayerStats();
            ClearMonsterStats();
        }

        private void ClearPlayerStats()
        {
            txtCharacterName.Clear();
            txtCharacterLevel.Clear();
            txtCharacterCurrentLocation.Clear();
            prgCharacterHP.Value = 0;
        }

        private void lstAvailableTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Monster monster = Globals.Player.TargetMonster((ListBox) sender);

            //UpdateMonsterStats(monster);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}