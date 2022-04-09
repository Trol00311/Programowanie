using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "Ala ma Kota kot ma ale";
            string[] words = text.Split(" ");

            Dictionary <int, List<string>> dictonary = new Dictionary<int, List<string>>();
            
            foreach (string word in words)
            {
                int key = word.Length;
                if(dictonary.ContainsKey(key))
                {
                    List<string> list = dictonary[key];
                    list.Add(word);
                }
                else
                {
                    List<string> list = new List<string>();
                    list.Add(word);
                    dictonary.Add(key, list);
                }
            }

            foreach (KeyValuePair<int, List<string>> kv in dictonary)
            {
                Console.Write(kv.Key+": ");
                foreach(string word in kv.Value)
                {
                    Console.Write(word + ", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------");
            foreach (string word in words)
            {
                Console.Write(word.ToUpper() + ", ");
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");

            words.Select(x => x.ToUpper()).ToList().ForEach(x=> Console.Write(x+", "));
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            
            int[] intTable = { 4, 2, 6, 2, 1, 5, 7, 2, 34, 6 };
            intTable.Select(x => x * 2).ToList().ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            
            intTable.Where(x=> x>4).ToList().ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            
            intTable.Where(x => x > 4).Select(x=> x*x).ToList().ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
           
            intTable.Where(x => x > 4).Select(x => x * x).OrderByDescending(x=>x).ToList().ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");

            words.GroupBy(x => x.Length).OrderByDescending(x => x.Key).ToList().ForEach(x=> {
                Console.Write(x.Key+": ");
                x.ToList().ForEach(y => Console.Write(y+", "));
                Console.WriteLine();
            });
            Console.WriteLine("--------------------------------------------");

        }
        
    }
}
