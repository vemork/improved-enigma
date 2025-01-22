public class Person
{
    // public string Name; // Non-nullable reference
    public string Name = string.Empty;

    public void Introduce()
    {
        Console.WriteLine("Hi, my name is " + Name); // static method
    }
}

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

int number; // 0

var person = new Person();
person.Name = "Alice";
person.Introduce();

public class MathCalculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
// calling a static method without creating an instance of the class
// MathCalculator
MathCalculator.Add(1, 2);


