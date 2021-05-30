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
            SortedList<int, string> phonebook = new SortedList<int, string>(); // generic sorted list

            Console.WriteLine("------------");

            // Adding
            Console.WriteLine("In Adding");

            Console.WriteLine("------------");

            // Displaying
            Console.WriteLine("In Displaying");

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
