namespace Opgave_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal fra 1 til 7 og få en ugedag :-) : ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lørdag");
                    break;
                case 7:
                    Console.WriteLine("Søndag");
                    break;
                default:
                    Console.WriteLine("Ugyldigt tal");
                    break;
            }
            }
    }
}
