using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        private List<Card> Cards { get; set; }

        public Deck()
        {
            this.Cards = new List<Card>();
            MakeDeck();
            Shuffle();
        }
        public Card Draw()
        {
            var card = this.Cards.First();
            this.Cards.Remove(card);
            return card;
        }

        private void MakeDeck()
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 13; j++)
                {
                    this.Cards.Add(new Card
                    {
                        Number = j,
                        Suit = SetSuit(i),
                        Point = SetPoint(j),
                        ViewNumber = SetViewNumber(j),
                    });
                }
            }
        }
        private string SetSuit(int num)
        {
            switch (num)
            {
                case 1:
                    return "Spade";
                case 2:
                    return "Hart";
                case 3:
                    return "Club";
                case 4:
                    return "Diamond";
            }
            return "";
        }
        private int SetPoint(int num)
        {
            if (num >= 11)
                return 10;
            else
                return num;
        }
        private string SetViewNumber(int num)
        {
            switch (num)
            {
                case 11:
                    return "j";
                case 12:
                    return "Q";
                case 13:
                    return "K";
            }
            return num.ToString();
        }
        private void Shuffle()
        {
            Random r = new Random();
            this.Cards = this.Cards.OrderBy(x => r.Next(this.Cards.Count())).ToList();
        }
    }
}
