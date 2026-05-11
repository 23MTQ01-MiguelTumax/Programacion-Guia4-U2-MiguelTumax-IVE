internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, mult;
        mult = 0;
        num1 = 0;
        num2 = 0;
        Console.WriteLine("Múltiplos de 4");

        do
        {
            Console.WriteLine();
            Console.Write("Dime un número entero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Dime otro número entero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num1 > num2)
            {
                Console.WriteLine("Múltplos entre " + num2 + " y " + num1 + ": ");
                for (int i = num2; i <= num1; i++)
                {
                    mult = 4 * i;
                    Console.WriteLine(mult);
                }
            }
            else
            {
                Console.WriteLine("Múltplos entre " + num1 + " y " + num2 + ": ");
                for (int i = num1; i <= num2; i++)
                {
                    mult = 4 * i;
                    Console.WriteLine(mult);
                }
            }
        }
        while (num1 > 0);
    }
}