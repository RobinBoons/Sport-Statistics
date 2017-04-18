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
            Player player = new Player("Dummy1", 32, new Basketball(1,1,1,1,1,1,1,1,1,1,1,1,1,1,1));
            administratie.AddPlayer(player);
            player = new Player("Dummy2", 4, new Handball(1,1,1,1,1,1,1));
            administratie.AddPlayer(player);
            player = new Player("Dummy3", 99, new Basketball(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1));
            administratie.AddPlayer(player);
            player = new Player("Dummy4", 12, new Handball(1, 1, 1, 1, 1, 1, 1));
            administratie.AddPlayer(player);
            player = new Player("Dummy5", 6, new Basketball(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1));
            administratie.AddPlayer(player);
            Team team = new Team("Team1", "Club A", new Handball(1, 1, 1, 1, 1, 1, 1));
            administratie.AddTeam(team);
            team = new Team("Team2", "Club B", new Basketball(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1));
            administratie.AddTeam(team);
            team = new Team("Team3", "Club C", new Handball(1, 1, 1, 1, 1, 1, 1));
            administratie.AddTeam(team);
            team = new Team("Team4", "Club D", new Basketball(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1));
            administratie.AddTeam(team);
            team = new Team("Team5", "Club E", new Handball(1, 1, 1, 1, 1, 1, 1));
            administratie.AddTeam(team);
            foreach (Player players in administratie.Players)
            {
                lbPlayers.Items.Add(players);
            }
            foreach (Team teams in administratie.Teams)
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
            catch (IOException exception)
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
                if (file.Contains(".team"))
                {
                    lbTeams.Items.Clear();
                    foreach (Team teams in administratie.Teams)
                    {
                        lbTeams.Items.Add(teams);
                    }
                }
                else if (file.Contains(".plyr"))
                {
                    lbPlayers.Items.Clear();
                    foreach (Player players in administratie.Players)
                    {
                        lbPlayers.Items.Add(players);
                    }
                }
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message);
            }
            //TODO andere excepties afvangen
        }

        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            if (tbNewTeamName.Text != "" || tbNewTeamClub.Text != "")
            {
                Team team = new Team(tbNewTeamName.Text, tbNewTeamClub.Text, (Sport)cbSport.SelectedItem);
                if (administratie.AddTeam(team))
                {
                    MessageBox.Show("Team: " + team.ToString() + " Is Succesvol Toegevoegd");
                    lbTeams.Items.Clear();
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
            if (lbTeams.SelectedItem != null)
            {
                if (administratie.RemoveTeam((Team)lbTeams.SelectedItem))
                {
                    MessageBox.Show("Team Succesvol Verwijderd");
                    lbTeams.Items.Clear();
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
            if (tbNewPlayerName.Text != "" || nUDAddPlayer.Value >= 0)
            {
                Player player = new Player(tbNewPlayerName.Text, (int)nUDAddPlayer.Value, (Sport)cbSport.SelectedItem);
                if (administratie.AddPlayer(player))
                {
                    MessageBox.Show("Speler: " + player.ToString() + " Is Succesvol Toegevoegd");
                    lbPlayers.Items.Clear();
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
                    lbPlayers.Items.Clear();
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

        private void btnAssignToTeam_Click(object sender, EventArgs e)
        {
            Player player = (Player)lbPlayers.SelectedItem;
            Team team = (Team)lbTeams.SelectedItem;
            if (player != null || team != null)
            {
                if (administratie.AddPlayerToTeam(team, player))
                {
                    MessageBox.Show(player.ToString() + " Is succesvol aan " + team.ToString());
                }
                else
                {
                    MessageBox.Show(player.ToString() + " Is niet tegevoegd aan " + team.ToString());
                }
            }
        }

        private void btnRemoveFromTeam_Click(object sender, EventArgs e)
        {
            Player player = (Player)lbPlayers.SelectedItem;
            Team team = (Team)lbTeams.SelectedItem;
            if (player != null || team != null)
            {
                if (administratie.RemovePlayerFromTeam(team, player))
                {
                    MessageBox.Show(player.ToString() + " Is succesvol verwijderd uit " + team.ToString());
                }
                else
                {
                    MessageBox.Show(player.ToString() + " Is niet verwijderd uit " + team.ToString());
                }
            }
        }

        private void lbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTeamSpelers.Items.Clear();
            Team team = (Team)lbTeams.SelectedItem;
            if (team != null)
            {
                foreach (Player player in team.TeamPlayers)
                {
                    lbTeamSpelers.Items.Add(player);
                }
            }
        }

        private void lbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = (Player)lbPlayers.SelectedItem;
            if (player != null)
            {
                lblGoals.Text = player.Sport.Score.ToString();
                lbPercentage.Text = player.Sport.ScorePercentage.ToString();
                lbShotsOnTarget.Text = player.Sport.Attempts.ToString();
            }
        }
    }
}
