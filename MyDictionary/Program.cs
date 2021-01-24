using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictonary<int,string> persons = new Dictonary<int,string>();
            persons.Add(1, "Demet");
            persons.Add(2, "Ece");
            persons.Add(3, "Deniz");
            
            
            Console.ReadLine();
        }
    }
}
