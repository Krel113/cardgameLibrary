using cardGameLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameLibrary.Suits
{
    public class SuitWithNormalValues : Suit
    {
        public SuitWithNormalValues(GameInfo.Suits pSuit, int pAmountOfCard = 13): base(pSuit, pAmountOfCard)
        {
            cards = Card.NormalValues(suit, amountOfCards);
        }
    }
}
