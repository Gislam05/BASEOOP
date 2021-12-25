using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    enum type
    {
        Budgetny,
        Valutny,
        Zamorojenny,
        Zastraxovanny,
    }

    internal class SchetVBanke
    {
        private string number;
        private decimal balans;
        private type typeScheta;
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                this.number = value;
            }
        }
        public decimal Balans
        {
            get { return balans; }
            set { this.balans = value; }
        }
        public type TypeScheta
        {
            get { return typeScheta; }
            set { this.typeScheta = value;}
        }
    }
}
