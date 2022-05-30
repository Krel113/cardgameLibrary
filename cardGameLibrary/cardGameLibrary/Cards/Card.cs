namespace cardGameLibrary.Cards
{
    public struct Card
    {
        public GameInfo.CardName name;
        public int value;
        public GameInfo.Suits suit;

        public Card(GameInfo.Suits pSuit, GameInfo.CardName pName, int pValue)
        {
            suit = pSuit;
            name = pName;
            value = pValue;
        }

        static public List<Card> NormalValues(GameInfo.Suits pSuit, int pCardsAmount)
        {
            Card newCard;
            List<Card> cards = new List<Card>();

            for (int i = 0; i < pCardsAmount; i++)
            {
                newCard = new Card(pSuit, (GameInfo.CardName)i, i);
                cards.Add(newCard);
            }

            return cards;
        }

        static public List<Card> InversedValues(GameInfo.Suits pSuit, int pCardsAmount)
        {
            Card newCard;
            List<Card> cards = new List<Card>();

            for (int i = 0; i < pCardsAmount; i++)
            {
                newCard = new Card(pSuit, (GameInfo.CardName)i, pCardsAmount - i);
                cards.Add(newCard);
            }

            return cards;
        }

        static public List<Card> CustomsValues(GameInfo.Suits pSuit, int pCardsAmount, GameInfo.CardName[] pNames, int[] pValues)
        {
            Card newCard;
            List<Card> cards = new List<Card>();

            for (int i = 0; i < pCardsAmount; i++)
            {
                newCard = new Card(pSuit, pNames[i], pValues[i]);
                cards.Add(newCard);
            }

            return cards;
        }
    }
}