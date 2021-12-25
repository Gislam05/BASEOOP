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
        public static int generator;
        private string number;
        private decimal balans;
        private type typeScheta;
        public SchetVBanke()
        {
            generator++;
            number += generator.ToString();
        }
        public SchetVBanke(decimal balans)
        {
            generator++;
            number += generator.ToString();
            this.balans = balans;
        }
        public SchetVBanke(type typeScheta)
        {
            generator++;
            number += generator.ToString();
            this.typeScheta = typeScheta;
        }
        public SchetVBanke(decimal balans, type typeScheta)
        {
            generator++;
            number += generator.ToString();
            this.balans = balans;
            this.typeScheta = typeScheta;
        }

    }
}
