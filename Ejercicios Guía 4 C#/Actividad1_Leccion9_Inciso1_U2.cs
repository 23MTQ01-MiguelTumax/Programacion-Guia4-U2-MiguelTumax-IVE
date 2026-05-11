internal class Program
{
    private static void Main(string[] args)
    {
        double pesoAcumulado, pesoManzana, contador;
        contador = 0;
        pesoAcumulado = 0;
        pesoManzana = 0;
        Console.WriteLine("Báscula del mercado");

        while (pesoAcumulado < 1000)
        {
            Console.WriteLine("Ingrese el peso de la manzana. Límite (100 - 300 gramos)");
            pesoManzana = double.Parse(Console.ReadLine());

            if (pesoManzana >= 100 && pesoManzana <= 300)
            {
                pesoAcumulado += pesoManzana;
                Console.WriteLine("El peso acumulado es de: " + pesoAcumulado + " gramos");

                contador ++;
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        Console.WriteLine("1000 gramos alcanzados, ya tiene " + pesoAcumulado / 1000 + " kilos de manzana.");
        Console.WriteLine("Total de manzanas: " + contador);
    }
}