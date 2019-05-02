using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    abstract class User
    {
        protected List<Card> Hands { get; set; }
        protected Deck Deck { get; set; }
        public User(Deck deck)
        {
            this.Hands = new List<Card>();
            this.Deck = deck;
            MakeHands();
        }
        private Card Draw()
        {
            return this.Deck.Draw();
        }
        private void MakeHands()
        {
            for(int i = 1; i <= 2; i++)
            {
                Card card = Draw();
                this.Hands.Add(card);
            }
        }

        public abstract void ShowHands();
        public abstract void ShowPoint();
        
    }
}
