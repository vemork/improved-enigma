// See https://aka.ms/new-console-template for more information
Console.WriteLine("Example 2");
Console.WriteLine("Enter a number x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x is greater than y");
}
else
{
    Console.WriteLine("y is greater than x");
}

Console.WriteLine("### Example 2.1 ###");
Console.WriteLine("Enter Height");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Width");
int width = Convert.ToInt32(Console.ReadLine());
if (height > width)
{
    Console.WriteLine("The image is portrait");
}
else
{
    Console.WriteLine("The image is landscape");
}


Console.WriteLine("Enter the speed limit:");
int speedLimit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the speed of the car:");
int carSpeed = Convert.ToInt32(Console.ReadLine());

if (carSpeed <= speedLimit)
{
    Console.WriteLine("Speed is Ok");
}
else
{
    int demeritPoints = (carSpeed) / 5;
    Console.WriteLine("Demerit points: " + demeritPoints);
    if (demeritPoints > 12)
    {
        Console.WriteLine("License Suspended");
    }
}
