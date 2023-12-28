using System;

class Calculadora
{
    public static double SumarNum(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double RestarNum(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double MultiplicarNum(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double DividirNum(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;
        }
        else
        {
            return num1 / num2;
        }
    }

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");

            string opcionStr = Console.ReadLine();
            int opcion;

            if (!int.TryParse(opcionStr, out opcion))
            {
                Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
                continue;
            }

            if (opcion == 5)
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }

            Console.Write("Número 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            double num2 = double.Parse(Console.ReadLine());

                Func<double, double, double> operacion = null;

            switch (opcion)
            {
                case 1:
                    operacion = Calculadora.SumarNum;
                    break;
                case 2:
                    operacion = Calculadora.RestarNum;
                    break;
                case 3:
                    operacion = Calculadora.MultiplicarNum;
                    break;
                case 4:
                    operacion = Calculadora.DividirNum;
                    break;
             
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    continue;
            }

            double resultado = operacion(num1, num2);

            Console.WriteLine("Resultado: " + resultado);
        }
    }

    }
}
