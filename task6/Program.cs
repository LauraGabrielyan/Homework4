namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 6: Replacing Substrings
            //Create a string variable with the value like
            //"I love programming in Java" and Replace "Java" with "C#"

            string text = "Value types differ from reference types in that " +
                "hauei of the value types directly contain their data, " +
                "whereas variables of the reference types store references to their data, " +
                "the latter being known as objects. With reference types, it is possible" +
                " for two variables to reference the same object, and thus possible for" +
                " operations on one variable to affect the object referenced by the other variable. " +
                "With value types, the variables each have their own copy of the data, " +
                "and it is not possible for operations on one to affect the other.";
            string replaced = text.Replace("hauei", "variables");
            string text1 = "I love programming in Java";
            string replaced1 = text1.Replace("Java","C#");

            //print the result.
            Console.WriteLine(replaced);
            Console.WriteLine(replaced1);
        }
    }
}
