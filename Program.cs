using System;

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Calculadora");

            while (true)
            {
                Console.WriteLine("Elige una operación:");
                Console.WriteLine("1 - Sumar");
                Console.WriteLine("2 - Restar");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Calcular Porcentaje");
                Console.WriteLine("0 - Salir");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    Console.WriteLine("Adiós!");
                    break;
                }

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = Sumar();
                        break;
                    case 2:
                        result = Restar();
                        break;
                    case 3:
                        result = Multiplicar();
                        break;
                    case 4:
                        result = Dividir();
                        break;
                    case 5:
                        result = CalcularPorcentaje();
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        continue;
                }

                Console.WriteLine("El resultado es: " + result);
            }
        }

        static double Sumar()
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 + num2;
        }

        static double Restar()
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 - num2;
        }
//Aca es donde ya se aplica el principio de abierto en donde un codigo debe estar abierto para su extension (Agregando Multiplicacion, Division y Porcentaje)

        static double Multiplicar()
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 * num2;
        }

        static double Dividir()
        {
            Console.Write("Ingrese el dividendo: ");
            double dividendo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("No se puede dividir por cero.");
                return 0;
            }

            return dividendo / divisor;
        }

        static double CalcularPorcentaje()
        {
            Console.Write("Ingrese el valor total: ");
            double total = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el porcentaje (0-100): ");
            double porcentaje = Convert.ToDouble(Console.ReadLine());

            return (porcentaje / 100) * total;
        }
    }
}
