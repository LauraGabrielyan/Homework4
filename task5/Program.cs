using System.Collections.Generic;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 5: Splitting Strings
            //Create a string variable with a list of comma - separated values,
            //e.g., "apple,banana,orange" , "C# , Java , JavaScript , Pyton etc...".
            string listfruit = "apple,banana,orange";
            string listlanguages = "C# ,Java ,JavaScript ,Pyton ";
            //Split the string into an[array] of individual fruit names or
            //profession languages and print each fruit on a new line.
            string[] split =listfruit.Split(',');
            string[] split1=listlanguages.Split(",");
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);
            Console.WriteLine(split1[0]);
            Console.WriteLine(split1[1]);
            Console.WriteLine(split1[2]);
            Console.WriteLine(split1[3]);

        }
    }
}
