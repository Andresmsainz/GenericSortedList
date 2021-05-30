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

            Console.WriteLine("Changing Jack's Number using Index");
            phonebook["Jack"] = "(786)999-4387";

            foreach (var item in phonebook)
            {
                Console.WriteLine("Current Item = " + item.Key + " , " + item.Value);
            }

            Console.WriteLine("------------");

            // TryGetValue
            Console.WriteLine("In TryGetValue");

            Console.WriteLine("Retrieving Willies Number");
            phonebook.TryGetValue("Willie", out string result);
            Console.WriteLine("Result = " + result);

            Console.WriteLine("Retrieving Andres Number");
            if (phonebook.TryGetValue("Andres", out string result2) == false) 
            {
                result2 = "Not Found";
            }
            Console.WriteLine("Result = " + result2);

            Console.WriteLine("------------");

            // Contains
            Console.WriteLine("In Contains");

            Console.WriteLine("Looking for Jill");
            Console.WriteLine("Does phone book contain the name Jill? = " + phonebook.ContainsKey("Jill")); 

            Console.WriteLine("Looking for Pancho");
            Console.WriteLine("Does phone book contain the name Pancho? = " + phonebook.ContainsKey("Pancho"));

            Console.WriteLine("Looking for (212)444-4689");
            Console.WriteLine("Does phone book contain the number (212)444-4689? = " + phonebook.ContainsValue("(212)444-4689"));

            Console.WriteLine("Looking for (215)444-4689");
            Console.WriteLine("Does phone book contain the number (215)444-4689? = " + phonebook.ContainsValue("(215)444-4689"));

            Console.WriteLine("------------");

            // Remove
            Console.WriteLine("In Remove");

            Console.WriteLine("Removing Willie");
            phonebook.Remove("Willie");

            foreach (var item in phonebook)
            {
                Console.WriteLine("Current Item = " + item.Key + " , " + item.Value);
            }


            Console.WriteLine("------------");

            // Remove All
            Console.WriteLine("In Remove All");
            phonebook.Clear();

            foreach (var item in phonebook)
            {
                Console.WriteLine("Current Item = " + item.Key + " , " + item.Value);
            }

            Console.WriteLine("------------");


        }
    }
}
