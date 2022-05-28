using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pomiar<T>
    {

        int ilosc;
        T[] tablica;
        int licznik = 0;

        public Pomiar(int ilosc)
        {
            this.ilosc = ilosc;
            tablica = new T[ilosc];
        }
        public double addPomiar(T value)
        {
            tablica[licznik] = value;
            licznik++;
            if(licznik==tablica.Length)
            {
                licznik = 0;
            }
            return licznik;
        }
        
        

    }
}
