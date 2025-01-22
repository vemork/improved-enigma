using MiProyecto;
using otherFolder;

namespace fundamentals
{
    public class Person
    {
        public string Name = string.Empty;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name); // static method
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // dotnet build
            // dotnet run Program.cs

            Console.WriteLine("Hello World!");
            var person = new Person();
            person.Name = "Alice";
            person.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            var otherCalculator = new otherCalculator();
            var result2 = otherCalculator.Subtraction(1, 2);
            Console.WriteLine(result2);

            Console.WriteLine("Bye World!");
        }
    }
}
