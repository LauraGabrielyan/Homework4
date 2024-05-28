using Microsoft.VisualBasic;
using System.Threading;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 10: GetHashCode
            // Create two string variables str1 and str2 with the same content, e.g., "hello".
            String string1 = "different";
            string string2 = "different";

            //Create a third string variable str3 with different content, e.g., "world".
            string string3 = "variable";
            //Get the hash codes of all three strings using the GetHashCode method.
            int hashcode1 = string1.GetHashCode();
            int hashcode2 = string2.GetHashCode();
            int hashcode3 = string3.GetHashCode();

            //Print the hash codes and compare them.
           
            Console.WriteLine("Hash Code String1:" +hashcode1);
            Console.WriteLine("Hash Code String2:" + hashcode2);
            Console.WriteLine("Hash Code String3:" +hashcode3);
            bool isEqual1 = hashcode1 == hashcode2;
            if (isEqual1)
            {
                Console.WriteLine("The hashcodes of string1 and string2 are the same");
            }
            else
            {
                Console.WriteLine("The hashcodes of string1 and string2 are not the same");
            }
            bool isEqual2 = hashcode2 == hashcode3;
            if (isEqual2)
            {
                Console.WriteLine("The hashcodes of string2 and string3 are the same");
            }
            else
            {
                Console.WriteLine("The hashcodes of string2 and string3 are not the same");
            }
            bool isEqual3 = hashcode3 == hashcode1;
            if (isEqual3)
            {
                Console.WriteLine("The hashcodes of string1 and string3 are the same");
            }
            else
            {
                Console.WriteLine("The hashcodes of string1 and string3 are not the same");
            }

        }

    }
}
