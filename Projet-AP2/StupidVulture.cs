using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP2
{
    public delegate void DrawingNeededEventHandler(object Sender, EventArgs e);
    public class StupidVulture
    {
        /// <summary>
        /// Represents the list of currently playing players.
        /// </summary>
        protected List<Player> players;

        public List<Player> Players
        {
            get
            {
                return this.players;
            }
        }

        /// <summary>
        /// Represents the deck of card which are hidden.
        /// </summary>
        protected Stack<SByte> deck;

        public event DrawingNeededEventHandler drawingNeeded;

        /// <summary>
        /// Creates a new game of Stupid Vulture.
        /// </summary>
        /// <param name="players">List of players for the game.</param>
        public StupidVulture(List<Player> players)
        {
            this.players = players;

            // Create the deck of cards
            List<SByte> cards = new List<SByte>();
            
            for(SByte i = -5; i <= 15; i++)
                if(i != 0)
                    cards.Add(i);

            // Shuffle 'em
            // http://stackoverflow.com/questions/1150646/card-shuffling-in-c-sharp#answer-1150699
            Random r = new Random();

            for(int i = cards.Count - 1; i > 0; i--)
            {
                int k = r.Next(i + 1);
                SByte tmp = cards[i];
                cards[i] = cards[k];
                cards[k] = tmp;
            }

            // Then, put them in the stack
            this.deck = new Stack<SByte>();

            foreach (SByte c in cards)
            {
                this.deck.Push(c);
            }

            // Draw the gameboard
            this.OnDrawingNeeded(EventArgs.Empty);
        }

        public void Play(Byte card)
        {
            // Create the list of pairs
            List<Pair<Player, Byte>> pairsList = new List<Pair<Player, Byte>>();

            // Associate the card with the human player and remove it from their deck
            pairsList.Add(new Pair<Player, Byte>(this.players[0], card));
            this.players[0].Cards.Remove(card);

            // Get the computers' card and remove it from their deck
            for(int i = 1; i < this.players.Count; i++)
            {
                pairsList.Add(new Pair<Player, Byte>(this.players[i], this.players[i].Play()));
                this.players[i].Cards.Remove(pairsList[i].Second);
            }

            // DEBUG
            foreach(Pair<Player, Byte> p in pairsList)
                Console.WriteLine("{0} played {1}.", p.First.Name, p.Second);
            // DEBUG

            // Then, compare them
            // 1.   Go through the list once to remove the ones which are equal
            // 2.1. Get the card with the most value representing the winner of the mouse card
            // 2.2. Get the card with the least value representing the winner of the vulture card
            List<Byte> usedCards = new List<Byte>();
            List<Pair<Player, Byte>> pairsListCopy = new List<Pair<Player, Byte>>(pairsList);

            foreach (Pair<Player, Byte> pair in pairsListCopy)
            {
                if(usedCards.Contains(pair.Second))
                {
                    pairsList.RemoveAll(x => x.Second == pair.Second);
                }
                else
                {
                    usedCards.Add(pair.Second);
                }
            }

            if(pairsList.Count > 0)
            {
                if(this.deck.Peek() > 0)
                {
                    // Search the highest card
                    Byte highestIndex = 0;

                    for(Byte i = 1; i < pairsList.Count; i++)
                        if(pairsList[i].Second > pairsList[highestIndex].Second)
                            highestIndex = i;
                    
                    // And add the mouse card to the player
                    // DEBUG
                    Console.WriteLine("-> {0} earned {1}.", pairsList[highestIndex].First.Name, this.deck.Peek());
                    // DEBUG
                    pairsList[highestIndex].First.Score += this.deck.Pop();
                }
                else
                {
                    // Search the lowest card
                    Byte lowestIndex = 0;

                    for (Byte i = 1; i < pairsList.Count; i++)
                        if (pairsList[i].Second < pairsList[lowestIndex].Second)
                            lowestIndex = i;

                    // And add the mouse card to the player
                    // DEBUG
                    Console.WriteLine("-> {0} earned {1}.", pairsList[lowestIndex].First.Name, this.deck.Peek());
                    // DEBUG
                    pairsList[lowestIndex].First.Score += this.deck.Pop();
                }
            }
            else
            {
                // Nobody can win the card so just ignore it
                // DEBUG
                Console.WriteLine("-> Nobody earned {0}.", this.deck.Peek());
                // DEBUG
                this.deck.Pop();
            }

            // Is the game over?
            if(this.deck.Count == 0)
            {
                Byte highestScoreIndex = 0;

                for(Byte i = 1; i < this.players.Count; i++)
                    if(this.players[highestScoreIndex].Score > this.players[i].Score)
                        highestScoreIndex = i;

                Boolean isDraw = this.players.FindAll(x => x.Score == this.players[highestScoreIndex].Score).Count > 1;

                if(this.players[0].Score == this.players[highestScoreIndex].Score && !isDraw)
                {
                    MessageBox.Show("Vous avez gagné !", "Victoire", MessageBoxButtons.OK);
                }
                else if(this.players[0].Score == this.players[highestScoreIndex].Score)
                {
                    MessageBox.Show("C'est une égalité parfaite !", "Match nul", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Perdu pauv' tocard !", "Défaite", MessageBoxButtons.OK);
                }
            }
        }

        protected void OnDrawingNeeded(EventArgs e)
        {
            if(this.drawingNeeded != null)
            {
                this.drawingNeeded(this, e);
            }
        }
    }
}
