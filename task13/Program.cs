using System.Runtime.Intrinsics.X86;

namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 13: == Operator
            //Create two string variables str1 and str2 with the same content, e.g., "hello".
            string str1 = "operator";
            string str2 = "operator";

            //Create a third string variable str3 with different content, e.g., "world".
            string str3 = "world";
         //Use the == operator to compare str1 with str2, and str1 with str3.
           bool isEqual=str1== str2;
           bool isEqual2=str2==str3;
            //Print the results.
            
            Console.WriteLine(isEqual);
            Console.WriteLine(isEqual2);

        }
    }
}
