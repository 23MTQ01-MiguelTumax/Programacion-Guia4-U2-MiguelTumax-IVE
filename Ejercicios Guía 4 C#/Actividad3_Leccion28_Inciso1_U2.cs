internal class Program
{
    private static void Main(string[] args)
    {
        int contador, acumulador, divisores;
        contador = 0;
        acumulador = 0;

        for (int num = 2; num <= 100; num++)
        {
            divisores = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisores ++;
                }
            }
            if (divisores == 2)
            {
                contador++;
                acumulador += num;
            }
        }
        Console.WriteLine("La cantidad de números primos que hay del 1 al 100 es: "+contador);
        Console.WriteLine("La suma total de estos números es de: "+acumulador);
    }
}