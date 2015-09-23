using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3750CardTrick
{
    class Column
    {
        private int id;

        private List<Card> cardList = new List<Card>();

        public Column(int id)
        {
            this.id = id;
        }

        public void clearList()
        {
            cardList.Clear();
        }

        public int getId()
        {
            return id;
        }

        public List<Card> getCardList()
        {
            return cardList;
        }

        public void addCard(Card card)
        {
            cardList.Add(card);
        }
    }
}
