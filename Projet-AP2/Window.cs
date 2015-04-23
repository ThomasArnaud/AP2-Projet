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

        protected Bitmap boardImage;

        protected PointF[,] location;

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

            this.boardImage = new Bitmap(this.pictureBox.Size.Width, this.pictureBox.Size.Height);
            this.pictureBox.Image = this.boardImage;

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
                this.stupidVulture.drawingNeeded += new DrawingNeededEventHandler(this.DrawBoard);

                for(int i = 0; i < 15; i++)
                {
                    buttonsList[i].Visible = true;
                }

                // Initialize the interface
                this.playerNameLabel.Text = d.PlayerName;
                this.scoreLabel.Text = "0";
                this.DrawBoard(this, null);
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

        protected void DrawBoard(object Sender, DrawingNeededEventArgs e)
        {
            Graphics g = Graphics.FromImage(this.boardImage);
            Pen pen = new Pen(Color.Black, 1.0F);
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            g.Clear(new Color[]{Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Turquoise, Color.Tomato, Color.SteelBlue}[new Random().Next(7)]);

            g.DrawRectangle(pen, 308.0F, 190.0F, 50.0F, 100.0F);
            g.DrawString(this.stupidVulture.CardOnTop.ToString(), font, brush, new PointF(330, 235));
            g.DrawRectangle(pen, 428.0F, 190.0F, 50.0F, 100.0F);

            if(e != null)
            {
                for(byte i = 0; i < e.Cards.Count; i++)
                {
                    pen.Color = e.Cards[i].First.Color;
                    // g.DrawRectangle(pen, this.location[e.Cards.Count - 2, i]);
                }
            }

            pen.Dispose();
            g.Dispose();
        }
    }
}
