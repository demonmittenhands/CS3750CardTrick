using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3750CardTrick
{
    class Board
    {
        public void addToColumn(int columnId, Card card)
        {
            switch (columnId)
            {
                case 0:
                    Column.addCard(card);
                    break;
                case 1:
                    Column.addCard(card);
                    break;
                case 2:
                    Column.addCard(card);
                    break;
            }
        }
    }
}
