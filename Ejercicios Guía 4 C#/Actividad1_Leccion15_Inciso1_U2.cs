internal class Program
{
    private static void Main(string[] args)
    {
        int voletoNiño, voletoAdulto, costo1, costo2, acumuladorDinero, acumuladorVoletos, contador;
        acumuladorDinero = 0;
        acumuladorVoletos = 0;
        contador = 0;
        Console.WriteLine("RUEDA DE CHICAGO");

        do
        {
            Console.WriteLine();
            Console.WriteLine("¿Cuántos voletos de adulto quiere? ");
            Console.Write("Voletos: ");
            voletoAdulto = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántos voletos de niño quiere? ");
            Console.Write("Voletos: ");
            voletoNiño = int.Parse(Console.ReadLine());

            costo1 = voletoAdulto * 15;
            costo2 = voletoNiño * 10;

            acumuladorVoletos = acumuladorVoletos + voletoAdulto + voletoNiño;
            acumuladorDinero = acumuladorDinero + costo1 + costo2;

            contador = contador + 1;
        }
        while (contador != 5);

        Console.WriteLine();
        Console.WriteLine("Se acabo el tiempo de la atracción");
        Console.WriteLine("Los voletos total que se vendieron es de: " + acumuladorVoletos);
        Console.WriteLine("La ganancia total fue de: Q." + acumuladorDinero + ".00");
    }
}