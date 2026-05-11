internal class Program
{
    private static void Main(string[] args)
    {
        int mult;
        mult = 0;
        Console.WriteLine("Múltiplos de 4");
        Console.WriteLine("Presiona cualquier tecla para saber los primeros 20 múltiplos");
        Console.WriteLine();
        Console.ReadKey();

        for (int i = 1; i <= 20; i++)
        {
            mult = 4 * i;
            Console.WriteLine(mult);
        }

    }
}