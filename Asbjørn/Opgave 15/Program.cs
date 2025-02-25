namespace Opgave_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum of the first x numbers:
            Console.WriteLine("Indtast antallet af tal fra 1 du vil have lagt sammen: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = SumOfXNumbers(x);
            Console.WriteLine($"Summen af {x} tal i rækkefølge er: {result}");
            Console.ReadLine();
        }

        static int SumOfXNumbers(int x)
        {
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
