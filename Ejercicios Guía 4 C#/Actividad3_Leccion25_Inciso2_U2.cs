internal class Program
{
    private static void Main(string[] args)
    {
        int num, suma;
        suma = 0;
        Console.WriteLine("SUMA ACUMULATIVA");
        Console.WriteLine("Ingresa números y los sumaré hasta que ingreses 9");

        do
        {
            Console.Write("Número: ");
            num = int.Parse(Console.ReadLine());

            if (num != 9)
            {
                suma = suma + num;
            }
        }
        while (num != 9);

        Console.WriteLine();
        Console.WriteLine("La suma total de números es de: " + suma);
    }
}