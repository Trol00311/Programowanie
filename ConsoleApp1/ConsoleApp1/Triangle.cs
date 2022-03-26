using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle
    {
        double a,b,c,d;

        public void GetValues()
        {
            Console.WriteLine("Podaj wyskość trójkąta: ");
             d = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj podstawe trójkąta: ");
             a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugi bok trójkąta: ");
             b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzeci bok trójkąta: ");
             c = double.Parse(Console.ReadLine());

        }

        public double area()
        {
            return 0.5*d*a;
        }

        public double primer()
        {
            return a+b+c;
        }
    }
}
