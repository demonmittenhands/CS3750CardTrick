using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3750CardTrick
{
    class Deck
    {
        public List<Card> deck;
        public List<Card> deck21; // the 21 cards used for the trick

        public Deck()
        {
            deck = new List<Card>(52);
            createDeck();
            shuffle();
            random21(); // only use 21 cards for trick
            
        }

        private void createDeck()
        {
            //Each card will be a string of a location to it's card image.
            String suit;
            for (int i = 0; i < 52; i++)
            {
                if (i < 13)
                {
                    suit = "hearts.png";
                }
                else if (i >= 13 && i < 26)
                {
                    suit = "diamonds.png";
                }
                else if (i >= 26 && i < 39)
                {
                    suit = "spades.png";
                }
                else
                {
                    suit = "clubs.png";
                }
                Card ace = new Card  ("Deck\\ace_of_" + suit);
                Card two = new Card  ("Deck\\2_of_" + suit);
                Card three = new Card("Deck\\3_of_" + suit);
                Card four = new Card ("Deck\\4_of_" + suit);
                Card five = new Card ("Deck\\5_of_" + suit);
                Card six = new Card  ("Deck\\6_of_" + suit);
                Card seven = new Card("Deck\\7_of_" + suit);
                Card eight = new Card("Deck\\8_of_" + suit);
                Card nine = new Card ("Deck\\9_of_" + suit);
                Card ten = new Card  ("Deck\\10_of_" + suit);
                Card jack = new Card ("Deck\\jack_of_" + suit);
                Card king = new Card ("Deck\\king_of_" + suit);
                Card queen = new Card("Deck\\queen_of_" + suit);
                //Switch statement to build the deck of cards
                switch (i)
                {
                    case 0:
                    case 13:
                    case 26:
                    case 39:
                        deck.Add(ace);
                        break;
                    case 1:
                    case 14:
                    case 27:
                    case 40:
                        deck.Add(two);
                        break;
                    case 2:
                    case 15:
                    case 28:
                    case 41:
                        deck.Add(three);
                        break;
                    case 3:
                    case 16:
                    case 29:
                    case 42:
                        deck.Add(four);
                        break;
                    case 4:
                    case 17:
                    case 30:
                    case 43:
                        deck.Add(five);
                        break;
                    case 5:
                    case 18:
                    case 31:
                    case 44:
                        deck.Add(six);
                        break;
                    case 6:
                    case 19:
                    case 32:
                    case 45:
                        deck.Add(seven);
                        break;
                    case 7:
                    case 20:
                    case 33:
                    case 46:
                        deck.Add(eight);
                        break;
                    case 8:
                    case 21:
                    case 34:
                    case 47:
                        deck.Add(nine);
                        break;
                    case 9:
                    case 22:
                    case 35:
                    case 48:
                        deck.Add(ten);
                        break;
                    case 10:
                    case 23:
                    case 36:
                    case 49:
                        deck.Add(jack);
                        break;
                    case 11:
                    case 24:
                    case 37:
                    case 50:
                        deck.Add(king);
                        break;
                    case 12:
                    case 25:
                    case 38:
                    case 51:
                        deck.Add(queen);
                        break;
                }
            }
        }
        public void shuffle()
        {
            Random rdm = new Random();
            int randomNum;
            Card temp;
            for (int i = 0; i < deck.Count; i++)
            {
                temp = deck[i];
                randomNum = rdm.Next(i, deck.Count);
                deck[i] = deck[randomNum];
                deck[randomNum] = temp;
            }
        }
        public Card dealCard()
        {
            Card dealCard;
            if (deck.Count() > 0)
            {
                dealCard = deck[0];
                deck.RemoveAt(0);
                return dealCard;
            }
            else
            {
                createDeck();
                shuffle();
                dealCard = deck[0];
                deck.RemoveAt(0);
                return dealCard;
            }
        }

        public void random21(){
            deck21 = new List<Card>(21);
            for (int i = 0; i < 21; i++)
            {
                deck21.Add(deck[0]);
                deck.RemoveAt(0);
            }
        }

        public List<Card> getDeck21()
        {
            return deck21;

        }

    }
}
