using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4: Searching Within Strings
            // Create a string variable with the value at some interesting text at blog
            // (large interesting text).

            string text = "The types of the C# language are divided into " +
                "two main categories: reference types and value types. " +
                "Both value types and reference types may be generic types, " +
                "which take one or more type parameters. " +
                "Type parameters can designate both value types and reference types.";
            //Check if the string contains the word(some word's) and print the result.
            bool check = text.Contains("parameters");
            bool check1 = text.Contains("haadywiq");
            if (check)
            {
                Console.WriteLine("Text contains the word parameters");
            }
            
            if (check1)
            {
                Console.WriteLine("Text contains the word haadywiq");
            }
            else
                Console.WriteLine("Text does not contain the word haadywiq");


            //Find the index of the words and print them.
            if (check )
             {
                Console.WriteLine(text.IndexOf("parameters"));
             }
            if (check1)
            {
                Console.WriteLine(text.IndexOf("haadywiq"));
            }
            

            
        }
    }
}
