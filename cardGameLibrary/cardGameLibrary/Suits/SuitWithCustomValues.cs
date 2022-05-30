using cardGameLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameLibrary.Suits
{
    public class SuitWithCustomValues : Suit
    {
        public SuitWithCustomValues(GameInfo.Suits pSuit, GameInfo.CardName[] pNames, int[] pValues, int pAmountOfCard = 13): base(pSuit, pAmountOfCard)
        {
            cards = Card.CustomsValues(suit, amountOfCards, pNames, pValues);
        }
    }
}
