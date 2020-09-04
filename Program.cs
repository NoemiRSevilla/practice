using System;
using System.Collections.Generic;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numarray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] namearray = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            string[] truefalse = new string[] { "true", "false", "true", "false", "true", "false", "true", "false", "true", "false" };
            List<string> icecreamflavor = new List<string>();
            icecreamflavor.Add("rocky road");
            icecreamflavor.Add("bubble gum");
            icecreamflavor.Add("superman");
            icecreamflavor.Add("chocolate");
            icecreamflavor.Add("vanilla");
            icecreamflavor.Add("strawberry");
            Console.WriteLine(icecreamflavor.Count);
            Console.WriteLine(icecreamflavor[2]);
            icecreamflavor.RemoveAt(2);
            Console.WriteLine(icecreamflavor.Count);
            Dictionary<string, string> practice = new Dictionary<string, string>();
            practice.Add("Tim", "rocky road");
            practice.Add("Martin", "bubble gum");
            practice.Add("Nikki", "strawberry");
            practice.Add("Sara", "vanilla");
            foreach (var entry in practice){
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }
        }
    }
}