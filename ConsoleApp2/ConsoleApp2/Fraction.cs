using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Fraction : IComparable<Fraction>
    {

        public readonly int num;
        public readonly int den;

        public Fraction(int num, int den)
        {
            if (den == 0)
            {
                throw new ArgumentException("Mianownik nie moze byc 0");
            }
            this.num = num;
            this.den = den;
        }
        public override string ToString()
        {
            return $"{num}/{den}";
        }

        //dodawnie
        public Fraction add(Fraction secondFraction)
        {
            return new Fraction(num * secondFraction.den + secondFraction.num * den,den*secondFraction.den );
        }



        //dodawanie
        public static Fraction operator +(Fraction fr1,Fraction fr2)
        {
            return new Fraction(fr1.den * fr2.num + fr1.num * fr2.den, fr1.den * fr2.den);
        }

        //mnozenie
        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.num * fr2.num, fr1.den * fr2.den);
        }

        //dzielenie
        public static Fraction operator /(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.num * fr2.den, fr1.den * fr2.num);
        }

        //odejmowanie
        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.den * fr2.num - fr1.num * fr2.den, fr1.den * fr2.den);
        }

        public int CompareTo(Fraction fr2)
        {
            int num1 = num * fr2.den;
            int num2 = den * fr2.num;

            if(num1>num2)
            {
                return 1;
            }
            else if(num1<num2)
            {
                return -1;
            }
            return 0;
        }

    }
}
