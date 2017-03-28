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

namespace MudrakPatel_Lab06_Ex2
{
    public partial class DisplayPlayersEx2 : Form
    {
        public DisplayPlayersEx2()
        {
            InitializeComponent();
        }

        private BaseballEntities dbcontext = new BaseballEntities();

        private void DisplayPlayersEx2_Load(object sender, EventArgs e)
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Temporary variables to hold
            //min and max batting average values
            var minValue = 0.000m;
            var maxValue = 1.000m;

            try
            {

                if (minValue < 0.000m) { minValue = 0.000m; }
                else { minValue = Convert.ToDecimal(minValueTextBox.Text); }

                if (maxValue > 1.000m) { maxValue = 1.000m; }
                else { maxValue = Convert.ToDecimal(maxValueTextBox.Text); }

                var selectedPlayer = from player in dbcontext.Players
                                     where (player.BattingAverage >= minValue
                                            && player.BattingAverage <= maxValue)
                                     select player;

                var details = "";
                foreach (var player in selectedPlayer)
                {
                    details = details + "<<" + player.PlayerID + ">> " 
                                      + "<<" + player.FirstName + ">> "
                                      + "<<" + player.LastName + ">> "
                                      + "<<" + player.BattingAverage + ">> "
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
                                + Environment.NewLine + "OR" + "Check the batting average you entered."
                                + Environment.NewLine + exception.Message, "Exception or input error!");
            }
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
    }
}
