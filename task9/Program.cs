using Microsoft.VisualBasic;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 9: String Comparison
            //Create two string variables with different casing, e.g., "hello" and "HELLO".
            string string1 = "hello";
            string string2 = "HELLO";
          //Compare the strings using different values from StringComparison
          bool isEqual=string.Equals(string1,string2,StringComparison.Ordinal);
          bool isEqual1=string.Equals(string1,string2,StringComparison.OrdinalIgnoreCase);
          bool isEqual2 = string.Equals(string1, string2, StringComparison.InvariantCultureIgnoreCase);
          bool isEqual3=string.Equals(string1,string2, StringComparison.InvariantCulture);
          bool isEqual4 = string.Equals(string1, string2, StringComparison.CurrentCultureIgnoreCase);
          bool isEqual5 = string.Equals(string1, string2, StringComparison.CurrentCulture);
          
          //Print whether they are equal.
          if (isEqual)
            {
                Console.WriteLine("Ordinal: Strings are equal");
            }
          else
            {
                Console.WriteLine("Ordinal : Strings are  not equal");
            }
          if (isEqual1)
            {
                Console.WriteLine("OrdinalIgnoreCase: Strings are equal");
            }
          else
            {
                Console.WriteLine("OrdinalIgnoreCase: Strings are not equal");
            }
            if (isEqual2)
            {
                Console.WriteLine("InvariantCultureIgnoreCase : Strings are equal");
                    
            }
            else
            {
                Console.WriteLine("InvariantCultureIgnoreCase: Strings are  not equal");
            }
            if (isEqual3) 
            {
                Console.WriteLine("InvariantCulture: Strings are equal");
            }
            else
            {
                Console.WriteLine("InvariantCulture: Strings are not equal");
            }
            if (isEqual4)
            {
                Console.WriteLine("CurrentCultureIgnoreCase: Strings are equal");
            }
            else
            {
                Console.WriteLine("CurrentCultureIgnoreCase: Strings are not equal");
            }
            if (isEqual5) 
            {
                Console.WriteLine("CurrentCulture: Strings are equal");
            }
            else 
            {
                Console.WriteLine("CurrentCulture : Strings are not equal");
            }
        }
    }
}
