using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2
{
    internal struct Operators
    {
        private long numerator;
        private long denominator;

        public Operators(long numerator, long denominator)
        {
            long gcd = GreatestCommonDivisor(numerator, denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;
            if (this.denominator < 0)
            {
                this.numerator = -numerator;
                this.denominator = -denominator;
            }
        }

        private static long GreatestCommonDivisor(long firstNumber, long secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            while (firstNumber > 0)
            {
                long newNumber = secondNumber % firstNumber;
                secondNumber = firstNumber;
                firstNumber = newNumber;
            }
            return secondNumber;
        }

        public static Operators operator +(Operators f1, Operators f2)
        {
            long num = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            long denom = f1.denominator * f2.denominator;
            return (new Operators(num, denom));
        }

        public static Operators operator -(Operators f1, Operators f2)
        {
            long num = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            long denom = f1.denominator * f2.denominator;
            return (new Operators(num, denom));
        }
        public static Operators operator *(Operators f1, Operators f2)
        {
            long num = f1.numerator * f2.numerator;
            long denom = f1.denominator * f2.denominator;
            return (new Operators(num, denom));
        }
        public static Operators operator /(Operators f1, Operators f2)
        {
            long num = f1.numerator * f2.denominator;
            long denom = f1.denominator * f2.numerator;
            return (new Operators(num, denom));
        }
        public static Operators operator -(Operators fraction)
        {
            long num = -fraction.numerator;
            long denom = fraction.denominator;

            return new Operators(num, denom);
        }

        public static Operators operator ++(Operators frac)
        {
            long num = frac.numerator + frac.denominator;
            long denom = frac.denominator;
            return (new Operators(num, denom));
        }
        public static Operators operator --(Operators frac)
        {
            long num = frac.numerator - frac.denominator;
            long denom = frac.denominator;
            return (new Operators(num, denom));
        }
        public static bool operator true(Operators fraction)
        {
            return fraction.numerator != 0;
        }
        public static bool operator false(Operators fraction)
        {
            return fraction.numerator == 0;
        }
        // Explicit conversion to double operator 
        public static explicit operator double(Operators Fraction)
        {
            return (double)Fraction.numerator / Fraction.denominator;
        }
        public static implicit operator Operators(double value)
        {
            double num = value;
            long denom = 1l;
            while ((num-Math.Floor(num))>0)
            {
                num = num * 10;
                denom = denom * 10;
            }
            return new Operators((long)num, denom);
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}",numerator,denominator);
        }
    }
}
