using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class squre : Isqure
    {
        double a;

        public void GetValues()
        {
            Console.WriteLine("Podaj bok kwadratu: ");
            a = double.Parse(Console.ReadLine());

        }

        public double area()
        {
            return a * a;
        }

        public double primer()
        {
            return 4 * a;
        }
    }
}
