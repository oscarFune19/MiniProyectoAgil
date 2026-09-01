Console.WriteLine("=== CALCULADORA BÁSICA ===");

double numero1 = LeerNumero("Ingrese el primer número: ");
double numero2 = LeerNumero("Ingrese el segundo número: ");

Console.WriteLine();
Console.WriteLine("Seleccione una operación:");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.Write("Opción: ");

string? opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        Console.WriteLine($"Resultado: {numero1 + numero2}");
        break;

    case "2":
        Console.WriteLine($"Resultado: {numero1 - numero2}");
        break;

    case "3":
        Console.WriteLine($"Resultado: {numero1 * numero2}");
        break;

    case "4":
        if (numero2 == 0)
        {
            Console.WriteLine("Error: no se puede dividir entre cero.");
        }
        else
        {
            Console.WriteLine($"Resultado: {numero1 / numero2}");
        }

        break;

    default:
        Console.WriteLine("Opción no válida.");
        break;
}

static double LeerNumero(string mensaje)
{
    double numero;

    while (true)
    {
        Console.Write(mensaje);

        if (double.TryParse(Console.ReadLine(), out numero))
        {
            return numero;
        }

        Console.WriteLine("Entrada no válida. Ingrese un número.");
    }
}