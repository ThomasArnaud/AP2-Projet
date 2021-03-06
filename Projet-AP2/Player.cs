﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_AP2
{
    public abstract class Player
    {
        /// <summary>
        /// Represents the player's number.
        /// </summary>
        protected Byte number;

        /// <summary>
        /// Gets a player's number.
        /// </summary>
        public Byte Number
        {
            get
            {
                return this.number;
            }
        }

        /// <summary>
        /// Represents the player's name.
        /// </summary>
        protected String name;

        /// <summary>
        /// Gets a player's name.
        /// </summary>
        public String Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Represents the player's color.
        /// </summary>
        protected Color color;

        /// <summary>
        /// Gets a player's color.
        /// </summary>
        public Color Color
        {
            get
            {
                return this.color;
            }
        }

        /// <summary>
        /// Represents the player's cards.
        /// </summary>
        protected List<Byte> cards;

        /// <summary>
        /// Gets the list of the player's cards.
        /// </summary>
        public List<Byte> Cards
        {
            get
            {
                return this.cards;
            }
        }

        /// <summary>
        /// Represents the player's score.
        /// </summary>
        protected SByte score;

        /// <summary>
        /// Gets or sets the player's score.
        /// </summary>
        public SByte Score
        {
            get
            {
                return this.score;
            }

            set
            {
                this.score = value;
            }
        }

        /// <summary>
        /// Creates a new player.
        /// </summary>
        /// <param name="number">Player's number.</param>
        /// <param name="name">Player's name.</param>
        /// <param name="color">Player's color.</param>
        public Player(Byte number, String name, Color color)
        {
            this.number = number;
            this.name = name;
            this.color = color;
            this.cards = new List<Byte>();

            for (Byte i = 1; i <= 15; i++)
                this.cards.Add(i);
        }

        /// <summary>
        /// Asks a player for the card to play knowing the card on top of the deck.
        /// </summary>
        /// <param name="deckCard">Value of the card on the top of the deck.</param>
        /// <returns>Value of the card to play.</returns>
        public abstract Byte Play(SByte deckCard);
    }
}
