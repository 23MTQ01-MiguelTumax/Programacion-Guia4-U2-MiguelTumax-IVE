internal class Program
{
    private static void Main(string[] args)
    {
        int contador1, contador2, contador3, contador4, acumulador_total;
        contador1 = 0;
        contador2 = 0;
        contador3 = 0;
        contador4 = 0;
        acumulador_total = 0;
        Console.WriteLine("Presiona cualquier tecla para saber la ganancia de hoy");
        Console.ReadKey();
        Console.WriteLine("------------------------------------------------------");

        for (int i = 1; i <= 100; i++)
        {
            contador1 = contador1 + 1;
            contador4 = contador4 + 20;
        }
        for (int i = 101; i <= 500; i++)
        {
            contador2 = contador2 + 1;
            contador4 = contador4 + 50;
        }
        for (int i = 501; i <= 1000; i++)
        {
            contador3 = contador3 + 1;
            contador4 = contador4 + 100;
        }

        acumulador_total = acumulador_total + contador4;

        Console.WriteLine("En total hay " + contador1 + " billetes de Q.20.00");
        Console.WriteLine("En total hay " + contador2 + " billetes de Q.50.00");
        Console.WriteLine("En total hay " + contador3 + " billetes de Q.100.00");
        Console.WriteLine("La ganancia total fue de : Q." + acumulador_total + ".00");
    }
}