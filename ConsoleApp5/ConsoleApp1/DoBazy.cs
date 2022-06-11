using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DoBazy:zapisz
    {

        public void zapisz(string s)
        {
            zapiszDoBazy(s);
        }

        public void zapiszDoBazy(string s)
        {
            Console.WriteLine("Zapisano do pliku");
        }
            
    }
}
