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

        protected PointF[,] location;

        protected List<Button> buttonsList;

        /// <summary>
        /// Creates a new main window.
        /// </summary>
        public Window()
        {
            InitializeComponent();

            // Build the list of card buttons to make it easier to use
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

            // Build a matrix of points representing where to draw the opponents' card
            this.location = new PointF[4,5];

            location[0, 0] = new PointF(369, 353);
            location[1, 0] = new PointF(369, 353);
            location[2, 0] = new PointF(369, 353);
            location[3, 0] = new PointF(369, 353);

            location[0, 1] = new PointF(369, 44);
            location[1, 1] = new PointF(258, 62);
            location[2, 1] = new PointF(158, 148);
            location[3, 1] = new PointF(78, 226);

            location[0, 2] = new PointF(-1, -1);
            location[1, 2] = new PointF(478, 62);
            location[2, 2] = new PointF(369, 44);
            location[3, 2] = new PointF(258, 62);

            location[0, 3] = new PointF(-1, -1);
            location[1, 3] = new PointF(-1, -1);
            location[2, 3] = new PointF(578, 148);
            location[3, 3] = new PointF(478, 62);

            location[0, 4] = new PointF(-1, -1);
            location[1, 4] = new PointF(-1, -1);
            location[2, 4] = new PointF(-1, -1);
            location[3, 4] = new PointF(658, 226);
        }

        /// <summary>
        /// Called when the user clicks on the "New game", or uses the shortcut.
        /// </summary>
        /// <param name="sender">Reference to the "New game" menu item.</param>
        /// <param name="e">Reference to the arguments of the event.</param>
        private void stupidVultureToolStripMenuItem_Click(object sender, EventArgs e)
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
                            playersList.Add(new EasyComputer((Byte) i, "Ordinateur " + i, colorsArray[i - 1]));
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
                this.stupidVulture.GameFinishedEvent += new GameFinishedEventHandler(this.OnGameFinished);
                this.stupidVulture.TurnBegunEvent += new TurnBegunEventHandler(this.OnTurnBegun);
                this.stupidVulture.TurnFinishedEvent += new TurnFinishedEventHandler(this.OnTurnEnded);

                // Initialize the interface
                this.playerNameLabel.Text = d.PlayerName;
                this.scoreLabel.Text = "0";

                // Launch the game
                this.OnGameBegun();
            }
        }

        /// <summary>
        /// Called when the user clicks on the "Exit" menu item, or uses the shortcut.
        /// </summary>
        /// <param name="sender">Reference to the "Exit" menu item.</param>
        /// <param name="e">Reference to the arguments of the event.</param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Called when the user clicks on a card button.
        /// </summary>
        /// <param name="sender">Reference to the button on which the user clicked.</param>
        /// <param name="e">Reference to the arguments of the event.</param>
        private void CardButton_Click(object sender, EventArgs e)
        {
            // Determine which button was clicked
            Button cardButton = (Button)sender;
            cardButton.Visible = false;

            // Then, play the associated card
            this.stupidVulture.Play((Byte) (this.buttonsList.IndexOf(cardButton) + 1));

            // Update the user's score
            this.scoreLabel.Text = this.stupidVulture.Players[0].Score.ToString();
        }

        /// <summary>
        /// Draws the board of the game.
        /// </summary>
        /// <param name="cardsList">Reference to the list of players and cards.</param>
        /// <param name="deckCard">Value of the card on top of the deck.</param>
        protected void drawBoard(List<Pair<Player, Byte>> cardsList, SByte deckCard)
        {
            // Initialize the drawing components
            Bitmap boardImage = new Bitmap(this.pictureBox.Size.Width, this.pictureBox.Size.Height);
            Graphics graphics = Graphics.FromImage(boardImage);
            Pen pen = new Pen(Color.Black, 1.0F);
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Initialize the image
            this.pictureBox.Image = boardImage;
            graphics.Clear(Color.Transparent);

            // Draw the deck if needed
            if(deckCard != 0)
            {
                graphics.DrawRectangle(pen, 308.0F, 190.0F, 50.0F, 100.0F);
                graphics.DrawString(deckCard.ToString(), font, brush, new PointF(330, 235));
                graphics.DrawRectangle(pen, 428.0F, 190.0F, 50.0F, 100.0F);
            }

            // Draw the players' card if needed
            if(cardsList != null)
            {

            }

            // Dispose of the drawing components
            pen.Dispose();
            graphics.Dispose();
        }

        /// <summary>
        /// Called when the game has begun.
        /// </summary>
        protected void OnGameBegun()
        {
            // Draw the board with only the deck
            this.drawBoard(null, this.stupidVulture.CardOnTop);

            // Activate every card button
            for(Byte i = 0; i < this.buttonsList.Count; i++)
            {
                this.buttonsList[i].Enabled = true;
                this.buttonsList[i].Visible = true;
            }
        }

        /// <summary>
        /// Called when the game is finished.
        /// </summary>
        /// <param name="sender">Reference to the Stupid Vulture game.</param>
        /// <param name="a">Reference to the arguments of the events</param>
        protected void OnGameFinished(object sender, GameFinishedEventArgs a)
        {
            // Clear the board
            this.drawBoard(null, 0);

            if(!a.IsDraw)
            {
                if(a.Winners.Contains(this.stupidVulture.Players[0]))
                    MessageBox.Show("Vous avez gagné !", "Victoire", MessageBoxButtons.OK);
                else
                    MessageBox.Show(a.Winners[0].Name + " a gagné !", "Défaite", MessageBoxButtons.OK);
            }
            else
            {
                // Build the list of winners
                String playersList = "";

                for (Byte i = 0; i < a.Winners.Count; i++)
                    playersList += a.Winners[i].Name + (i != a.Winners.Count - 2 ? ", " : " et ");
                playersList.Substring(0, playersList.Length - 2);

                // Then, inform the user
                MessageBox.Show("Il y a eu égalité entre " + playersList + ".", "Egalité avec " + (a.Winners.Contains(this.stupidVulture.Players[0]) ? "victoire" : "défaite"), MessageBoxButtons.OK);
            }

            // Deactivate every card button
            for (Byte i = 0; i < this.buttonsList.Count; i++)
            {
                this.buttonsList[i].Enabled = false;
            }
        }

        /// <summary>
        /// Called when a turn has begun.
        /// </summary>
        /// <param name="sender">Reference to the Stupid Vulture game.</param>
        /// <param name="a">Reference to the arguments of the event.</param>
        protected void OnTurnBegun(object sender, TurnBegunEventArgs a)
        {
            this.drawBoard(a.Cards, this.stupidVulture.CardOnTop);
        }

        /// <summary>
        /// Called when a turn is finished.
        /// </summary>
        /// <param name="sender">Reference to the Stupid Vulture game</param>
        /// <param name="a">Reference to the arguments of the event.</param>
        protected void OnTurnEnded(object sender, TurnFinishedEventArgs a)
        {
            this.drawBoard(null, this.stupidVulture.CardOnTop);

            // Activate every card button
            for (Byte i = 0; i < this.buttonsList.Count; i++)
            {
                this.buttonsList[i].Enabled = true;
            }
        }
    }
}
