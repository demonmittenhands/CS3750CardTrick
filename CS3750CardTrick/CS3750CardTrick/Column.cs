using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3750CardTrick
{
    class Column
    {

        public int id { get; set; }

        private  List<Card> cardList = new List<Card>();


        public void addCard(Card card)
        {
            cardList.Add(card);
        }

        public List<Card> getCardList()
        {
            return cardList;
        }
    }
}
