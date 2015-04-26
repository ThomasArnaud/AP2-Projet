using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_AP2
{
    public delegate void GameFinishedEventHandler(object Sender, GameFinishedEventArgs e);

    public delegate void TurnBegunEventHandler(object Sender, TurnBegunEventArgs e);

    public delegate void TurnFinishedEventHandler(object Sender, TurnFinishedEventArgs e);

    public class StupidVulture
    {
        public event GameFinishedEventHandler GameFinishedEvent;

        public event TurnBegunEventHandler TurnBegunEvent;

        public event TurnFinishedEventHandler TurnFinishedEvent;

        /// <summary>
        /// Represents the list of currently playing players.
        /// </summary>
        protected List<Player> players;

        /// <summary>
        /// Gets the list of currently playing players.
        /// </summary>
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

        /// <summary>
        /// Gets the card on top of the deck if there are still cards left, otherwise returns 0.
        /// </summary>
        public SByte CardOnTop
        {
            get
            {
                return this.deck.Count > 0 ? this.deck.Peek() : (SByte) 0;
            }
        }

        /// <summary>
        /// Creates a new game of Stupid Vulture.
        /// </summary>
        /// <param name="players">List of players for the game.</param>
        public StupidVulture(List<Player> players)
        {
            this.players = players;

            // Create the deck of cards
            List<SByte> cards = new List<SByte>();
            
            for(SByte i = -5; i <= 10; i++)
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
                this.deck.Push(c);
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
                pairsList.Add(new Pair<Player, Byte>(this.players[i], this.players[i].Play(this.deck.Peek())));
                this.players[i].Cards.Remove(pairsList[i].Second);
            }

            // Fire beginning of the turn event
            this.turnBegun(new TurnBegunEventArgs(pairsList));

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
                    pairsList[highestIndex].First.Score += this.deck.Peek();

                    // Fire the end of turn event
                    this.turnFinished(new TurnFinishedEventArgs(pairsList[highestIndex].First, this.deck.Pop(), pairsList[highestIndex].Second, pairsListCopy));
                }
                else
                {
                    // Search the lowest card
                    Byte lowestIndex = 0;

                    for (Byte i = 1; i < pairsList.Count; i++)
                        if (pairsList[i].Second < pairsList[lowestIndex].Second)
                            lowestIndex = i;

                    // And add the vulture card to the player
                    pairsList[lowestIndex].First.Score += this.deck.Peek();

                    // Fire the end of turn event
                    this.turnFinished(new TurnFinishedEventArgs(pairsList[lowestIndex].First, this.deck.Pop(), pairsList[lowestIndex].Second, pairsListCopy));
                }
            }
            else
            {
                // Nobody can win the card so just ignore it and fire the end of turn event
                this.turnFinished(new TurnFinishedEventArgs(null, this.deck.Pop(), 0, pairsListCopy));
            }

            // Is the game over?
            if(this.deck.Count == 0)
            {
                // Build the list of winners
                List<Player> winnersList = new List<Player>();
                winnersList.Add(this.players[0]);
                SByte highestScore = this.players[0].Score;

                for(Byte i = 1; i < this.players.Count; i++)
                {
                    if(this.players[i].Score > highestScore)
                    {
                        winnersList.Clear();
                        winnersList.Add(this.players[i]);
                        highestScore = this.players[i].Score;
                    }
                    else if(this.players[i].Score == highestScore)
                    {
                        winnersList.Add(this.players[i]);
                    }
                }

                // Fire the end of game event
                this.gamefinished(new GameFinishedEventArgs(winnersList, highestScore));
            }
        }

        protected void gamefinished(GameFinishedEventArgs a)
        {
            if(this.GameFinishedEvent != null)
                this.GameFinishedEvent(this, a);
        }

        protected void turnBegun(TurnBegunEventArgs a)
        {
            if(this.TurnBegunEvent != null)
                this.TurnBegunEvent(this, a);
        }

        protected void turnFinished(TurnFinishedEventArgs a)
        {
            if(this.TurnFinishedEvent != null)
                this.TurnFinishedEvent(this, a);
        }
    }
}
