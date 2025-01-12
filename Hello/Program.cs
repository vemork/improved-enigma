// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// variable declaration local Camel Case
int number;
int NumberImportant = 1;

// variable declaration constant Pascal Case
const float Pi = 3.14f;

// error naming convention
//int 1route;

float number6 = 1.23f;
double number1 = 1.23;
decimal number2 = 1.23m;

byte number3;
//console.writeline(number3); // error not initialized

System.Console.WriteLine(1 + 2); // 3
System.Console.WriteLine(number);

// Interpolación de cadenas

string name = "Alice";
int age = 30;

string message = $"Hola, mi nombre es {name} y tengo {age} años.";

Console.WriteLine(message);

// Implicit Type Conversion
byte b = 1; // 00000001
int i = b; // 00000000 00000000 00000000 00000001

int ii = 1;
byte bb = ii; // error

// Explicit Type Conversion (Casting)
int iii = 1;
byte bbb = (byte)iii;

// Non-Compatible Types
string s = "1";
int si = (int)s;

string sii = "1";
int j = Convert.ToInt32(sii);
int k = int.Parse(sii);

int x = 1000;
byte y = (byte)x; // 232 we lost bits of information

var number7 = "1234";
int number8 = Convert.ToInt32(number7);

var number9 = "1234";
byte number10 = Convert.ToByte(number9);
Console.WriteLine(number10); // error overflows exception, value was either too large or too small for an unsigned byte

try
{
    var number11 = "1234";
    byte number12 = Convert.ToByte(number11);
    Console.WriteLine(number12);
}
catch (Exception)
{
    Console.WriteLine("The number could not be converted to a byte.");
}

int ival = 1;
int ival2 = ival++; // ival2 = 1, ival = 2

int ival3 = 1;
int ival4 = ++ival3; // ival4 = 2, ival3 = 2



