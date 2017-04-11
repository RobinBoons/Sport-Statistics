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
    }
}
