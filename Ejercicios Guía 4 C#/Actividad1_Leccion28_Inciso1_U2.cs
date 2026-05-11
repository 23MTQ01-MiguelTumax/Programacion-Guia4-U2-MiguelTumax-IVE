using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        int strikes = 0;
        int dinero = 0;
        int total = 0;

        do
        {
            Console.WriteLine("Tienes " + strikes + " strike(s)");
            Console.WriteLine("Ingresa la cantidad de dinero ganada");
            dinero = int.Parse(Console.ReadLine());
            if (dinero == 0)
            {
                strikes++;
            }
            else
            {
                total += dinero;
            }
        }
        while (strikes <3);

        Console.WriteLine("Game Over");
    }
}