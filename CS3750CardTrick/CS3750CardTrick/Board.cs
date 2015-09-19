using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3750CardTrick
{
    class Board
    {
        public void addToColumn(ref List<Card> columnId, Card card)
        {
            columnId.Add(card);
        }
    }
}
