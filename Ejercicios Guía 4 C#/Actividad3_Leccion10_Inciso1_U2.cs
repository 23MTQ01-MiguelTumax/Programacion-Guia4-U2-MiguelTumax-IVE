using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int sum, divisores;
        sum = 0;
        Console.WriteLine("NÚMEROS PRIMOS");

        for (int i = 1; i <= 22; i++)
        {
            divisores = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    divisores = divisores + 1;
                }
            }
            if (divisores == 2)
            {
                sum = sum + i;
            }
        }
        Console.WriteLine("La suma de todos los números primos del 1 al 22 es de: "+sum);
    }
}