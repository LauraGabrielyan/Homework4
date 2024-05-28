using System.Runtime.Intrinsics.X86;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 12: Equals
            // Create two string variables str1 and str2 with the same content, e.g., "hello".
            string str1 = "content";
            string str2 = "content";
            //Create a third string variable str3 with different content, e.g., "world".
            string str3 = "method";
         //Use the Equals method to compare str1 with str2, and str1 with str3.
         bool isEqual= Equals(str1, str2);
          bool isEqual2 = Equals(str2, str3);
            //Print the results.
            Console.WriteLine(isEqual);
            Console.WriteLine(isEqual2);
        }
    }
}
