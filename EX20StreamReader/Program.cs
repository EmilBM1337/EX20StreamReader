using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace EX20StreamReader
{
    class Program
    {
        private static List<int> GetNumbersFromFile(string url)
        {
            List<int> tal = new List<int>();

            using (StreamReader sr = new StreamReader("Values.txt"))
            {
                while (!sr.EndOfStream)
                {
                    tal.Add(int.Parse(sr.ReadLine()));
                }
            }
            return tal;
        }
        static void Main(string[] args)
        {
            List<int> x = GetNumbersFromFile("Values.txt");
            Console.WriteLine(x.Average());
            Console.WriteLine(x.Sum());

            /*
            using (StreamReader sr = new StreamReader("Values.txt"))
            {
                float sum = 0;
                float counter = 0;

                while (!sr.EndOfStream)
                {
                    sum = sum + float.Parse(sr.ReadLine());
                    counter++;
                }
                Console.WriteLine("Sum " + sum);
                Console.WriteLine("Gennemsnit " + (sum / counter));
            }
            */
        }
    }
}
