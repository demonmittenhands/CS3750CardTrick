using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3750CardTrick
{
    class Card
    {
        private string face;//path to image
        //private int BobTester;

        public Card(String nFace)
        {
            this.face = nFace;
        }

        public String getFace()
        {
            return face;
        }

    }
}
