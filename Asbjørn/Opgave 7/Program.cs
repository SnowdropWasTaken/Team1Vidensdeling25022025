namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("Tallet er positivt");
            }
            else if (n == 0)
            {
                Console.WriteLine("Tallet er 0");
            }
            else
            {
                Console.WriteLine("Tallet er negativt");
            }
            Console.ReadLine();
        }
    }
}
