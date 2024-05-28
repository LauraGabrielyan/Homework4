namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1:Basic String Operations
            //Create a string variable with the value.

            string str = "A string is an object of type String whose value is text";
            Console.WriteLine(str);
           // Print the length of the string.
           Console.WriteLine(str.Length);
            //Convert the string to uppercase and print it.
            string upperstr=str.ToUpper();
            Console.WriteLine(upperstr);
            //Convert the string to lowercase and print it.
            string lowerstr=str.ToLower();
            Console.WriteLine(lowerstr);
            //Extract and print the substring "type" from the string.
            int index = str.IndexOf("type");
            int index1 = str.IndexOf("String");
            string str1=str.Substring(0, index);
            string str2=str.Substring(index1);


            
             Console.WriteLine(str1+str2);

        }
    }
}
