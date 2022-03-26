using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Compare : IComparer<Fraction>
    {
        int IComparer<Fraction>.Compare(Fraction fr1, Fraction fr2)
        {
            int num1 = fr1.num * fr2.den;
            int num2 = fr1.den * fr2.num;

            if (num1 < num2)
            {
                return 1;
            }
            else if (num1 > num2)
            {
                return -1;
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fr1 = new Fraction(1, 3);
            Fraction fr2 = new Fraction(1, 2);
            Console.WriteLine(fr1);
            Console.WriteLine(fr2);
          
            // dodawnie
            Console.WriteLine("Dodawnie: "+fr1.add(fr2));
            Console.WriteLine("Dodawnie: "+fr1 + fr2);

            //mnozenie
            Console.WriteLine("Mnozenie: "+fr1 * fr2);

            //dzielenie
            Console.WriteLine("Dzielenie: "+fr1 / fr2);

            //odejmowanie
            Console.WriteLine("Odejmowanie: "+(fr1 - fr2));

            List<Fraction> list = new List<Fraction>();
            list.Add(fr1);
            list.Add(fr2);
            list.Add(new Fraction(-3,5));
            list.Add(new Fraction(2,5));

            foreach(Fraction fr in list)
            {
                Console.WriteLine(fr);

            }

            Console.WriteLine("------------------");
            
            Console.WriteLine("OD NAJWIEKSZEJ DO NAJMNIJESZEJ: ");
            list.Sort(new Compare());
            list.ForEach(Console.WriteLine);

            Console.WriteLine();
           
            Console.WriteLine("OD NAJMNIEJSZEJ DO NAJWIEKSZEJ");
            list.Sort();
            list.ForEach(Console.WriteLine);
        }
    }
}
