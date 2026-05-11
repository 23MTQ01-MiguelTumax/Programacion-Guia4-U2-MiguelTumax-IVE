internal class Program
{
    private static void Main(string[] args)
    {
        int cupos, cupoTotal;
        cupos = 0;
        cupoTotal = 0;
        Console.WriteLine("ESTACIONAMIENTO ZONA 1");

        do
        {
            Console.WriteLine("Presione cualquier tecla para saber cuántos cupos quedan");
            Console.ReadKey();
            cupos = cupos + 50;
            cupoTotal = 200 - cupos;
            Console.WriteLine();
            Console.WriteLine(cupos + " cupos han sido ocupados, todavía quedan " + cupoTotal + " cupos.");
        }
        while (cupos <= 199);

        Console.WriteLine();
        Console.WriteLine("Ya no quedan cupos disponibles, intente más tarde");
    }
}