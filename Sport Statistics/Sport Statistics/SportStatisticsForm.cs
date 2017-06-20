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
using System.Windows.Forms.DataVisualization.Charting;

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

       /* private void btnSafeToFile_Click(object sender, EventArgs e)
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
        }*/

       /* private void btnLoadFromFile_Click(object sender, EventArgs e)
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
        } */

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
            if (tbNewPlayerName.Text != "" || nUDAddPlayer.Value >= 0 || cbSport.ToString() != "")
            {
                try
                {
                    Sport sport = null;
                    if(cbSport.Text == "Handball")
                    {
                        sport = new Handball(0, 0, 0, 0, 0, 0, 0);
                    }
                    else if(cbSport.Text == "Basketball")
                    {
                        sport = new Basketball(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    }
                    Player player = new Player(tbNewPlayerName.Text, (int)nUDAddPlayer.Value, sport);//TODO onmogelijk cast
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
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
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
            chart1.Series.Clear();
            Player player = (Player)lbPlayers.SelectedItem;
            if (player != null)
            {
                lblGoals.Text = player.Sport.Score.ToString();
                lbPercentage.Text = player.Sport.ScorePercentage.ToString();
                lbShotsOnTarget.Text = player.Sport.Attempts.ToString();
                var series = new Series("Heart Beat");
                series.ChartType = SeriesChartType.Line;
                // Frist parameter is X-Axis and Second is Collection of Y- Axis
                foreach (pointI point in player.HeartBeat)
                {
                    series.Points.DataBindXY(new[] { 2001, 2002, 2003, 2004 }, new[] { 100, 200, 90, 150 });
                    //series.Points.DataBindXY(player.HeartBeat, );
                }
                chart1.Series.Add(series);

                
            }
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            //string SiteAddress = "http://192.168.43.167/";
            //System.Net.WebClient wc = new System.Net.WebClient();
            //string webData = wc.DownloadString(SiteAddress);
            //string[] splitedData = webData.Split('>');
            //string[] outputData = splitedData[2].Split('<');
            string siteString = "1,0,1/1,0,1/1,0,1"; //outputData[0]; //TODO realdata
            Game game = (Game)lbGames.SelectedItem;
            if (game != null)
            {
                Game foundGame = administratie.FindGame(game);
                administratie.TextToData(siteString, foundGame);
            }
        }

        private void btnMakeGame_Click(object sender, EventArgs e)
        {
            if (lbGame.Items.Count > 2)
            {
                lbGame.Items.Clear();
            }
            if (lbTeams.SelectedItem != null)
            {
                Team team = (Team)lbTeams.SelectedItem;
                team = administratie.FindTeam(team.Name);
                lbGame.Items.Add(team);
            }
            
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            if (lbGame.Items.Count == 2)
            {
                Team home = (Team)lbGame.Items[0];
                Team away = (Team)lbGame.Items[1];
                if (home.TeamPlayers.Count < 1 || away.TeamPlayers.Count < 1)
                {
                    MessageBox.Show("Een Team Moet Spelers Hebben!");
                }
                else
                {
                    if (home != away)
                    {
                        Game game = new Game(home, away);
                        administratie.Games.Add(game);
                        lbGames.Items.Add(game);
                        lbGame.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Een team kan niet tegen zichzelf spelen!");
                        lbGame.Items.Clear();
                    }
                }
            }
        }

        private void lbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game game = (Game)lbGames.SelectedItem;
            if(game != null)
            {
                lbGameLog.Items.Clear();
                Game foundGame = administratie.FindGame(game);
                foreach(string Event in foundGame.GameLog)
                {
                    lbGameLog.Items.Add(Event);
                }
                if(lbGameLog.Items.Count == 0)
                {
                    lbGameLog.Items.Add("No Data Yet");
                }
            }
        }

        private void btnRemoveGame_Click(object sender, EventArgs e)
        {
            Game game = (Game)lbGames.SelectedItem;
            if (game != null)
            {
                lbGameLog.Items.Clear();
                Game foundGame = administratie.FindGame(game);
                administratie.Games.Remove(foundGame);
            }
        }

        private void btnClearNewGame_Click(object sender, EventArgs e)
        {
            lbGame.Items.Clear();
        }
    }
}
