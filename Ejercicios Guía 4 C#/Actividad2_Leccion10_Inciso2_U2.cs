internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        num = 0;
        Console.WriteLine("ENTEROS PARES DESDE 2 A X NÚMERO");
        Console.WriteLine("Dime un número mayor a 2");
        Console.Write("Número: ");
        num = int.Parse(Console.ReadLine());

        if (num < 2)
        {
            Console.WriteLine("INGRESA UN NÚMERO DENTRO DEL RANGO");
        }
        else {
        for (int i = 2; i <= num; i = i +2)
        {
            Console.WriteLine(i);
        }
        }
    }
}