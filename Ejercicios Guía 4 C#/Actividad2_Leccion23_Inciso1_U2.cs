internal class Program
{
    private static void Main(string[] args)
    {
        int monedas, total;
        monedas = 0;
        Console.WriteLine("NIVEL 5");

        while (monedas <= 349)
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese cuántas monedas tiene");
            Console.Write("Monedas: ");
            monedas = int.Parse(Console.ReadLine());

            if (monedas <= 349)
            {
                Console.WriteLine();
                total = 350 - monedas;
                Console.WriteLine("MONEDAS INSUFICIENTES.");
                Console.WriteLine("Le faltan "+total+" monedas para subir de nivel");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("FELICIDADES!!!!");
                Console.WriteLine("Has subido de nivel");
            }
        }
    }
}