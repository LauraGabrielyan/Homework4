using System.Runtime.Intrinsics.X86;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 11: ReferenceEquals
            //Create two string variables str1 and str2 with the same content, e.g., "TTT".
            string str1 = "PPP";
            string str2 = "PPP";
         //Create a third string variable str3 using new keyword with the same
         //content as str1, e.g., new string('TTT', 3).
         string str3=new string('P',2);
         //Use the ReferenceEquals method to compare str1 and str2, and then str1 and str3.
            bool isEqual=ReferenceEquals(str1,str2);
            bool isEqual1=ReferenceEquals(str1,str3);
         //Print the results.
         if(isEqual )
            {
                Console.WriteLine("Str1 and str2 are equal");
            }
            else
            {
                Console.WriteLine("Str1 and str2 are  not equal");
            }
         if (isEqual1)
            {
                Console.WriteLine("Str1 and str3 are equal");
            }
            else
            {
                Console.WriteLine("Str1 and str3 are  not equal");
            }
        }
    }
}
