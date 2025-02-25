namespace Opgave_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal du vil have fakulteten af");
            int x = Convert.ToInt32(Console.ReadLine());
            long result = Factorial(x);
            Console.WriteLine($"Fakulteten af {x} er: {result}");
            Console.ReadLine();
        }

        static long Factorial(int x)
        {
            if (x < 0)
                throw new ArgumentException("Indtastning skal være et positivt tal");
            if (x == 0 || x == 1)
                return 1;
            long factorial = 1;
            for (int i = 2; i <= x; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}