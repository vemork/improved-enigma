// See https://aka.ms/new-console-template for more information
Console.WriteLine("Imprimiendo los números pares de 1 a 100");
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

var name = "John Wick";

for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}

foreach (var letter in name)
{
    Console.WriteLine(letter);
}

var numbers = new int[] { 1, 2, 3, 4, 5 };
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

var ii = 0;
while (ii < 10)
{
    if (ii % 2 == 0)
    {
        Console.WriteLine(ii);
    }
    ii++;
}

while (true)
{
    Console.WriteLine("Ingrese un nombre: ");
    var input = Console.ReadLine();

    if (String.IsNullOrWhiteSpace(input))
        break;

    Console.WriteLine("Nombre ingresado: " + input);

}
