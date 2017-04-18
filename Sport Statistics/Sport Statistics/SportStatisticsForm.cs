using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sport_Statistics
{
	public partial class SportStatisticsForm : Form
	{
        Administration administratie;
        public SportStatisticsForm()
		{
			InitializeComponent();
		}

        private void SportStatisticsForm_Load(object sender, EventArgs e)
        {
            administratie = new Administration();
            //lbTeams.DataBindings.Add(administratie.Teams);
            lbTeams.DataSource = administratie.Teams;
            lbTeams.DisplayMember = "Name";
            Player player = new Player("Dummy1", 32);
            administratie.AddPlayer(player);
            player = new Player("Dummy2", 4);
            administratie.AddPlayer(player);
            player = new Player("Dummy3", 99);
            administratie.AddPlayer(player);
            player = new Player("Dummy4", 12);
            administratie.AddPlayer(player);
            player = new Player("Dummy5", 6);
            administratie.AddPlayer(player);
            Team team = new Team("Team1", "Club A");
            administratie.AddTeam(team);
            team = new Team("Team2", "Club B");
            administratie.AddTeam(team);
            team = new Team("Team3", "Club C");
            administratie.AddTeam(team);
            team = new Team("Team4", "Club D");
            administratie.AddTeam(team);
            team = new Team("Team5", "Club E");
            administratie.AddTeam(team);
            lbTeams.Refresh();
            foreach(Player players in administratie.Players)
            {
                lbPlayers.Items.Add(players);
            }
            foreach(Team teams in administratie.Teams)
            {
                lbTeams.Items.Add(teams);
            }
        }

        private void btnSafeToFile_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
                string file = saveFileDialog1.FileName;
                administratie.SafeToFile(file);
            }
            catch(IOException exception)
            {
                MessageBox.Show(exception.Message);
            }
            //TODO andere excepties afvangen
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string file = openFileDialog1.FileName;
                administratie.LoadFromFile(file);
            }
            catch(IOException exception)
            {
                MessageBox.Show(exception.Message);
            }
            //TODO andere excepties afvangen
        }

        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            if(tbNewTeamName.Text != "" || tbNewTeamClub.Text != "")
            {
                Team team = new Team(tbNewTeamName.Text, tbNewTeamClub.Text);
                if (administratie.AddTeam(team))
                {
                    MessageBox.Show("Team: " + team.ToString() + " Is Succesvol Toegevoegd");
                    foreach (Team teams in administratie.Teams)
                    {
                        lbTeams.Items.Add(teams);
                    }
                }
                else
                {
                    MessageBox.Show("Team: " + team.ToString() + " Is Niet Toegevoegd");
                }
            }
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            if(lbTeams.SelectedItem != null)
            {
                if (administratie.RemoveTeam((Team)lbTeams.SelectedItem))
                {
                    MessageBox.Show("Team Succesvol Verwijderd");
                    foreach (Team teams in administratie.Teams)
                    {
                        lbTeams.Items.Add(teams);
                    }
                }
                else
                {
                    MessageBox.Show("Team Niet Verwijderd");
                }
            }
        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            if (tbNewTeamName.Text != "" || tbNewTeamClub.Text != "")
            {
                Player player = new Player(tbNewPlayerName.Text, (int)nUDAddPlayer.Value);
                if (administratie.AddPlayer(player))
                {
                    MessageBox.Show("Speler: " + player.ToString() + " Is Succesvol Toegevoegd");
                    foreach (Player players in administratie.Players)
                    {
                        lbPlayers.Items.Add(players);
                    }
                }
                else
                {
                    MessageBox.Show("Speler: " + player.ToString() + " Is Niet Toegevoegd");
                }
            }
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (lbPlayers.SelectedItem != null)
            {
                if (administratie.RemovePlayer((Player)lbPlayers.SelectedItem))
                {
                    MessageBox.Show("Speler Succesvol Verwijderd");
                    foreach (Player players in administratie.Players)
                    {
                        lbPlayers.Items.Add(players);
                    }
                }
                else
                {
                    MessageBox.Show("Speler Niet Verwijderd");
                }
            }
        }
    }
}
