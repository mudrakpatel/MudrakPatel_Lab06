using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudrakPatel_Lab06_Ex1
{
    public partial class DisplayPlayers : Form
    {
        public DisplayPlayers()
        {
            InitializeComponent();
        }

        private BaseballEntities dbcontext = new BaseballEntities();

        private void DisplayPlayers_Load(object sender, EventArgs e)
        {
            //Load the data from dbcontext on the Load event
            dbcontext.Players
                .OrderBy(player => player.PlayerID)
                .ThenBy(player => player.FirstName)
                .ThenBy(player => player.LastName)
                .Load();
            //Provide DataSource to the playerBindingSource
            playerBindingSource.DataSource = dbcontext.Players.Local.ToBindingList();
        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Validate for unsaved changes
            Validate();
            //Save changes to the database
            dbcontext.SaveChangesAsync();
            //Refresh the playerDataGridView
            playerDataGridView.Refresh();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPlayer = from player in dbcontext.Players
                                     where player.LastName.Equals(searchTextBox.Text)
                                     select player;

                var details = "";
                foreach (var player in selectedPlayer)
                {
                    details = details + "<<" + player.FirstName + ">>"
                                      + "<<" + player.LastName + ">>"
                                      + "<<" + player.PlayerID + ">>"
                                      + Environment.NewLine;
                }
                MessageBox.Show(details, "--Searched Players--");
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Exception occured!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("The player you are looking for might not exist in the database."
                                + Environment.NewLine + "OR" + "Check that you entered the correct lastname."
                                + Environment.NewLine + exception.Message, "Exception or input error!");
            }
        }
    }
}
