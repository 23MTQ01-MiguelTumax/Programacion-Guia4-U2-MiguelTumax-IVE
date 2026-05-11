internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Impares del 1 al 100");

        Thread.Sleep(2000);
        do
        {
            for (int i = 1; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Digite 0 si desea continuar, sino digite cualquier otro número para salir");
            num = int.Parse(Console.ReadLine());
        }
        while (num == 0);
    }
}