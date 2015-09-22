using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3750CardTrick
{
    class Board
    {
        Column column0 = new Column(0);
        Column column1 = new Column(1);
        Column column2 = new Column(2);

        public Column getColumn(int id)
        {
            switch (id)
            {
                case 0:
                    return column0;
                case 1:
                    return column1;
                case 2:
                    return column2;
                default:
                    return column0;                   
            }
        }

        public void addToColumn(int columnId, Card card)
        {
            switch (columnId)
            {
                case 0:
                    column0.addCard(card);
                    break;
                case 1:
                    column1.addCard(card);
                    break;
                case 2:
                    column2.addCard(card);
                    break;
            }
        }
    }
}
