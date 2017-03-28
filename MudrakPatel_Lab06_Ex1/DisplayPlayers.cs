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

        private MudrakPatel_Lab06_ClassLibrary.BaseballEntities dbcontext = new MudrakPatel_Lab06_ClassLibrary.BaseballEntities();

        private void DisplayPlayers_Load(object sender, EventArgs e)
        {
            dbcontext.Players
                .OrderBy(player => player.FirstName)
                .ThenBy(player => player.LastName)
                .Load();

            playerBindingSource.DataSource = dbcontext.Players;
        }
    }
}
