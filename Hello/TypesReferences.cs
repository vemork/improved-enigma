namespace Hello;
public class Person
{
    public int Age;
}
public class Program
{
    static void Main(String[] args)
    {
            var number = 1;
            Increment(number);
            Console.WriteLine(number); // same value copy of value live in the scope copy on stack
            
            var person = new Person();
            MakeOld(person);
            Console.WriteLine(person.Age); // change de value copy on heap
    }
    
    private static void Increment(int number)
    {
        number += 10;
    }
    
    private static void MakeOld(Person person)
    {
        person.Age += 10;
    }
}