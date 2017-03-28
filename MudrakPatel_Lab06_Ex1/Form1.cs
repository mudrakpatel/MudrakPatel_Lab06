using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BaseballDatabaseLibrary;

namespace MudrakPatel_Lab06_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BaseballEntities dbcontext = new BaseballEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                //load Players by PlayerID and then FirstName
                dbcontext.Players
                    .OrderBy(player => player.PlayerID)
                    .ThenBy(player => player.FirstName)
                    .Load();
                //specify DataSource for playerBindingSource
                playerBindingSource.DataSource = dbcontext.Players.Local;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occured in binding player data to playerBindingSource"
                                + Environment.NewLine + exception.Message
                                + exception.StackTrace, "Exception occured!");
            }
        }
    }
}
