using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz figure");
            Console.WriteLine("1. Koło");
            Console.WriteLine("2. Trójkąt");
            Console.WriteLine("3. kwadrat");
            
            double pi = 3.14;
            
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz 1. Pole lub 2.Obwód");

            int second = int.Parse(Console.ReadLine());

            switch (first)
            {
                case 1:
                    Circle cr = new Circle();
                    cr.GetValues();
                    if (second == 1)
                    {
                        Console.WriteLine("Twój wynik to " + cr.area());
                    }
                    else if (second == 2)
                    {
                        Console.WriteLine("Twój wynik to " + cr.primer());
                    }
                    else
                        Console.WriteLine("Błedna zmienna");
                    break;
                case 2:
                    Triangle tr = new Triangle();
                    tr.GetValues()
                    if (second == 1)
                    {
                        Console.WriteLine("Twój wynik to " + tr.area());
                    }
                    else if (second == 2)
                    {
                        Console.WriteLine("Twój wynik to " + tr.primer());
                    }
                    else
                        Console.WriteLine("Błedna zmienna");
                    break;
                case 3:
                    squre sq = new squre();
                    sq.GetValues();

                    if (second == 1)
                    {
                        Console.WriteLine("Twój wynik to " +sq.area());
                    }
                    else if (second == 2)
                    {
                        Console.WriteLine("Twój wynik to " + sq.primer());
                    }
                    else
                        Console.WriteLine("Błedna zmienna");

                    break;
                default:
                    Console.WriteLine("Błedny wybór");
                    break;

            }
        }
    }


}
