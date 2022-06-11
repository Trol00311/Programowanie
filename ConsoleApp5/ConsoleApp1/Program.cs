using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] tab = new int[] {121,252, 3781, 123, 525};

            //foreach(var x in tab)
            //{
            //    string text = x.ToString();
            //    if (text[0] == text[text.Length-1])
            //        Console.WriteLine(x);
            //}

            //z klasy
            Robotnik rob1 = new Robotnik();
            DoPliku doPliku = new DoPliku();
            rob1.cosRobie(doPliku);


            //z interfejsu
            CosRobie rob2 = new CosRobie();
            DoPliku doPliku2 = new DoPliku();
            rob2.robieCos(doPliku2.zapiszDoPliku);


            //ma jedna metode
            zapisz z1 = new DoPliku();
            z1.zapisz("ala ma kota");
            //z1.zapiszDoPliku("ala ma kota"); ---------- nie dziala

            //ma dwie metody
            DoPliku z2 = new DoPliku();
            z2.zapisz("ala ma kota");
            z2.zapiszDoPliku("ala ma kota");

           
        }
    }
}
