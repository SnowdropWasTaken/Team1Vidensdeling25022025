namespace Opgave_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv et årstal for at tjekke om det er et skudår: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Skudår");
                    }
                    else
                    {
                        Console.WriteLine("Ikke skudår");
                    }
                }
                else
                {
                    Console.WriteLine("Skudår");
                }
            }
            else
            {
                Console.WriteLine("Ikke skudår");
            }
            Console.ReadLine();
        }
    }
}
