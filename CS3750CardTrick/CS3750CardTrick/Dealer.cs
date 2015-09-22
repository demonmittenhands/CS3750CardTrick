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
        private int DealNumber; // needs to be dealt and selected at least 3 times. 
                                // - source Eric's wife.

        public static Deck deck = new Deck(); // just want the top 21 cards to work with
        public static List<Card> deck21 = new List<Card>(21);
        //deck21 = Deck.getDeck21();

        public Dealer(){

            MainWindow window = new MainWindow();
            window.lblTest.Content = "dealer init";
            window.Show();

            //window.imgTest.Source = deck21[0].getFace();
            
            //window.imgTest.Source = (System.Windows.Media.ImageSource)(deck21[0].getFace());

            BitmapImage image = new BitmapImage(new Uri("C:\\Users\\Erzee\\Source\\Repos\\CS3750CardTrick\\CS3750CardTrick\\CS3750CardTrick\\Deck\\10_of_spades.png", UriKind.Absolute));
            window.imgTest.Source = image;


            Dealer.deck21 = Dealer.deck.getDeck21();
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(deck21[i].getFace());
            }

        }

        public void test()
        {


        }


        

        public void Deal()
        {
            // arranges cards on board into columns

        }

        public void RevealCard()
        {
            // after DealNumber is at least 3
            // selected card is the 11th

        }

        public void PickupCards()
        {
            // after Player IndicateColumn()
            // indicated column needs to be picked up 2nd.
            // Deal() should be called from here
        }


    } // end Dealer()
} 
