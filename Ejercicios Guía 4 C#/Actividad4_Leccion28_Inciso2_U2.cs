internal class Program
{
    private static void Main(string[] args)
    {
        int acumulador, divisores, contador;
        acumulador = 0;
        contador = 0;

        Console.WriteLine("NÚMEROS PRIMOS");
        Console.WriteLine();

        for (int i = 300; i >= 1; i--)
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
                contador = contador + 1;
            }
            if (i % 2 == 0)
            {
                acumulador = acumulador + i;
            }
        }

        Console.WriteLine("Hay un total de " + contador + " números primos del 300 al 1");
        Console.WriteLine("La suma de todos los números pares es de: " + acumulador);
    }
}