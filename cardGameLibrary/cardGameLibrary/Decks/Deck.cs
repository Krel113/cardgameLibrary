using cardGameLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameLibrary.Decks
{
    public class Deck
    {
        public static int deckNumber { get; set; }

        protected const int NORMAL_AMOUNT_OF_SUITS = 4;
        public List<Card> deck = new List<Card>();

        public static List<Card> mainDeck = new List<Card>();

        public Deck()
        {
            deckNumber++;
        }

        protected void AddCardsToDeck(List<Card> pCards)
        {
            int lIteration = pCards.Count;

            for (int i = 0; i < lIteration; i++)
            {
                deck.Add(pCards[i]);
            }
        }
    }
}


