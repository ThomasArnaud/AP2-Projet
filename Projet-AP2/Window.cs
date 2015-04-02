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

        private void jeuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stupideVautourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame d = new NewGame();
            if(d.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                List<Player> playersList = new List<Player>();
                playersList.Add(new HumanPlayer(1, d.PlayerName, Color.Aquamarine));

                Color[] colorsarray = new Color[3]{Color.Red, Color.Purple, Color.Yellow};

                for(byte i = 1; i <= d.OpponentsNumber; i++)
                {
                    switch(d.GetOpponentDifficulty(i))
                    {
                        case 1:
                            playersList.Add(new EasyComputer(2, "Ordinateur "+i,colorsarray[i]));
                            break;

                        case 2:
                            playersList.Add(new MediumComputer(3, "Ordinateur " + i, colorsarray[i]));
                            break;

                        case 3:
                            playersList.Add(new HardComputer(3, "Ordinateur " + i, colorsarray[i]));
                            break;
                    }
                    
                        
                }
                StupidVulture stupidVulture = new StupidVulture(playersList);

                for(int i = 0; i < 15; i++)
                {
                    buttonsList[i].Visible = true;
                }
            }

        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            Button cardButton = (Button)sender;
            //Determiner le numéro de la carte  et appel à play à faire
            cardButton.Visible = false;
        }
    }
}
