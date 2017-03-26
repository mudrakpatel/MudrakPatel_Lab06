using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudrakPatel_Lab06_Ex1
{
    public partial class Form1 : Form
    {
        public BaseballDataSet db = new BaseballDataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseballDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.baseballDataSet.Players);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPlayer = from player in db.Players.AsEnumerable()
                                     where (player.FirstName.Equals(searchTextBox.Text)
                                            || player.LastName.Equals(searchTextBox.Text))
                                     select player;
                var details = "";
                foreach (var detail in selectedPlayer)
                {
                    details = details + "<<" + detail.PlayerID + ">> "
                                      + "<<" + detail.FirstName + ">> "
                                      + "<<" + detail.LastName + ">> "
                                      + "<<" + Convert.ToString(detail.BattingAverage) + ">> "
                                      + Environment.NewLine;
                }
                MessageBox.Show(details, "--Searched players--");
            }
            catch (FieldAccessException exception)
            {
                MessageBox.Show(exception.Message, "--Exception--");
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message, "--Exception--");
            }
            catch (IndexOutOfRangeException exception)
            {
                MessageBox.Show(exception.Message, "--Exception--");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "--Exception--");
            }
        }
    }
}
