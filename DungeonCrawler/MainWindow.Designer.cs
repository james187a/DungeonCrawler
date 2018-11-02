namespace DungeonCrawler
{
    partial class FrmMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMovementControls = new System.Windows.Forms.GroupBox();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.grpCharacter = new System.Windows.Forms.GroupBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblCharacterLevel = new System.Windows.Forms.Label();
            this.lblCharacterHP = new System.Windows.Forms.Label();
            this.txtCharacterCurrentLocation = new System.Windows.Forms.TextBox();
            this.lblCharacterCurrentLocation = new System.Windows.Forms.Label();
            this.prgCharacterHP = new System.Windows.Forms.ProgressBar();
            this.txtCharacterLevel = new System.Windows.Forms.TextBox();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.grpMonster = new System.Windows.Forms.GroupBox();
            this.lblMonsterHP = new System.Windows.Forms.Label();
            this.lblMonsterLevel = new System.Windows.Forms.Label();
            this.lblMonsterName = new System.Windows.Forms.Label();
            this.lblMonsterID = new System.Windows.Forms.Label();
            this.prgMonsterHP = new System.Windows.Forms.ProgressBar();
            this.txtMonsterLevel = new System.Windows.Forms.TextBox();
            this.txtMonsterName = new System.Windows.Forms.TextBox();
            this.txtMonsterID = new System.Windows.Forms.TextBox();
            this.grpCharacterStats = new System.Windows.Forms.GroupBox();
            this.grpAvailableTargets = new System.Windows.Forms.GroupBox();
            this.lstAvailableTargets = new System.Windows.Forms.ListBox();
            this.grpChatWindow = new System.Windows.Forms.GroupBox();
            this.txtChatWindow = new System.Windows.Forms.TextBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnAttackTarget = new System.Windows.Forms.Button();
            this.btnLookAroundRoom = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pnlDungeon = new System.Windows.Forms.Panel();
            this.grpMovementControls.SuspendLayout();
            this.grpCharacter.SuspendLayout();
            this.grpMonster.SuspendLayout();
            this.grpAvailableTargets.SuspendLayout();
            this.grpChatWindow.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMovementControls
            // 
            this.grpMovementControls.Controls.Add(this.btnSouth);
            this.grpMovementControls.Controls.Add(this.btnWest);
            this.grpMovementControls.Controls.Add(this.btnEast);
            this.grpMovementControls.Controls.Add(this.btnNorth);
            this.grpMovementControls.Location = new System.Drawing.Point(472, 368);
            this.grpMovementControls.Name = "grpMovementControls";
            this.grpMovementControls.Size = new System.Drawing.Size(300, 181);
            this.grpMovementControls.TabIndex = 1;
            this.grpMovementControls.TabStop = false;
            this.grpMovementControls.Text = "Movement Controls";
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(124, 125);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(50, 50);
            this.btnSouth.TabIndex = 3;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.BtnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(71, 72);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(50, 50);
            this.btnWest.TabIndex = 2;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.BtnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(177, 72);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(50, 50);
            this.btnEast.TabIndex = 1;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.BtnEast_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(124, 19);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(50, 50);
            this.btnNorth.TabIndex = 0;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.BtnNorth_Click);
            // 
            // grpCharacter
            // 
            this.grpCharacter.Controls.Add(this.lblCharacterName);
            this.grpCharacter.Controls.Add(this.lblCharacterLevel);
            this.grpCharacter.Controls.Add(this.lblCharacterHP);
            this.grpCharacter.Controls.Add(this.txtCharacterCurrentLocation);
            this.grpCharacter.Controls.Add(this.lblCharacterCurrentLocation);
            this.grpCharacter.Controls.Add(this.prgCharacterHP);
            this.grpCharacter.Controls.Add(this.txtCharacterLevel);
            this.grpCharacter.Controls.Add(this.txtCharacterName);
            this.grpCharacter.Location = new System.Drawing.Point(242, 12);
            this.grpCharacter.Name = "grpCharacter";
            this.grpCharacter.Size = new System.Drawing.Size(224, 172);
            this.grpCharacter.TabIndex = 2;
            this.grpCharacter.TabStop = false;
            this.grpCharacter.Text = "Character";
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(18, 22);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(38, 13);
            this.lblCharacterName.TabIndex = 2;
            this.lblCharacterName.Text = "Name:";
            this.lblCharacterName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCharacterLevel
            // 
            this.lblCharacterLevel.AutoSize = true;
            this.lblCharacterLevel.Location = new System.Drawing.Point(20, 49);
            this.lblCharacterLevel.Name = "lblCharacterLevel";
            this.lblCharacterLevel.Size = new System.Drawing.Size(36, 13);
            this.lblCharacterLevel.TabIndex = 1;
            this.lblCharacterLevel.Text = "Level:";
            this.lblCharacterLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCharacterHP
            // 
            this.lblCharacterHP.AutoSize = true;
            this.lblCharacterHP.Location = new System.Drawing.Point(31, 78);
            this.lblCharacterHP.Name = "lblCharacterHP";
            this.lblCharacterHP.Size = new System.Drawing.Size(25, 13);
            this.lblCharacterHP.TabIndex = 3;
            this.lblCharacterHP.Text = "HP:";
            this.lblCharacterHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCharacterCurrentLocation
            // 
            this.txtCharacterCurrentLocation.Location = new System.Drawing.Point(62, 103);
            this.txtCharacterCurrentLocation.Name = "txtCharacterCurrentLocation";
            this.txtCharacterCurrentLocation.ReadOnly = true;
            this.txtCharacterCurrentLocation.Size = new System.Drawing.Size(156, 20);
            this.txtCharacterCurrentLocation.TabIndex = 9;
            // 
            // lblCharacterCurrentLocation
            // 
            this.lblCharacterCurrentLocation.AutoSize = true;
            this.lblCharacterCurrentLocation.Location = new System.Drawing.Point(6, 106);
            this.lblCharacterCurrentLocation.Name = "lblCharacterCurrentLocation";
            this.lblCharacterCurrentLocation.Size = new System.Drawing.Size(51, 13);
            this.lblCharacterCurrentLocation.TabIndex = 4;
            this.lblCharacterCurrentLocation.Text = "Location:";
            this.lblCharacterCurrentLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prgCharacterHP
            // 
            this.prgCharacterHP.Location = new System.Drawing.Point(62, 73);
            this.prgCharacterHP.Name = "prgCharacterHP";
            this.prgCharacterHP.Size = new System.Drawing.Size(156, 23);
            this.prgCharacterHP.TabIndex = 8;
            // 
            // txtCharacterLevel
            // 
            this.txtCharacterLevel.Location = new System.Drawing.Point(62, 46);
            this.txtCharacterLevel.Name = "txtCharacterLevel";
            this.txtCharacterLevel.ReadOnly = true;
            this.txtCharacterLevel.Size = new System.Drawing.Size(156, 20);
            this.txtCharacterLevel.TabIndex = 7;
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(62, 19);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.ReadOnly = true;
            this.txtCharacterName.Size = new System.Drawing.Size(156, 20);
            this.txtCharacterName.TabIndex = 6;
            // 
            // grpMonster
            // 
            this.grpMonster.Controls.Add(this.lblMonsterHP);
            this.grpMonster.Controls.Add(this.lblMonsterLevel);
            this.grpMonster.Controls.Add(this.lblMonsterName);
            this.grpMonster.Controls.Add(this.lblMonsterID);
            this.grpMonster.Controls.Add(this.prgMonsterHP);
            this.grpMonster.Controls.Add(this.txtMonsterLevel);
            this.grpMonster.Controls.Add(this.txtMonsterName);
            this.grpMonster.Controls.Add(this.txtMonsterID);
            this.grpMonster.Location = new System.Drawing.Point(242, 190);
            this.grpMonster.Name = "grpMonster";
            this.grpMonster.Size = new System.Drawing.Size(224, 172);
            this.grpMonster.TabIndex = 3;
            this.grpMonster.TabStop = false;
            this.grpMonster.Text = "Monster";
            // 
            // lblMonsterHP
            // 
            this.lblMonsterHP.AutoSize = true;
            this.lblMonsterHP.Location = new System.Drawing.Point(31, 102);
            this.lblMonsterHP.Name = "lblMonsterHP";
            this.lblMonsterHP.Size = new System.Drawing.Size(25, 13);
            this.lblMonsterHP.TabIndex = 0;
            this.lblMonsterHP.Text = "HP:";
            this.lblMonsterHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonsterLevel
            // 
            this.lblMonsterLevel.AutoSize = true;
            this.lblMonsterLevel.Location = new System.Drawing.Point(20, 74);
            this.lblMonsterLevel.Name = "lblMonsterLevel";
            this.lblMonsterLevel.Size = new System.Drawing.Size(36, 13);
            this.lblMonsterLevel.TabIndex = 0;
            this.lblMonsterLevel.Text = "Level:";
            this.lblMonsterLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonsterName
            // 
            this.lblMonsterName.AutoSize = true;
            this.lblMonsterName.Location = new System.Drawing.Point(18, 48);
            this.lblMonsterName.Name = "lblMonsterName";
            this.lblMonsterName.Size = new System.Drawing.Size(38, 13);
            this.lblMonsterName.TabIndex = 0;
            this.lblMonsterName.Text = "Name:";
            this.lblMonsterName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonsterID
            // 
            this.lblMonsterID.AutoSize = true;
            this.lblMonsterID.Location = new System.Drawing.Point(35, 22);
            this.lblMonsterID.Name = "lblMonsterID";
            this.lblMonsterID.Size = new System.Drawing.Size(21, 13);
            this.lblMonsterID.TabIndex = 0;
            this.lblMonsterID.Text = "ID:";
            this.lblMonsterID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prgMonsterHP
            // 
            this.prgMonsterHP.Location = new System.Drawing.Point(62, 97);
            this.prgMonsterHP.Name = "prgMonsterHP";
            this.prgMonsterHP.Size = new System.Drawing.Size(156, 23);
            this.prgMonsterHP.TabIndex = 2;
            // 
            // txtMonsterLevel
            // 
            this.txtMonsterLevel.Location = new System.Drawing.Point(62, 71);
            this.txtMonsterLevel.Name = "txtMonsterLevel";
            this.txtMonsterLevel.ReadOnly = true;
            this.txtMonsterLevel.Size = new System.Drawing.Size(156, 20);
            this.txtMonsterLevel.TabIndex = 1;
            // 
            // txtMonsterName
            // 
            this.txtMonsterName.Location = new System.Drawing.Point(62, 45);
            this.txtMonsterName.Name = "txtMonsterName";
            this.txtMonsterName.ReadOnly = true;
            this.txtMonsterName.Size = new System.Drawing.Size(156, 20);
            this.txtMonsterName.TabIndex = 1;
            // 
            // txtMonsterID
            // 
            this.txtMonsterID.Location = new System.Drawing.Point(62, 19);
            this.txtMonsterID.Name = "txtMonsterID";
            this.txtMonsterID.ReadOnly = true;
            this.txtMonsterID.Size = new System.Drawing.Size(156, 20);
            this.txtMonsterID.TabIndex = 1;
            // 
            // grpCharacterStats
            // 
            this.grpCharacterStats.Location = new System.Drawing.Point(12, 12);
            this.grpCharacterStats.Name = "grpCharacterStats";
            this.grpCharacterStats.Size = new System.Drawing.Size(224, 172);
            this.grpCharacterStats.TabIndex = 4;
            this.grpCharacterStats.TabStop = false;
            this.grpCharacterStats.Text = "Character Stats";
            // 
            // grpAvailableTargets
            // 
            this.grpAvailableTargets.Controls.Add(this.lstAvailableTargets);
            this.grpAvailableTargets.Location = new System.Drawing.Point(12, 190);
            this.grpAvailableTargets.Name = "grpAvailableTargets";
            this.grpAvailableTargets.Size = new System.Drawing.Size(224, 172);
            this.grpAvailableTargets.TabIndex = 5;
            this.grpAvailableTargets.TabStop = false;
            this.grpAvailableTargets.Text = "Available Targets";
            // 
            // lstAvailableTargets
            // 
            this.lstAvailableTargets.FormattingEnabled = true;
            this.lstAvailableTargets.Location = new System.Drawing.Point(6, 19);
            this.lstAvailableTargets.Name = "lstAvailableTargets";
            this.lstAvailableTargets.Size = new System.Drawing.Size(212, 147);
            this.lstAvailableTargets.TabIndex = 0;
            this.lstAvailableTargets.SelectedIndexChanged += new System.EventHandler(this.LstAvailableTargets_SelectedIndexChanged);
            // 
            // grpChatWindow
            // 
            this.grpChatWindow.Controls.Add(this.txtChatWindow);
            this.grpChatWindow.Location = new System.Drawing.Point(242, 368);
            this.grpChatWindow.Name = "grpChatWindow";
            this.grpChatWindow.Size = new System.Drawing.Size(224, 181);
            this.grpChatWindow.TabIndex = 6;
            this.grpChatWindow.TabStop = false;
            this.grpChatWindow.Text = "Chat Window";
            // 
            // txtChatWindow
            // 
            this.txtChatWindow.Location = new System.Drawing.Point(6, 19);
            this.txtChatWindow.Multiline = true;
            this.txtChatWindow.Name = "txtChatWindow";
            this.txtChatWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatWindow.Size = new System.Drawing.Size(212, 156);
            this.txtChatWindow.TabIndex = 0;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnAttackTarget);
            this.grpActions.Controls.Add(this.btnLookAroundRoom);
            this.grpActions.Controls.Add(this.btnNewGame);
            this.grpActions.Location = new System.Drawing.Point(12, 368);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(224, 181);
            this.grpActions.TabIndex = 7;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnAttackTarget
            // 
            this.btnAttackTarget.Location = new System.Drawing.Point(6, 78);
            this.btnAttackTarget.Name = "btnAttackTarget";
            this.btnAttackTarget.Size = new System.Drawing.Size(117, 23);
            this.btnAttackTarget.TabIndex = 4;
            this.btnAttackTarget.Text = "Attack Target";
            this.btnAttackTarget.UseVisualStyleBackColor = true;
            this.btnAttackTarget.Click += new System.EventHandler(this.BtnAttackTarget_Click);
            // 
            // btnLookAroundRoom
            // 
            this.btnLookAroundRoom.Location = new System.Drawing.Point(7, 49);
            this.btnLookAroundRoom.Name = "btnLookAroundRoom";
            this.btnLookAroundRoom.Size = new System.Drawing.Size(117, 23);
            this.btnLookAroundRoom.TabIndex = 2;
            this.btnLookAroundRoom.Text = "Look Around Room";
            this.btnLookAroundRoom.UseVisualStyleBackColor = true;
            this.btnLookAroundRoom.Click += new System.EventHandler(this.BtnLookAroundRoom_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(7, 19);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(117, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnCreateCharacter_Click);
            // 
            // pnlDungeon
            // 
            this.pnlDungeon.Location = new System.Drawing.Point(472, 12);
            this.pnlDungeon.Name = "pnlDungeon";
            this.pnlDungeon.Size = new System.Drawing.Size(300, 350);
            this.pnlDungeon.TabIndex = 8;
            this.pnlDungeon.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDungeon_Paint);
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlDungeon);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpChatWindow);
            this.Controls.Add(this.grpAvailableTargets);
            this.Controls.Add(this.grpCharacterStats);
            this.Controls.Add(this.grpMonster);
            this.Controls.Add(this.grpCharacter);
            this.Controls.Add(this.grpMovementControls);
            this.Name = "FrmMainWindow";
            this.Text = "Dungeon Crawler";
            this.Load += new System.EventHandler(this.FrmMainWindow_Load);
            this.grpMovementControls.ResumeLayout(false);
            this.grpCharacter.ResumeLayout(false);
            this.grpCharacter.PerformLayout();
            this.grpMonster.ResumeLayout(false);
            this.grpMonster.PerformLayout();
            this.grpAvailableTargets.ResumeLayout(false);
            this.grpChatWindow.ResumeLayout(false);
            this.grpChatWindow.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpMovementControls;
        private System.Windows.Forms.GroupBox grpCharacter;
        private System.Windows.Forms.GroupBox grpMonster;
        private System.Windows.Forms.GroupBox grpCharacterStats;
        private System.Windows.Forms.GroupBox grpAvailableTargets;
        private System.Windows.Forms.GroupBox grpChatWindow;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Panel pnlDungeon;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblCharacterCurrentLocation;
        private System.Windows.Forms.Label lblCharacterHP;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Label lblCharacterLevel;
        private System.Windows.Forms.TextBox txtCharacterCurrentLocation;
        private System.Windows.Forms.ProgressBar prgCharacterHP;
        private System.Windows.Forms.TextBox txtCharacterLevel;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.TextBox txtChatWindow;
        private System.Windows.Forms.Button btnLookAroundRoom;
        private System.Windows.Forms.Label lblMonsterLevel;
        private System.Windows.Forms.Label lblMonsterName;
        private System.Windows.Forms.Label lblMonsterID;
        private System.Windows.Forms.Label lblMonsterHP;
        private System.Windows.Forms.ProgressBar prgMonsterHP;
        private System.Windows.Forms.TextBox txtMonsterLevel;
        private System.Windows.Forms.TextBox txtMonsterName;
        private System.Windows.Forms.TextBox txtMonsterID;
        private System.Windows.Forms.Button btnAttackTarget;
        private System.Windows.Forms.ListBox lstAvailableTargets;
    }
}

