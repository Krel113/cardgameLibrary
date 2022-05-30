using cardGameLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameLibrary.Suits
{
    public class Suit
    {
        protected GameInfo.Suits suit;
        protected int amountOfCards = 13;
        protected List<Card> cards = new List<Card>();

        public Suit(GameInfo.Suits pSuit, int pAmountOfCard = 13)
        {
            amountOfCards = pAmountOfCard;
            suit = pSuit;
        }

        public List<Card> GetCards()
        {
            return cards;
        }
    }
}
