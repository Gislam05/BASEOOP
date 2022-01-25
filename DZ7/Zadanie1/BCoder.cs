using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class BCoder:ICoder
    {
        public string Encode(string str)
        {
            int begin = (int)'а';
            int end = (int)'я';
            string str1 = "";
            foreach (char a in str)
            {
                if (a == 'я') str1 += 'а';
                else str1 += Convert.ToChar(Math.Abs (end - (a-begin)));
            }
            return str1;

        }

        public string Decode(string str)
        {
            int begin = (int)'я';
            int end = (int)'а';
            string str1 = "";
            foreach (char a in str)
            {
                if (a == 'а') str1 += 'я';
                else str1 += Convert.ToChar(Math.Abs(end - (a - begin)));
            }
            return str1;
        }
    }
}
