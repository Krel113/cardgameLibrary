using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cardGameLibrary.Cards;
using cardGameLibrary.Suits;

namespace cardGameLibrary.Decks
{
    public class NormalDeck: Deck
    {

        public NormalDeck(int pAmountOfDecks, GameInfo.CardsValues pOrderValues) : base()
        {
            GameInfo.Suits lSuitName;
            Suit lSuitInstance;
            List<Card> cards;

            for (int i = 0; i < pAmountOfDecks; i++)
            {
                for (int j = 0; j < NORMAL_AMOUNT_OF_SUITS; j++)
                {
                    lSuitName = (GameInfo.Suits)j;
                    lSuitInstance = pOrderValues == GameInfo.CardsValues.Normal ? new SuitWithNormalValues(lSuitName) : new SuitWithInversedValues(lSuitName);
                    cards = lSuitInstance.GetCards();

                    AddCardsToDeck(cards);
                }             
            }     
        }
    }
}
