using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Rational
    {
        int numerator; //Числитель рациональной дроби - целое число
        ushort denominator; //а знаменатель - натуральное число

        public Rational (int numerator, ushort denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public static Rational operator *(Rational rational1, Rational rational2 )
        {
            return new Rational (rational1.numerator * rational2.numerator, rational1.denominator * rational2.denominator);
        }
        public static Rational operator /(Rational rational1, Rational rational2)
        {
            return new Rational(rational1.numerator * rational2.denominator, rational1.denominator * rational2.numerator);
        }

        public static Rational operator +(Rational rational1, Rational rational2)
        {
            return new Rational(rational1.numerator * rational2.denominator + rational2.numerator*rational1.denominator, rational1.denominator * rational2.denominator);
        }
        public static Rational operator -(Rational rational1, Rational rational2)
        {
            return new Rational(rational1.numerator * rational2.denominator - rational2.numerator * rational1.denominator, rational1.denominator * rational2.denominator);
        }
        public override string ToString()
        {
            Console.WriteLine(numerator);
            Console.WriteLine("__");
            Console.WriteLine(denominator);
            return base.ToString();

        }
    }
}
