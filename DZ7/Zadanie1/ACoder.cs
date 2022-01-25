using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1;

namespace Zadanie1
{
    internal class ACoder : ICoder
    {
        public string Encode(string str)
        {
            string str1="";
            foreach (char a in str)
            {
                if (a == 'я') str1 += 'а';
                else str1 += Convert.ToChar (a+1);
            }
            return str1;
            
        }

        public string Decode(string str)
        {
            string str1 = "";
            foreach (char a in str)
            {
                if (a == 'а') str1 += 'я';
                else str1 += Convert.ToChar(a - 1);
            }
            return str1;
        }
    }
}
