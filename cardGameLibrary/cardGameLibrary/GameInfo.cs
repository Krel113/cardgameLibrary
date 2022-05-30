using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameLibrary
{
    public static class GameInfo
    {
        public enum CardsValues
        {
            Normal,
            Inversed,
            Custom
        }

        public enum Suits
        {
            Hearts,
            Spike,
            Diamond,
            Club
        }
        public enum CardName
        {
            Ace,
            King,
            Queen,
            Jack,
            Ten,
            Nine,
            Height,
            Seven,
            Six,
            Five,
            Four,
            Three,
            Two
        }
    }
}
