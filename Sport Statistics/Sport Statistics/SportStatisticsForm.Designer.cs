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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAssignToTeam = new System.Windows.Forms.Button();
            this.btnRemoveFromTeam = new System.Windows.Forms.Button();
            this.tbNewPlayerName = new System.Windows.Forms.TextBox();
            this.tbNewPlayerNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.btnAddNewTeam = new System.Windows.Forms.Button();
            this.tbNewTeamName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNewTeamClub = new System.Windows.Forms.TextBox();
            this.btnSafeToFile = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 16;
            this.lbTeams.Location = new System.Drawing.Point(6, 21);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(279, 84);
            this.lbTeams.TabIndex = 0;
            this.lbTeams.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbTeamSpelers
            // 
            this.lbTeamSpelers.FormattingEnabled = true;
            this.lbTeamSpelers.ItemHeight = 16;
            this.lbTeamSpelers.Location = new System.Drawing.Point(6, 128);
            this.lbTeamSpelers.Name = "lbTeamSpelers";
            this.lbTeamSpelers.Size = new System.Drawing.Size(279, 180);
            this.lbTeamSpelers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveTeam);
            this.groupBox1.Controls.Add(this.tbNewTeamClub);
            this.groupBox1.Controls.Add(this.btnAddNewTeam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNewTeamName);
            this.groupBox1.Controls.Add(this.lbTeams);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbTeamSpelers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 403);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teams";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spelers";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 228);
            this.listBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemovePlayer);
            this.groupBox2.Controls.Add(this.btnAddNewPlayer);
            this.groupBox2.Controls.Add(this.tbNewPlayerNumber);
            this.groupBox2.Controls.Add(this.btnRemoveFromTeam);
            this.groupBox2.Controls.Add(this.tbNewPlayerName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAssignToTeam);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(309, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 403);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spelers";
            // 
            // btnAssignToTeam
            // 
            this.btnAssignToTeam.Location = new System.Drawing.Point(6, 262);
            this.btnAssignToTeam.Name = "btnAssignToTeam";
            this.btnAssignToTeam.Size = new System.Drawing.Size(135, 46);
            this.btnAssignToTeam.TabIndex = 4;
            this.btnAssignToTeam.Text = "Voeg Toe Aan Team";
            this.btnAssignToTeam.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromTeam
            // 
            this.btnRemoveFromTeam.Location = new System.Drawing.Point(147, 262);
            this.btnRemoveFromTeam.Name = "btnRemoveFromTeam";
            this.btnRemoveFromTeam.Size = new System.Drawing.Size(138, 46);
            this.btnRemoveFromTeam.TabIndex = 5;
            this.btnRemoveFromTeam.Text = "Verwijder Uit Team";
            this.btnRemoveFromTeam.UseVisualStyleBackColor = true;
            // 
            // tbNewPlayerName
            // 
            this.tbNewPlayerName.Location = new System.Drawing.Point(185, 314);
            this.tbNewPlayerName.Name = "tbNewPlayerName";
            this.tbNewPlayerName.Size = new System.Drawing.Size(100, 22);
            this.tbNewPlayerName.TabIndex = 6;
            // 
            // tbNewPlayerNumber
            // 
            this.tbNewPlayerNumber.Location = new System.Drawing.Point(185, 342);
            this.tbNewPlayerNumber.Mask = "00";
            this.tbNewPlayerNumber.Name = "tbNewPlayerNumber";
            this.tbNewPlayerNumber.PromptChar = ' ';
            this.tbNewPlayerNumber.Size = new System.Drawing.Size(100, 22);
            this.tbNewPlayerNumber.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nummer:";
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Location = new System.Drawing.Point(185, 370);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(100, 27);
            this.btnAddNewPlayer.TabIndex = 8;
            this.btnAddNewPlayer.Text = "Voeg Toe";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            // 
            // btnAddNewTeam
            // 
            this.btnAddNewTeam.Location = new System.Drawing.Point(185, 370);
            this.btnAddNewTeam.Name = "btnAddNewTeam";
            this.btnAddNewTeam.Size = new System.Drawing.Size(100, 27);
            this.btnAddNewTeam.TabIndex = 13;
            this.btnAddNewTeam.Text = "Voeg Toe";
            this.btnAddNewTeam.UseVisualStyleBackColor = true;
            // 
            // tbNewTeamName
            // 
            this.tbNewTeamName.Location = new System.Drawing.Point(185, 314);
            this.tbNewTeamName.Name = "tbNewTeamName";
            this.tbNewTeamName.Size = new System.Drawing.Size(100, 22);
            this.tbNewTeamName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Club:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Naam:";
            // 
            // tbNewTeamClub
            // 
            this.tbNewTeamClub.Location = new System.Drawing.Point(185, 342);
            this.tbNewTeamClub.Name = "tbNewTeamClub";
            this.tbNewTeamClub.Size = new System.Drawing.Size(100, 22);
            this.tbNewTeamClub.TabIndex = 14;
            // 
            // btnSafeToFile
            // 
            this.btnSafeToFile.Location = new System.Drawing.Point(12, 421);
            this.btnSafeToFile.Name = "btnSafeToFile";
            this.btnSafeToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSafeToFile.TabIndex = 5;
            this.btnSafeToFile.Text = "Safe";
            this.btnSafeToFile.UseVisualStyleBackColor = true;
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(93, 421);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFromFile.TabIndex = 6;
            this.btnLoadFromFile.Text = "Load";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(79, 370);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(100, 27);
            this.btnRemovePlayer.TabIndex = 9;
            this.btnRemovePlayer.Text = "Verwijder";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Location = new System.Drawing.Point(79, 370);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(100, 27);
            this.btnRemoveTeam.TabIndex = 10;
            this.btnRemoveTeam.Text = "Verwijder";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            // 
            // SportStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 454);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnSafeToFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SportStatisticsForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.ListBox lbTeamSpelers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.MaskedTextBox tbNewPlayerNumber;
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
        private System.Windows.Forms.Button btnSafeToFile;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

