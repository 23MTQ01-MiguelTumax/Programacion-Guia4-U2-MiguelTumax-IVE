internal class Program
{
    private static void Main(string[] args)
    {
        int acumulador, divisores;
        acumulador = 0;

        for (int num = 2; num <= 50; num++)
        {
            divisores = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisores++;
                }
            }
            if (divisores == 2)
            {
                acumulador += num;
            }
        }
        Console.WriteLine("Suma de números primos del 1 al 50");
        Console.Write("La suma de todos los números primos es de: "+acumulador);
    }
}