internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        num = 0;
        Console.WriteLine("Números impares de x número a 20");

        while (num <= 20)
        {
            Console.WriteLine("Dime un número del 1 al 20");
            Console.Write("Número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                for (int i = num + 1; i <= 20; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = num; i <= 20; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }

        Console.WriteLine("ERROR");
    }
}