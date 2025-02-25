namespace Opgave_17
{
    internal class Program
    {
        int x;
        int y;
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal der skal ligges sammen med et andet tal, som du skriver bagefter.");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Sum(x, y);
            Console.ReadLine();
        }

        static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
