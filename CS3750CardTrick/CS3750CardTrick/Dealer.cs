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
        private int DealNumber; // needs to be dealt and selected at least 3 times.  - source Eric's wife.

        public static Deck deck = new Deck(); // just want the top 21 cards to work with
        public static List<Card> deck21 = new List<Card>(21);

        Column column1;
        Column column2;
        Column column3;


        public Dealer(){
            column1 = new Column();
            column2 = new Column();
            column3 = new Column();

            column1.id = 1;
            column2.id = 2;
            column3.id = 3;

            deck21 = deck.getDeck21();

            DealNumber = 0;
        }
      

        public void Deal()
        {
            // arranges cards on board into columns
            for (int i = 0; i < 21; i++)
            {
                if (i % 3 == 0) // add cards to the right columns.
                {
                    column1.addCard(deck21[i]);
                } else if (i % 3 == 1 ) 
                {
                    column2.addCard(deck21[i]);
                }
                else if (i % 3 == 2)
                {
                    column3.addCard(deck21[i]);
                }

            }

            DealNumber++;

            // after cards have been dealt, send the columns over to the board

        }

        public void RevealCard()
        {
            // after DealNumber is at least 3
            // selected card is the 11th
            // need to display deck21[10]

        }

        public void PickupCards(int indicatedColumn)
        {
            // after Player IndicateColumn()
            // indicated column needs to be picked up 2nd.
            
            deck21.Clear();

            if (indicatedColumn == 1)
            {
                for (int i=0; i<7; i++){
                    deck21.Add(column2.getCardList()[i]);                
                }
                for (int i = 0; i < 7; i++)
                {
                    deck21.Add(column1.getCardList()[i]);
                }
                for (int i = 0; i < 7; i++)
                {
                    deck21.Add(column3.getCardList()[i]);
                }
            }

            if (indicatedColumn == 2)
            {
                for (int i = 0; i < 7; i++)
                {
                    deck21.Add(column1.getCardList()[i]);
                }
                for (int i = 0; i < 7; i++)
                {
                    deck21.Add(column2.getCardList()[i]);
                }
                for (int i = 0; i < 7; i++)
                {
                    deck21.Add(column3.getCardList()[i]);
                }
            }

            if (indicatedColumn == 3)
            {
                for (int i = 0; i < 7; i++)
                {
                    deck21.Add(column2.getCardList()[i]);
                }
                for (int i = 0; i < 7; i++)
                {
                    deck21.Add(column3.getCardList()[i]);
                }
                for (int i = 0; i < 7; i++)
                {
                    deck21.Add(column1.getCardList()[i]);
                }
            }
            // now deal the cards again
            Deal();
        }


    } // end Dealer()
} 
