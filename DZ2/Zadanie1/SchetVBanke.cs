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
        private static int generator;
        private string number;
        private decimal balans;
        private type typeScheta;

        public decimal Balans
        {
            get { return balans; }
        }


        public SchetVBanke() //Этих круглых скобок не бывает после свойств - визуальное отличие от методов
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

        public void polojit(int sum)
        {
            balans += sum;
        }

        public void snyat(int sum)
        {
            if (balans >= sum)
                balans -= sum;
            else
            {
                Console.WriteLine($"Укажите сумму меньше или равную {balans}");
            }

        }

        public void perevod(SchetVBanke schet, int summ)
        {
            if (schet.balans >= summ)
            {
                schet.balans -= summ;
                balans += summ;
            }

            else Console.WriteLine($"Мало денег. Введите сумму не больше {schet.balans}");
        }

    }
}
