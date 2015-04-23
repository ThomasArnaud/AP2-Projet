using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP2
{
    public partial class Window : Form
    {
        protected StupidVulture stupidVulture;

        protected List<Button> buttonsList;
        public Window()
        {
            InitializeComponent();
            this.buttonsList = new List<Button>();
            buttonsList.Add(card1Button);
            buttonsList.Add(card2Button);
            buttonsList.Add(card3Button);
            buttonsList.Add(card4Button);
            buttonsList.Add(card5Button);
            buttonsList.Add(card6Button);
            buttonsList.Add(card7Button);
            buttonsList.Add(card8Button);
            buttonsList.Add(card9Button);
            buttonsList.Add(card10Button);
            buttonsList.Add(card11Button);
            buttonsList.Add(card12Button);
            buttonsList.Add(card13Button);
            buttonsList.Add(card14Button);
            buttonsList.Add(card15Button);

            for(int i = 0; i < 15; i++)
            {
                buttonsList[i].Visible = false;
            }
        }

        private void stupideVautourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame d = new NewGame();

            if(d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Create the players
                List<Player> playersList = new List<Player>();
                playersList.Add(new HumanPlayer(0, d.PlayerName, Color.Blue));

                Color[] colorsArray = new Color[4]{Color.Red, Color.Purple, Color.Yellow, Color.Green};

                for(byte i = 1; i <= d.OpponentsNumber; i++)
                {
                    switch(d.GetOpponentDifficulty(i))
                    {
                        case 1:
                            playersList.Add(new EasyComputer((Byte) i, "Ordinateur " + i, colorsArray[i-1]));
                            break;

                        case 2:
                            playersList.Add(new MediumComputer((Byte) i, "Ordinateur " + i, colorsArray[i - 1]));
                            break;

                        case 3:
                            playersList.Add(new HardComputer((Byte) i , "Ordinateur " + i, colorsArray[i - 1]));
                            break;
                    }
                }

                // Create the game
                this.stupidVulture = new StupidVulture(playersList);

                this.stupidVulture.drawingNeeded += new DrawingNeededEventHandler(DrawBoard);

                for(int i = 0; i < 15; i++)
                {
                    buttonsList[i].Visible = true;
                }

                // Initialize the interface
                this.playerNameLabel.Text = d.PlayerName;
                this.scoreLabel.Text = "0";
            }

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            // Determine which button was clicked
            Button cardButton = (Button)sender;
            cardButton.Visible = false;

            // Then, play the associated card
            this.stupidVulture.Play((Byte) (this.buttonsList.IndexOf(cardButton) + 1));
            this.scoreLabel.Text = this.stupidVulture.Players[0].Score.ToString();
        }

        protected void DrawBoard(object Sender, EventArgs e)
        {

        }
    }
}
