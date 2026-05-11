
internal class Program
{
    private static void Main(string[] args)
    {
        int monedas;
        monedas = 0;
        Console.WriteLine("NIVEL 5");

        while (monedas <= 350)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Dime cuántas monedas tiene y te diré si pasaste de nivel");
            Console.Write("Monedas: ");
            monedas = int.Parse(Console.ReadLine());

            if (monedas <= 350 && monedas >= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Todavía no has pasado de nivel");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("FELICIDADES!!!");
                Console.WriteLine("Pasaste de nivel");
            }
        }
    }
}