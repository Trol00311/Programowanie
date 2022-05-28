using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Robotnik
    {
        int id;

        int sleep;
        public Robotnik(int id)
        {
            this.id = id;

            Random random = new Random();
            sleep=random.Next(100, 1000);
        }

        public void doRobota()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Robotnik: " + id+" ide spać na: "+sleep);
                Thread.Sleep(250);
            }
        }
    }
}
