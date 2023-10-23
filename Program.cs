using System;

class Program
{
    static void Main()
    {
        double num1, num2;

        Console.WriteLine("Ingrese el primer número: ");
        if (double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Ingrese el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out num2))
            {
                double mayor = EncontrarMayor(num1, num2);
                Console.WriteLine($"El número mayor es: {mayor}");
            }
            else
            {
                Console.WriteLine("El segundo número no es válido.");
            }
        }
        else
        {
            Console.WriteLine("El primer número no es válido.");
        }
    }

    static double EncontrarMayor(double a, double b)
    {
        return Math.Max(a, b);
    }
}
