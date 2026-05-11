internal class Program
{
    private static void Main(string[] args)
    {
        int num, resultado;
        num = 1;
        while (num > 0)
        {
            Console.WriteLine("Dime un número y te mostraré sus primeros 20 múltiplos");
            Console.Write("Número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (num < 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                for (int i = 1; i < 21; i++)
                {
                    resultado = num * i;
                    Console.WriteLine("Múltiplo " + i + " : " + resultado);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Digite 0 si desea terminar el ciclo");
            Console.WriteLine("Sino digite cualquier otro número");
            num = int.Parse(Console.ReadLine());
            Console.Clear();
        }
    }
}