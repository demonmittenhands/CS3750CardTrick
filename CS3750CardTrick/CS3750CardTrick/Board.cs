using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3750CardTrick
{
    class Board
    {
        Column column1 = new Column();
        Column column2 = new Column();
        Column column3 = new Column();
        public void addToColumn(int columnId, Card card)
        {
            switch (columnId)
            {
                case 0:
                    column1.addCard(card);
                    break;
                case 1:
                    column2.addCard(card);
                    break;
                case 2:
                    column3.addCard(card);
                    break;
            }
        }
    }
}
