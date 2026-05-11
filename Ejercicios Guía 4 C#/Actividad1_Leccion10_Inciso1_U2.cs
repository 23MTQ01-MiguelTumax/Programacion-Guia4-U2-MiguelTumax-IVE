internal class Program
{
    private static void Main(string[] args)
    {
        int contador;
        contador = 0;
        Console.WriteLine("CORTE DE CABELLO");

        for (int i = 1; i <= 8; i++)
        {
            Console.WriteLine("Presione cualquier tecla para marca el sello "+i);
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Sello " + i + " de 8");
            Console.WriteLine();
        }

        Console.WriteLine("FELICIDADES!!!");
        Console.WriteLine("Tienes un corte de cabello gratis");
    }
}