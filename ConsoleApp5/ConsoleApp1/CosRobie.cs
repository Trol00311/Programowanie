using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void jakisDelegat(string s);
    class CosRobie
    {

        public void robieCos(jakisDelegat dd1)
        {
            dd1("Cos tam robie");
        }
    }
}
