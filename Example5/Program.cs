// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var control = true;
var name = string.Empty;
var namesList = new List<string>();

while (control)
{
    Console.WriteLine("Ingrese un nombre, para salir presiona solo enter");
    name = Console.ReadLine();

    if (string.IsNullOrEmpty(name))
    {
        break;
    }
    else
    {
        namesList.Add(name);
    }
}

var numberOfNames = namesList.Count;

if (numberOfNames == 1)
{
    Console.WriteLine($"Your friend: {namesList[0]} likes your post!");
}
if (numberOfNames > 1)
{
    Console.WriteLine($"Your friends: {string.Join(" and ", namesList)} like your post!");
}
