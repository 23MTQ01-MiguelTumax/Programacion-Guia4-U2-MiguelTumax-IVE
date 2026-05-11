internal class Program
{
    private static void Main(string[] args)
    {
        int num, acumulador;
        acumulador = 0;
        Console.WriteLine("Dime un número mayor a 1");
        Console.Write("Número: ");
        num = int.Parse(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            for (int i = num; i >= 1; i--)
            {
                Console.WriteLine(i);
                acumulador += i;
            }
            Console.WriteLine();
            Console.WriteLine("La suma de todos los números enteros es de: "+acumulador);
        }
    }
}