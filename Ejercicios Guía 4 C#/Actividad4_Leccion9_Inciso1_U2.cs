internal class Program
{
    private static void Main(string[] args)
    {
        int num, mult;
        num = 1;
        mult = 0;

        Console.WriteLine("TABLAS DE MULTIPLICAR X NÚMERO");

        while (num > 0)
        {
            Console.Write("Dime un número: ");
            num = int.Parse(Console.ReadLine());

            if (num < 1)
            {
                Console.WriteLine("ERROR");
            }

            else 
            {
            for (int i = 1; i <= 10; i++)
            {
                mult = num * i;
                Console.WriteLine(num + " x " + i + " = " + mult);
            }
            }
        }
    }
}