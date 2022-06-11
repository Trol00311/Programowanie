using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DoPliku:zapisz
    {


        public void zapisz(string s)
        {
            zapiszDoPliku(s);
        }

        public void zapiszDoPliku(string s)
        {
            Console.WriteLine("Zapisano do pliku");
        }
            


    }
}
