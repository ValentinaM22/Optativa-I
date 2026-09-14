# Ejercicios de Fundamentos de Programación — C# / .NET

Solución a los 15 ejercicios de la guía "Homework: Initial Programming C#",
implementados como un menú de consola en .NET 8.

## Ejercicios incluidos

1. Positive Power
2. Double or Triple
3. Root or Square
4. Circle Perimeter
5. Midweek Day
6. Tax Calculator
7. Remainder Finder
8. Sum of Evens
9. Fraction Difference
10. String Length
11. Average of Four
12. Smallest of Five
13. Vowel Counter
14. Factorial Finder
15. InRange Validator

## Cómo ejecutar

Requiere el [SDK de .NET 8](https://dotnet.microsoft.com/download) instalado.

```bash
cd EjerciciosCSharp
dotnet run
```

Aparecerá un menú en consola: escriba el número del ejercicio que desea
probar, ingrese los datos solicitados y presione ENTER para volver al menú.
Escriba `0` para salir.

## Estructura

- `Program.cs` — contiene el menú principal y un método independiente por
  cada ejercicio (`Ejercicio1_PositivePower`, `Ejercicio2_DoubleOrTriple`, …),
  además de dos utilidades (`LeerEntero`, `LeerDouble`) para validar la
  entrada del usuario.
- `EjerciciosCSharp.csproj` — archivo de proyecto (.NET 8, consola).

## Notas sobre la entrega

Recuerden que, según la guía de la actividad, además de este código deben:

- Subir el repositorio a GitHub mostrando su usuario, commits y branches
  del proceso (por ejemplo: un commit por cada 2-3 ejercicios, o un branch
  de desarrollo que luego se mezcla a `main`).
- Grabar un video explicando al menos 4 dificultades encontradas al resolver
  los ejercicios o al configurar el entorno.
- Entregar un documento con el enlace al video y al repositorio.
