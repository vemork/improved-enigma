// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your name");
var name = Console.ReadLine();

char[] charArray = name.ToCharArray();
Array.Reverse(charArray);

string reversedName = new string(charArray);
Console.WriteLine($"Reversed name: {reversedName}");
