namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 7: Trimming Strings
            //Create a string variable with the value " Hello, World! ".
            string str = "     Hello, World  ";
            string text = "         Value types differ from reference types in that " +
           "hauei of the value types directly contain their data, " +
           "whereas variables of the reference types store references to their data, " +
           "the latter being known as objects. With reference types, it is possible" +
           " for two variables to reference the same object, and thus possible for" +
           " operations on one variable to affect the object referenced by the other variable. " +
           "With value types, the variables each have their own copy of the data, " +
           "and it is not possible for operations on one to affect the other.     ";
            //Trim the leading and trailing whitespace  

            string trimmed=str.Trim();
            string trimmedtext=text.Trim();

            //print the result.
             Console.WriteLine(trimmed);
            Console.WriteLine(trimmedtext);
        }
    }
}
