internal class Program
{
    private static void Main(string[] args)
    {
        int mult, acumulador, contador;
        acumulador = 0;
        contador = 0;
        Console.WriteLine("PRIMEROS 20 MÚLTIPLOS DE 7");

        for (int i = 1; i <= 20; i++)
        {
            mult = i * 7;
            acumulador = acumulador + mult;

            if (mult % 2 == 0)
            {
                contador = contador + 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine("La suma total de los primeros 20 múltiplos de 7 es de: " + acumulador);
        Console.WriteLine("Hay en total " + contador + " números pares");
    }
}