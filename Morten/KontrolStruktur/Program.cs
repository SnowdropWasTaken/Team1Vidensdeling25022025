namespace KontrolStruktur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave7();
            //Opgave8();
            //Opgave9();
            //Opgave10();
            //Opgave11();
            //Opgave12();
            //Opgave13();
            //Opgave14();
            //Opgave15();
            //Opgave16();
        }



        static void Opgave7()
        {
            Console.Write("Indtast et tal: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Tallet er positivt (true).");
            }
            else if (number < 0)
            {
                Console.WriteLine("Tallet er negativt (false).");
            }
            else
            {
                Console.WriteLine("Tallet er nul.");
            }
        }

        static void Opgave8()
        {
            Console.Write("Indtast karakter (A-F): ");
            char grade = Convert.ToChar(Console.ReadLine());

            if (grade >= 'A' && grade <= 'D')
            {
                Console.WriteLine("Bestået");
            }
            else
            {
                Console.WriteLine("Ikke bestået");
            }

        }

        static void Opgave9()
        {
            Console.Write("Indtast et årstal: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = false;

            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 400 == 0)
                {
                    isLeapYear = true;
                }
            }

            if (isLeapYear)
            {
                Console.WriteLine("Året: " + year + " er et skudår.");
            }
            else
            {
                Console.WriteLine("Året: " + year + " er ikke et skudår.");
            }
        }

        static void Opgave10()
        {
            Console.Write("Vælg en ugedag (1-7): ");
            int i = int.Parse(Console.ReadLine());
            switch (i)
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
                    Console.WriteLine("Vælg en korrekt ugedag.");
                    break;
            }

        }

        static void Opgave11()
        {
            Console.Write("Vælg en måned (1-12): ");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Januar");
                    break;
                case 2:
                    Console.WriteLine("Februar");
                    break;
                case 3:
                    Console.WriteLine("Marts");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Juni");
                    break;
                case 7:
                    Console.WriteLine("Juli");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Vælg en korrekt måned.");
                    break;
            }

        }

        static void Opgave12()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Opgave13()
        {
            int i = 0;
            while (i <= 10)
                Console.WriteLine(i++);

        }

        static void Opgave14()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i++);
            }
            while (i <= 10);
        }

        static void Opgave15()
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                sum += i;
            }
            Console.WriteLine("Summen af de første fem tal er: " + sum);
            sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Den totale sum er: " + sum);
        }

        static void Opgave16()
        {
            Console.Write("Indtast et tal for at beregne fakultet: ");
            int number = int.Parse(Console.ReadLine());
            long fakultet = CalcFakultet(number);
            Console.WriteLine("Fakultet af " + number + ", er " + fakultet);
        }

        static long CalcFakultet(int number)
        {
            if (number < 0)
                throw new ArgumentException("Tallet skal være positivt.");

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        } // Opgave 16

    }
}
