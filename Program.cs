using System;
using System.Globalization;

namespace EjerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            bool salir = false;

            while (!salir)
            {
                MostrarMenu();
                string? opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": Ejercicio1_PositivePower(); break;
                    case "2": Ejercicio2_DoubleOrTriple(); break;
                    case "3": Ejercicio3_RootOrSquare(); break;
                    case "4": Ejercicio4_CirclePerimeter(); break;
                    case "5": Ejercicio5_MidweekDay(); break;
                    case "0":
                        salir = true;
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine(" EJERCICIOS DE FUNDAMENTOS DE PROGRAMACIÓN");
            Console.WriteLine("========================================");
            Console.WriteLine(" 1.  Positive Power");
            Console.WriteLine(" 2.  Double or Triple");
            Console.WriteLine(" 3.  Root or Square");
            Console.WriteLine(" 4.  Circle Perimeter");
            Console.WriteLine(" 5.  Midweek Day");
            Console.WriteLine(" 6.  Tax Calculator");
            Console.WriteLine(" 7.  Remainder Finder");
            Console.WriteLine(" 8.  Sum of Evens");
            Console.WriteLine(" 9.  Fraction Difference");
            Console.WriteLine("10.  String Length");
            Console.WriteLine("11.  Average of Four");
            Console.WriteLine("12.  Smallest of Five");
            Console.WriteLine("13.  Vowel Counter");
            Console.WriteLine("14.  Factorial Finder");
            Console.WriteLine("15.  InRange Validator");
            Console.WriteLine(" 0.  Salir");
            Console.WriteLine("========================================");
            Console.Write("Seleccione un ejercicio: ");
        }

        // Lee un entero de forma segura, repitiendo hasta que sea válido.
        static int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Entrada inválida. Ingrese un número entero: ");
            }
            return valor;
        }

        // Lee un número decimal de forma segura, repitiendo hasta que sea válido.
        static double LeerDouble(string mensaje)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
            {
                Console.Write("Entrada inválida. Ingrese un número: ");
            }
            return valor;
        }

        // 1. Positive Power
        // Pide un número y lo eleva al cuadrado solo si es positivo (o cero).
        static void Ejercicio1_PositivePower()
        {
            double numero = LeerDouble("Ingrese un número: ");

            if (numero >= 0)
            {
                Console.WriteLine($"Resultado: {numero * numero}");
            }
            else
            {
                Console.WriteLine("Resultado: Número negativo.");
            }
        }

        // 2. Double or Triple
        // Si el primer número es mayor o igual al segundo, devuelve su doble;
        // de lo contrario devuelve el triple del segundo.
        static void Ejercicio2_DoubleOrTriple()
        {
            double a = LeerDouble("Ingrese el primer número: ");
            double b = LeerDouble("Ingrese el segundo número: ");

            if (a >= b)
            {
                Console.WriteLine($"Resultado: {a * 2}");
            }
            else
            {
                Console.WriteLine($"Resultado: {b * 3}");
            }
        }

        // 3. Root or Square
        // Si el número es positivo devuelve su raíz cuadrada, si no, su cuadrado.
        static void Ejercicio3_RootOrSquare()
        {
            double numero = LeerDouble("Ingrese un número: ");

            if (numero > 0)
            {
                Console.WriteLine($"Resultado: {Math.Sqrt(numero)}");
            }
            else
            {
                Console.WriteLine($"Resultado: {numero * numero}");
            }
        }

        // 4. Circle Perimeter
        // Calcula el perímetro (circunferencia) de un círculo a partir del radio.
        static void Ejercicio4_CirclePerimeter()
        {
            double radio = LeerDouble("Ingrese el radio del círculo: ");
            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine($"Resultado: {Math.Round(perimetro, 2)}");
        }

        // 5. Midweek Day
        // Muestra el día de la semana correspondiente, solo para días laborables (1-5).
        static void Ejercicio5_MidweekDay()
        {
            int dia = LeerEntero("Ingrese un número entre 1 y 7: ");

            switch (dia)
            {
                case 1: Console.WriteLine("Resultado: Lunes"); break;
                case 2: Console.WriteLine("Resultado: Martes"); break;
                case 3: Console.WriteLine("Resultado: Miércoles"); break;
                case 4: Console.WriteLine("Resultado: Jueves"); break;
                case 5: Console.WriteLine("Resultado: Viernes"); break;
                default: Console.WriteLine("Resultado: Número fuera del rango laboral."); break;
            }
        }
    }
}
