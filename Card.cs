using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public string type { get; }
        public int weight { get; }

        public Card(string typeOfCard, int weightOfCard)
        {
            type = typeOfCard;
            weight = weightOfCard;
        }
    }
}
