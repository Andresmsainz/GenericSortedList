using System;
using System.Collections;
using System.Collections.Generic;


namespace GenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Sorted Lists!");

            // Creating
            Console.WriteLine("In Creating");

            SortedList list = new SortedList(); // non generic sorted list
            SortedList<string, string> phonebook = new SortedList<string, string>(); // generic sorted list

            Console.WriteLine("------------");

            // Adding
            Console.WriteLine("In Adding");

            phonebook.Add("Jack", "(845)222-3492");
            phonebook.Add("Jill", "(305)333-7432");
            phonebook.Add("Willie", "(212)444-4689");
            phonebook.Add("Frankie", "(961)555-9238");

            
            Console.WriteLine("------------");

            // Displaying
            Console.WriteLine("In Displaying");

            foreach (var item in phonebook)
            {
                Console.WriteLine("Current Item = " + item.Key + " , " + item.Value);
            }

            Console.WriteLine("------------");

            // Index
            Console.WriteLine("In Index");

            Console.WriteLine("------------");

            // TryGetValue
            Console.WriteLine("In TryGetValue");

            Console.WriteLine("------------");

            // Contains
            Console.WriteLine("In Contains");

            Console.WriteLine("------------");

            // Remove
            Console.WriteLine("In Remove");

            Console.WriteLine("------------");

            // Remove All
            Console.WriteLine("In Remove All");

            Console.WriteLine("------------");


        }
    }
}
