using System;
using CalculadoraOperaciones;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simple");
            Console.WriteLine("------------------");

            // Leer valores
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Mostrar opciones
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            int opcion = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = Suma.Calcular(num1, num2);
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case 2:
                    //resultado = Resta.Calcular(num1, num2);
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case 3:
                    //resultado = Multiplicacion.Calcular(num1, num2);
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;
                case 4:
                    try
                    {
                        //resultado = Division.Calcular(num1, num2);
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}