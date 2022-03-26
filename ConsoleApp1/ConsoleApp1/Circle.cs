using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle
    {
        double a;
        double pi = 3.14;

        public void GetValues()
        {
            Console.WriteLine("Podaj promień koła: ");
            a = double.Parse(Console.ReadLine());

        }

        public double area()
        {
            return pi*a*a;
        }

        public double primer()
        {
            return 2*pi*a;
        }
    }
}
