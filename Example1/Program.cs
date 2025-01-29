// See https://aka.ms/new-console-template for more information
Console.WriteLine("Example 1");

Console.WriteLine("Enter a number between 1 and 10");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 10)
{
    Console.WriteLine("Valid number");
}
else
{
    Console.WriteLine("Invalid number");
}