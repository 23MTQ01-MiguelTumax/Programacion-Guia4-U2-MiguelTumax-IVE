internal class Program
{
    private static void Main(string[] args)
    {
        int num, divisores;
        num = 1;
        Console.WriteLine("¿Número primo o no?");

        while (num > 0)
        {
            divisores = 0;
            Console.WriteLine();
            Console.Write("Dime un número: ");
            num = int.Parse(Console.ReadLine());
            
            if (num <= 1)
            {
                Console.WriteLine("Ingresa un número dentro del rango.");
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        divisores = divisores + 1;
                    }
                }
                if (divisores == 2)
                {
                    Console.WriteLine("Es un número primo");
                }
                else
                {
                    Console.WriteLine("No es un número primo");
                }
            }
        }
    }
}