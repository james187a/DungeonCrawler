using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static DungeonCrawler.FrmMainWindow;
using DungeonCrawler.Classes;

namespace DungeonCrawler
{
    public partial class FrmNewGame : Form
    {
        public string PlayerName { get; private set; }
        public bool StartGameIsSuccessful { get; private set; }
        public Dungeon SelectedDungeon { get; private set; }

        public FrmNewGame()
        {
            InitializeComponent();
        }

        private void frmCreateCharacter_Load(object sender, EventArgs e)
        {
            const string folderPath = @"Maps\";
            var table = new DataTable();

            table.Columns.Add("Dungeon Name", typeof(string));
            table.Columns.Add("Dungeon", typeof(Dungeon));

            foreach (var file in Directory.EnumerateFiles(folderPath, "*.json"))
            {
                using (var reader = new StreamReader(file))
                {
                    var json = reader.ReadToEnd();
                    var dungeon = JsonConvert.DeserializeObject<Dungeon>(json);
                    table.Rows.Add(dungeon.Name, dungeon);
                }
            }

            cmbDungeonSelector.DisplayMember = "Dungeon Name";
            cmbDungeonSelector.ValueMember = "Dungeon";
            cmbDungeonSelector.DataSource = table;
        }

        private void btnAcceptName_Click(object sender, EventArgs e)
        {
            PlayerName = txtCreateCharacter.Text;
            StartGameIsSuccessful = true;
            SelectedDungeon = (Dungeon)cmbDungeonSelector.SelectedValue;
            Close();
        }

        private void btnCancelName_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}