using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CS3750CardTrick
{
    class Dealer
    {
        private int DealNumber = 0; // needs to be dealt and selected at least 3 times. 

        //public static Deck deck = new Deck(); // just want the top 21 cards to work with
        //public static List<Card> deck21 = new List<Card>(21);
        Board board = new Board();

        Column column0 = new Column(0);
        Column column1 = new Column(1);
        Column column2 = new Column(2);

        Deck deck = new Deck();
        List<Card>deck21 = new List<Card>(21);

        public Dealer()
        {
           deck21 = deck.getDeck21();

        }
 

        public void Deal()
        {
            // arranges cards on board into columns
            int i = 0;
            foreach (var card in deck21)
            {
                if (i <= 3)
                {
                    i = 0;
                }
                board.addToColumn(i, card);
            }
        }

        public Card RevealCard(List<Card> deck)
        {
            // after DealNumber is at least 3
            // selected card is the 11th
            return deck.ElementAt(10);
        }

        public List<Card> PickupCards(int columnId)
        {
            // after Player IndicateColumn()
            // indicated column needs to be picked up 2nd.
            // Deal() should be called from here
            List<Card> deck = new List<Card>();

            column0 = board.getColumn(0);
            column1 = board.getColumn(1);
            column2 = board.getColumn(2);

            if (columnId == 0)
            {
                addCardsToDeck(column1, deck);
                addCardsToDeck(column0, deck);
                addCardsToDeck(column2, deck);
            }

            if (columnId == 1)
            {
                addCardsToDeck(column0, deck);
                addCardsToDeck(column1, deck);
                addCardsToDeck(column2, deck);
            }

            if (columnId == 2)
            {
                addCardsToDeck(column0, deck);
                addCardsToDeck(column2, deck);
                addCardsToDeck(column1, deck);
            }

            Deal();
            DealNumber++;

            return deck;
        }

        public void addCardsToDeck(Column column, List<Card> deck)
        {
            foreach (var card in column.getCardList())
            {
                deck.Add(card);
            }
        }


    } // end Dealer()
} 
