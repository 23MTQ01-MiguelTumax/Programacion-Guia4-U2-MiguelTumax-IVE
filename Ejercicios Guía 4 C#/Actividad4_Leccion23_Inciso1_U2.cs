internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        num = 1;
        
        while (num > 0)
        {
            Console.WriteLine("Dime un número y te mostraré su tabla hasta el 10");
            Console.Write("Número: ");
            num = int.Parse(Console.ReadLine());

            if (num < 1)
            {
                Console.WriteLine("ERROR");
            }

            else 
            {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Digite 0 si quiere terminar el ciclo");
            Console.WriteLine("Sino digite cualquier otro número");
            num = int.Parse(Console.ReadLine());
            Console.Clear();
        }
    }
}