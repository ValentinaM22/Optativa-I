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
                    case "6": Ejercicio6_TaxCalculator(); break;
                    case "7": Ejercicio7_RemainderFinder(); break;
                    case "8": Ejercicio8_SumOfEvens(); break;
                    case "9": Ejercicio9_FractionDifference(); break;
                    case "10": Ejercicio10_StringLength(); break;
                    case "11": Ejercicio11_AverageOfFour(); break;
                    case "12": Ejercicio12_SmallestOfFive(); break;
                    case "13": Ejercicio13_VowelCounter(); break;
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

        // 6. Tax Calculator
        // Si el salario anual excede 12000, calcula el 15% del excedente como impuesto.
        static void Ejercicio6_TaxCalculator()
        {
            double salario = LeerDouble("Ingrese su salario anual: ");

            if (salario > 12000)
            {
                double impuesto = (salario - 12000) * 0.15;
                Console.WriteLine($"Resultado: {impuesto}");
            }
            else
            {
                Console.WriteLine("Resultado: No debe impuestos.");
            }
        }

        // 7. Remainder Finder
        // Muestra el residuo de la división del primer número entre el segundo.
        static void Ejercicio7_RemainderFinder()
        {
            int a = LeerEntero("Ingrese el primer número: ");
            int b = LeerEntero("Ingrese el segundo número: ");

            if (b == 0)
            {
                Console.WriteLine("Resultado: No se puede dividir entre 0.");
                return;
            }

            Console.WriteLine($"Resultado: {a % b}");
        }

        // 8. Sum of Evens
        // Calcula la suma de los números pares entre 1 y 50.
        static void Ejercicio8_SumOfEvens()
        {
            int suma = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine($"Resultado: {suma}");
        }

        // 9. Fraction Difference
        // Pide dos fracciones (numerador/denominador cada una) y muestra su diferencia
        // simplificada.
        static void Ejercicio9_FractionDifference()
        {
            Console.WriteLine("Primera fracción:");
            int num1 = LeerEntero("  Numerador: ");
            int den1 = LeerEntero("  Denominador: ");

            Console.WriteLine("Segunda fracción:");
            int num2 = LeerEntero("  Numerador: ");
            int den2 = LeerEntero("  Denominador: ");

            if (den1 == 0 || den2 == 0)
            {
                Console.WriteLine("Resultado: El denominador no puede ser 0.");
                return;
            }

            // (num1/den1) - (num2/den2) = (num1*den2 - num2*den1) / (den1*den2)
            int numResultado = num1 * den2 - num2 * den1;
            int denResultado = den1 * den2;

            if (numResultado == 0)
            {
                Console.WriteLine("Resultado: 0");
                return;
            }

            int divisor = MaximoComunDivisor(Math.Abs(numResultado), Math.Abs(denResultado));
            numResultado /= divisor;
            denResultado /= divisor;

            // Mantener el signo negativo en el numerador, no en el denominador.
            if (denResultado < 0)
            {
                denResultado = -denResultado;
                numResultado = -numResultado;
            }

            Console.WriteLine($"Resultado: {numResultado}/{denResultado}");
        }

        static int MaximoComunDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a == 0 ? 1 : a;
        }

        // 10. String Length
        // Muestra la longitud de una palabra ingresada por el usuario.
        static void Ejercicio10_StringLength()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine() ?? string.Empty;

            Console.WriteLine($"Resultado: {palabra.Length}");
        }

        // 11. Average of Four
        // Pide cuatro números y muestra su promedio.
        static void Ejercicio11_AverageOfFour()
        {
            double n1 = LeerDouble("Ingrese el primer número: ");
            double n2 = LeerDouble("Ingrese el segundo número: ");
            double n3 = LeerDouble("Ingrese el tercer número: ");
            double n4 = LeerDouble("Ingrese el cuarto número: ");

            double promedio = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine($"Resultado: {promedio}");
        }

        // 12. Smallest of Five
        // Pide cinco números y muestra el más pequeño.
        static void Ejercicio12_SmallestOfFive()
        {
            double n1 = LeerDouble("Ingrese el 1er número: ");
            double n2 = LeerDouble("Ingrese el 2do número: ");
            double n3 = LeerDouble("Ingrese el 3er número: ");
            double n4 = LeerDouble("Ingrese el 4to número: ");
            double n5 = LeerDouble("Ingrese el 5to número: ");

            double menor = Math.Min(n1, Math.Min(n2, Math.Min(n3, Math.Min(n4, n5))));
            Console.WriteLine($"Resultado: {menor}");
        }

        // 13. Vowel Counter
        // Pide una palabra y cuenta el número de vocales que contiene.
        static void Ejercicio13_VowelCounter()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = (Console.ReadLine() ?? string.Empty).ToLower();

            int contador = 0;
            string vocales = "aeiouáéíóú";

            foreach (char c in palabra)
            {
                if (vocales.Contains(c))
                {
                    contador++;
                }
            }

            Console.WriteLine($"Resultado: {contador}");
        }
    }
}
