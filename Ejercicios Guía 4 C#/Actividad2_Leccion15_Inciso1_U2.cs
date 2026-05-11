internal class Program
{
    private static void Main(string[] args)
    {
        int contador, acumulador, divisores;
        contador = 0;
        acumulador = 0;

        Console.WriteLine("NÚMEROS PRIMOS DEL 1 AL 100");
        Console.WriteLine();
        for (int i = 2; i <= 100; i++)
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
                acumulador = acumulador + i;
            }
        }

        Console.WriteLine("En total hay "+contador+" números primos del 1 al 100");
        Console.WriteLine("La suma total de todos los números primos es de: "+acumulador);
    }
}