namespace DungeonCrawler
{
    partial class frmNewGame
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
            this.lblEnterCharacterName = new System.Windows.Forms.Label();
            this.txtCreateCharacter = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnCancelName = new System.Windows.Forms.Button();
            this.cmbDungeonSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEnterCharacterName
            // 
            this.lblEnterCharacterName.AutoSize = true;
            this.lblEnterCharacterName.Location = new System.Drawing.Point(12, 9);
            this.lblEnterCharacterName.Name = "lblEnterCharacterName";
            this.lblEnterCharacterName.Size = new System.Drawing.Size(173, 13);
            this.lblEnterCharacterName.TabIndex = 0;
            this.lblEnterCharacterName.Text = "Enter in the name of your character";
            // 
            // txtCreateCharacter
            // 
            this.txtCreateCharacter.Location = new System.Drawing.Point(12, 25);
            this.txtCreateCharacter.Name = "txtCreateCharacter";
            this.txtCreateCharacter.Size = new System.Drawing.Size(260, 20);
            this.txtCreateCharacter.TabIndex = 1;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 155);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(127, 23);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "Begin!";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnAcceptName_Click);
            // 
            // btnCancelName
            // 
            this.btnCancelName.Location = new System.Drawing.Point(145, 155);
            this.btnCancelName.Name = "btnCancelName";
            this.btnCancelName.Size = new System.Drawing.Size(127, 23);
            this.btnCancelName.TabIndex = 3;
            this.btnCancelName.Text = "Cancel";
            this.btnCancelName.UseVisualStyleBackColor = true;
            this.btnCancelName.Click += new System.EventHandler(this.btnCancelName_Click);
            // 
            // cmbDungeonSelector
            // 
            this.cmbDungeonSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDungeonSelector.FormattingEnabled = true;
            this.cmbDungeonSelector.Location = new System.Drawing.Point(12, 52);
            this.cmbDungeonSelector.Name = "cmbDungeonSelector";
            this.cmbDungeonSelector.Size = new System.Drawing.Size(260, 21);
            this.cmbDungeonSelector.TabIndex = 4;
            // 
            // frmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.cmbDungeonSelector);
            this.Controls.Add(this.btnCancelName);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtCreateCharacter);
            this.Controls.Add(this.lblEnterCharacterName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewGame";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.frmCreateCharacter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterCharacterName;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnCancelName;
        private System.Windows.Forms.TextBox txtCreateCharacter;
        private System.Windows.Forms.ComboBox cmbDungeonSelector;
    }
}