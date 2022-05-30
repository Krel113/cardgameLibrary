using cardGameLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameLibrary.Suits
{
    public class SuitWithInversedValues : Suit
    {
        public SuitWithInversedValues(GameInfo.Suits pSuit, int pAmountOfCard = 13): base(pSuit, pAmountOfCard)
        {
            cards = Card.InversedValues(suit, amountOfCards);
        }
    }
}
