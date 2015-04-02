using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    public class StupidVulture
    {
        /// <summary>
        /// Represents the list of currently playing players.
        /// </summary>
        protected List<Player> players;

        /// <summary>
        /// Represents the deck of card which are hidden.
        /// </summary>
        protected Stack<Card> deck;

        /// <summary>
        /// Creates a new game of Stupid Vulture.
        /// </summary>
        /// <param name="players">List of players for the game.</param>
        public StupidVulture(List<Player> players)
        {
            this.players = players;

            // Create the deck of cards
            List<Card> cards = new List<Card>();
            
            for(SByte i = -5; i <= 15; i++)
                if(i != 0)
                    cards.Add(new Card(i));

            // Shuffle 'em
            // http://stackoverflow.com/questions/1150646/card-shuffling-in-c-sharp#answer-1150699
            Random r = new Random();

            for(int i = cards.Count - 1; i > 0; i--)
            {
                int k = r.Next(i + 1);
                Card tmp = cards[i];
                cards[i] = cards[k];
                cards[k] = tmp;
            }

            // Then, put them in the stack
            this.deck = new Stack<Card>();
            foreach(Card c in cards)
            {
                this.deck.Push(c);
            }
        }
    }
}
