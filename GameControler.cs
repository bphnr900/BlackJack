using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class GameControler
    {
        private Deck Deck { get; set; }
        private Deeler Deeler { get; set; }
        private Player Player { get; set; }
        public GameControler()
        {
            this.Deck = new Deck();
            this.Deeler = new Deeler(this.Deck);
            this.Player = new Player(this.Deck);
        }
    }
}
