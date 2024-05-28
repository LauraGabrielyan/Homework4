namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 8: Checking for Null or Empty Strings
            //Create two string variables: one with a non-empty value and
            //one with an empty value. 
            string non_empty = "string";
            string empty = "";
            string empty1 = "      ";
            //Use string.IsNullOrEmpty to check each string and print the result.
            Console.WriteLine(string.IsNullOrEmpty(non_empty));
            Console.WriteLine(string.IsNullOrEmpty(empty));
            Console.WriteLine(string.IsNullOrEmpty(empty1));
            Console.WriteLine("--------------------------");
            
            //Use string.IsNullOrWhiteSpace and get practice diffs between
            //string.IsNullOrEmpty and string.IsNullOrWhiteSpace
            Console.WriteLine(string.IsNullOrWhiteSpace(non_empty));
            Console.WriteLine(string.IsNullOrWhiteSpace(empty));
            Console.WriteLine(string.IsNullOrWhiteSpace(empty));
        }
    }
}
