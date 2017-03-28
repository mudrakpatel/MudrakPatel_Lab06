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
    }
}
