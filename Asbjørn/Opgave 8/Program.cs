namespace Opgave_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvad fik du i karakter; A B C D eller F?");
            String karakter = Console.ReadLine();

            if (karakter == "F")
            {
            Console.WriteLine("Du er ikke bestået");
            }
            else
            {
            Console.WriteLine("Du er bestået");
            }
            Console.ReadLine();

        }
    }
}
