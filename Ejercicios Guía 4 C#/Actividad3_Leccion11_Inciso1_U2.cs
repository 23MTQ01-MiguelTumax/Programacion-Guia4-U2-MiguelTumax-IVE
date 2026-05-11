using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, sum;
        Console.WriteLine("SUMAS");
        do
        {
            Console.WriteLine();
            Console.Write("Dime un número entero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Dime otro número entero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                sum = 0;
                for (int i = num2; i <= num1; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine();
                Console.WriteLine("La suma total de enteros entre " + num2 + " y " + num1 + " es de: "+sum);
            }
            else
            {
                sum = 0;
                for (int i = num1; i <= num2; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine();
                Console.WriteLine("La suma total de enteros entre " + num1 + " y " + num2 + " es de: " + sum);
            }
        }
        while (num1 > 0);
    }
}