namespace Sport_Statistics
{
	partial class SportStatisticsForm
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
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.lbTeamSpelers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.tbNewTeamClub = new System.Windows.Forms.TextBox();
            this.btnAddNewTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewTeamName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSport = new System.Windows.Forms.Label();
            this.cbSport = new System.Windows.Forms.ComboBox();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.lbShotsOnTarget = new System.Windows.Forms.Label();
            this.lblGoals = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nUDAddPlayer = new System.Windows.Forms.NumericUpDown();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.btnRemoveFromTeam = new System.Windows.Forms.Button();
            this.tbNewPlayerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAssignToTeam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.btnMakeGame = new System.Windows.Forms.Button();
            this.lbGame = new System.Windows.Forms.ListBox();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.lbGames = new System.Windows.Forms.ListBox();
            this.btnRemoveGame = new System.Windows.Forms.Button();
            this.lbGameLog = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearNewGame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAddPlayer)).BeginInit();
            this.gbGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 16;
            this.lbTeams.Location = new System.Drawing.Point(5, 21);
            this.lbTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(279, 84);
            this.lbTeams.TabIndex = 0;
            this.lbTeams.SelectedIndexChanged += new System.EventHandler(this.lbTeams_SelectedIndexChanged);
            // 
            // lbTeamSpelers
            // 
            this.lbTeamSpelers.FormattingEnabled = true;
            this.lbTeamSpelers.ItemHeight = 16;
            this.lbTeamSpelers.Location = new System.Drawing.Point(5, 128);
            this.lbTeamSpelers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTeamSpelers.Name = "lbTeamSpelers";
            this.lbTeamSpelers.Size = new System.Drawing.Size(279, 180);
            this.lbTeamSpelers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveTeam);
            this.groupBox1.Controls.Add(this.btnMakeGame);
            this.groupBox1.Controls.Add(this.tbNewTeamClub);
            this.groupBox1.Controls.Add(this.btnAddNewTeam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNewTeamName);
            this.groupBox1.Controls.Add(this.lbTeams);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbTeamSpelers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(291, 464);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teams";
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Location = new System.Drawing.Point(79, 433);
            this.btnRemoveTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(100, 27);
            this.btnRemoveTeam.TabIndex = 10;
            this.btnRemoveTeam.Text = "Verwijder";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            this.btnRemoveTeam.Click += new System.EventHandler(this.btnRemoveTeam_Click);
            // 
            // tbNewTeamClub
            // 
            this.tbNewTeamClub.Location = new System.Drawing.Point(185, 405);
            this.tbNewTeamClub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewTeamClub.Name = "tbNewTeamClub";
            this.tbNewTeamClub.Size = new System.Drawing.Size(100, 22);
            this.tbNewTeamClub.TabIndex = 14;
            // 
            // btnAddNewTeam
            // 
            this.btnAddNewTeam.Location = new System.Drawing.Point(185, 433);
            this.btnAddNewTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewTeam.Name = "btnAddNewTeam";
            this.btnAddNewTeam.Size = new System.Drawing.Size(100, 27);
            this.btnAddNewTeam.TabIndex = 13;
            this.btnAddNewTeam.Text = "Voeg Toe";
            this.btnAddNewTeam.UseVisualStyleBackColor = true;
            this.btnAddNewTeam.Click += new System.EventHandler(this.btnAddNewTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spelers In Het Team";
            // 
            // tbNewTeamName
            // 
            this.tbNewTeamName.Location = new System.Drawing.Point(185, 377);
            this.tbNewTeamName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewTeamName.Name = "tbNewTeamName";
            this.tbNewTeamName.Size = new System.Drawing.Size(100, 22);
            this.tbNewTeamName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Club:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Naam:";
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 16;
            this.lbPlayers.Location = new System.Drawing.Point(5, 21);
            this.lbPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(279, 228);
            this.lbPlayers.TabIndex = 3;
            this.lbPlayers.SelectedIndexChanged += new System.EventHandler(this.lbPlayers_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSport);
            this.groupBox2.Controls.Add(this.cbSport);
            this.groupBox2.Controls.Add(this.lbPercentage);
            this.groupBox2.Controls.Add(this.lbShotsOnTarget);
            this.groupBox2.Controls.Add(this.lblGoals);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nUDAddPlayer);
            this.groupBox2.Controls.Add(this.btnRemovePlayer);
            this.groupBox2.Controls.Add(this.btnAddNewPlayer);
            this.groupBox2.Controls.Add(this.btnRemoveFromTeam);
            this.groupBox2.Controls.Add(this.tbNewPlayerName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAssignToTeam);
            this.groupBox2.Controls.Add(this.lbPlayers);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(309, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(444, 464);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spelers";
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(6, 370);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(46, 17);
            this.lblSport.TabIndex = 20;
            this.lblSport.Text = "Sport:";
            // 
            // cbSport
            // 
            this.cbSport.FormattingEnabled = true;
            this.cbSport.Items.AddRange(new object[] {
            "Basketball",
            "Handball"});
            this.cbSport.Location = new System.Drawing.Point(185, 370);
            this.cbSport.Margin = new System.Windows.Forms.Padding(4);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(101, 24);
            this.cbSport.TabIndex = 19;
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Location = new System.Drawing.Point(425, 57);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(0, 17);
            this.lbPercentage.TabIndex = 16;
            // 
            // lbShotsOnTarget
            // 
            this.lbShotsOnTarget.AutoSize = true;
            this.lbShotsOnTarget.Location = new System.Drawing.Point(425, 39);
            this.lbShotsOnTarget.Name = "lbShotsOnTarget";
            this.lbShotsOnTarget.Size = new System.Drawing.Size(0, 17);
            this.lbShotsOnTarget.TabIndex = 15;
            // 
            // lblGoals
            // 
            this.lblGoals.AutoSize = true;
            this.lblGoals.Location = new System.Drawing.Point(425, 22);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(0, 17);
            this.lblGoals.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Schoten op doel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Goals:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Goal Percentage:";
            // 
            // nUDAddPlayer
            // 
            this.nUDAddPlayer.Location = new System.Drawing.Point(185, 342);
            this.nUDAddPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUDAddPlayer.Name = "nUDAddPlayer";
            this.nUDAddPlayer.Size = new System.Drawing.Size(100, 22);
            this.nUDAddPlayer.TabIndex = 10;
            this.nUDAddPlayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(9, 422);
            this.btnRemovePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(100, 27);
            this.btnRemovePlayer.TabIndex = 9;
            this.btnRemovePlayer.Text = "Verwijder";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Location = new System.Drawing.Point(186, 422);
            this.btnAddNewPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(100, 27);
            this.btnAddNewPlayer.TabIndex = 8;
            this.btnAddNewPlayer.Text = "Voeg Toe";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAddNewPlayer_Click);
            // 
            // btnRemoveFromTeam
            // 
            this.btnRemoveFromTeam.Location = new System.Drawing.Point(147, 262);
            this.btnRemoveFromTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFromTeam.Name = "btnRemoveFromTeam";
            this.btnRemoveFromTeam.Size = new System.Drawing.Size(139, 46);
            this.btnRemoveFromTeam.TabIndex = 5;
            this.btnRemoveFromTeam.Text = "Verwijder Uit Team";
            this.btnRemoveFromTeam.UseVisualStyleBackColor = true;
            this.btnRemoveFromTeam.Click += new System.EventHandler(this.btnRemoveFromTeam_Click);
            // 
            // tbNewPlayerName
            // 
            this.tbNewPlayerName.Location = new System.Drawing.Point(185, 314);
            this.tbNewPlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewPlayerName.Name = "tbNewPlayerName";
            this.tbNewPlayerName.Size = new System.Drawing.Size(100, 22);
            this.tbNewPlayerName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nummer:";
            // 
            // btnAssignToTeam
            // 
            this.btnAssignToTeam.Location = new System.Drawing.Point(5, 262);
            this.btnAssignToTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssignToTeam.Name = "btnAssignToTeam";
            this.btnAssignToTeam.Size = new System.Drawing.Size(135, 46);
            this.btnAssignToTeam.TabIndex = 4;
            this.btnAssignToTeam.Text = "Voeg Toe Aan Team";
            this.btnAssignToTeam.UseVisualStyleBackColor = true;
            this.btnAssignToTeam.Click += new System.EventHandler(this.btnAssignToTeam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naam:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(8, 219);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(192, 47);
            this.btnDownLoad.TabIndex = 5;
            this.btnDownLoad.Text = "Download Data From Server";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // btnMakeGame
            // 
            this.btnMakeGame.Location = new System.Drawing.Point(5, 313);
            this.btnMakeGame.Name = "btnMakeGame";
            this.btnMakeGame.Size = new System.Drawing.Size(279, 33);
            this.btnMakeGame.TabIndex = 6;
            this.btnMakeGame.Text = "Voeg Team Toe Aan Nieuwe Wedstrijd";
            this.btnMakeGame.UseVisualStyleBackColor = true;
            this.btnMakeGame.Click += new System.EventHandler(this.btnMakeGame_Click);
            // 
            // lbGame
            // 
            this.lbGame.FormattingEnabled = true;
            this.lbGame.ItemHeight = 16;
            this.lbGame.Location = new System.Drawing.Point(8, 335);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(192, 36);
            this.lbGame.TabIndex = 7;
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.btnClearNewGame);
            this.gbGame.Controls.Add(this.label9);
            this.gbGame.Controls.Add(this.btnDownLoad);
            this.gbGame.Controls.Add(this.lbGameLog);
            this.gbGame.Controls.Add(this.lbGame);
            this.gbGame.Controls.Add(this.btnAddGame);
            this.gbGame.Controls.Add(this.lbGames);
            this.gbGame.Controls.Add(this.btnRemoveGame);
            this.gbGame.Location = new System.Drawing.Point(771, 12);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(415, 464);
            this.gbGame.TabIndex = 8;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Wedstrijd";
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(8, 377);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(192, 38);
            this.btnAddGame.TabIndex = 8;
            this.btnAddGame.Text = "Voeg Wedstrijd Toe";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // lbGames
            // 
            this.lbGames.FormattingEnabled = true;
            this.lbGames.ItemHeight = 16;
            this.lbGames.Location = new System.Drawing.Point(8, 21);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(192, 148);
            this.lbGames.TabIndex = 9;
            this.lbGames.SelectedIndexChanged += new System.EventHandler(this.lbGames_SelectedIndexChanged);
            // 
            // btnRemoveGame
            // 
            this.btnRemoveGame.Location = new System.Drawing.Point(8, 175);
            this.btnRemoveGame.Name = "btnRemoveGame";
            this.btnRemoveGame.Size = new System.Drawing.Size(192, 38);
            this.btnRemoveGame.TabIndex = 10;
            this.btnRemoveGame.Text = "Verwijder Wedstrijd";
            this.btnRemoveGame.UseVisualStyleBackColor = true;
            this.btnRemoveGame.Click += new System.EventHandler(this.btnRemoveGame_Click);
            // 
            // lbGameLog
            // 
            this.lbGameLog.FormattingEnabled = true;
            this.lbGameLog.ItemHeight = 16;
            this.lbGameLog.Location = new System.Drawing.Point(206, 21);
            this.lbGameLog.Name = "lbGameLog";
            this.lbGameLog.Size = new System.Drawing.Size(192, 148);
            this.lbGameLog.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nieuwe Wedstrijd:";
            // 
            // btnClearNewGame
            // 
            this.btnClearNewGame.Location = new System.Drawing.Point(8, 416);
            this.btnClearNewGame.Name = "btnClearNewGame";
            this.btnClearNewGame.Size = new System.Drawing.Size(192, 38);
            this.btnClearNewGame.TabIndex = 13;
            this.btnClearNewGame.Text = "Clear";
            this.btnClearNewGame.UseVisualStyleBackColor = true;
            this.btnClearNewGame.Click += new System.EventHandler(this.btnClearNewGame_Click);
            // 
            // SportStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 495);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SportStatisticsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SportStatisticsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAddPlayer)).EndInit();
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.ListBox lbTeamSpelers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.Button btnRemoveFromTeam;
        private System.Windows.Forms.TextBox tbNewPlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAssignToTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.TextBox tbNewTeamClub;
        private System.Windows.Forms.Button btnAddNewTeam;
        private System.Windows.Forms.TextBox tbNewTeamName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown nUDAddPlayer;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.Label lbShotsOnTarget;
        private System.Windows.Forms.Label lblGoals;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.ComboBox cbSport;
        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.Button btnMakeGame;
        private System.Windows.Forms.ListBox lbGame;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbGameLog;
        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.Button btnRemoveGame;
        private System.Windows.Forms.Button btnClearNewGame;
    }
}

