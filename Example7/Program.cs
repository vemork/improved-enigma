// Example 7

int[] numbersArray = new int[5];
Console.WriteLine("Enter a number");
var number = int.Parse(Console.ReadLine());
var control = 0;
while (true)
{
    foreach (var item in numbersArray)
    {
        if (item == number)
        {
            Console.WriteLine("Number already exists");
            break;
        }
    }
    numbersArray[control] = number;
    control++;
    if (control == 5)
    {
        Console.WriteLine("Array is full");
        break;
    }

    Console.WriteLine("Enter a number");
    number = int.Parse(Console.ReadLine());
}
Array.Sort(numbersArray);
foreach (var item in numbersArray)
{
    Console.WriteLine(item);
}
