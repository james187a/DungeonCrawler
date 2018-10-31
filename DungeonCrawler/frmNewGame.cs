using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static DungeonCrawler.frmMainWindow;

namespace DungeonCrawler
{
    public partial class frmNewGame : Form
    {
        public string PlayerName { get; set; }
        public bool StartGameIsSuccessful { get; set; } = false;
        public Dungeon selectedDungeon { get; set; }

        public frmNewGame()
        {
            InitializeComponent();
        }

        private void frmCreateCharacter_Load(object sender, EventArgs e)
        {
            var folderPath = @"C:\Users\james\Desktop\Dungeon Maps\";
            var table = new DataTable();

            table.Columns.Add("Dungeon Name", typeof(string));
            table.Columns.Add("Dungeon", typeof(Dungeon));

            foreach (var file in Directory.EnumerateFiles(folderPath, "*.json"))
            {
                using (var reader = new StreamReader(file))
                {
                    var json = reader.ReadToEnd();
                    Dungeon dungeon = JsonConvert.DeserializeObject<Dungeon>(json);
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
            selectedDungeon = (Dungeon)cmbDungeonSelector.SelectedValue;
            Close();
        }

        private void btnCancelName_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}