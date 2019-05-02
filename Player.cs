using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player : User
    {
        public Player(Deck deck) : base(deck)
        {

        }

        public override void ShowHands()
        {
            string output = "";
            foreach (var card in this.Hands)
            {
                output += card.ViewNumber + " ";
            }
            Console.WriteLine("手持ちのカードは、{0}です。", output);
        }

        public override void ShowPoint()
        {
            int point = 0;
            foreach (var card in this.Hands)
            {
                point += card.Point;
            }
            Console.WriteLine("手持ちのポイントは、{0}です。", point);
        }
    }
}
