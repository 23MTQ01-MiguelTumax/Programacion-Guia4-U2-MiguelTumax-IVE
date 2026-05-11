internal class Program
{
    private static void Main(string[] args)
    {
        int num, mult;
        num = 0;
        Console.WriteLine("FACTORIALES");

        do
        {
            Console.WriteLine();
            Console.WriteLine("Dime un número entero y te diré su factorial");
            Console.WriteLine("Límite 10");
            Console.Write("Número: ");
            num = int.Parse(Console.ReadLine());

            if (num >= 11)
            {
                Console.WriteLine("ERROR, CANTIDAD NO ACPETADA DEBIDO A QUE SU FACTORIAL ES DEMASIADO GRANDE.");
            }
            else
            {
                mult = 1;
                for (int i = 1; i <= num; i++)
                {
                    mult = mult * i;
                }
                Console.WriteLine(mult);
            }
        }
        while (num <= 10);
    }
}