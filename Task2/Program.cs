using Microsoft.VisualBasic;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2: String Concatenation
            //Create many string variables.
            string str1 = "A ";
            string str2 = "string ";
            string str3 = "is ";
            string str4 = "an ";
            string str5 = "object";
            string str6 = "of";
            string str7 = "type ";
            string str8 = "String ";
            string str9 = "whose ";
            string str10 = "value";
            string str11 = "is";
            string str12 = "text";

            //Concatenate the strings with a space or another
            //charecter in between and print the result.
            String fullstr = string.Concat(str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12);
            Console.WriteLine(fullstr);

        }
    }
}
