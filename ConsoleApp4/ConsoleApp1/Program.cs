using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pomiar<int> p1 = new Pomiar<int>(3);

            //Pomiar<double> p2 = new Pomiar<double>(3);

            //Console.WriteLine(p1.addPomiar(1));
            //Console.WriteLine(p1.addPomiar(1));
            //Console.WriteLine(p1.addPomiar(1));
            //Console.WriteLine(p1.addPomiar(100));
            //Console.WriteLine(p1.addPomiar(100));
            //Console.WriteLine(p1.addPomiar(100));

            for(int i=0;i<4;i++)
            {
                Robotnik rb1 = new Robotnik(i);
                Thread th1 = new Thread(rb1.doRobota);
                th1.Start();
            }



        }
    }
}
