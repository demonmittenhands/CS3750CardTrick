using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3750CardTrick
{
    class Dealer
    {
        private int DealNumber; // needs to be dealt and selected at least 3 times. 
                                // - source Eric's wife.

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
