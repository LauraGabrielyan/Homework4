using System.Xml.Linq;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3: String Interpolation
            // Create variables for  your personal data(name, age, profession, etc..).
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter proffesion:");
            string profession =Console.ReadLine();


            // Use string interpolation to create and print a sentence
             // Interpolated string

            Console.WriteLine($"{name} is {age} years old and works as a {profession}");

            //or composite formatting
            Console.WriteLine("{0} is {1} years old and works as a {2}" , name,age,profession);
        }
    }
}
