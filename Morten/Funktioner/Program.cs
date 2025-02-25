using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Funktioner
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Opgave17(0, 0);
            //Opgave18();
            //Opgave19();
            //Opgave20();
            //Opgave21();
            //Opgave22();

        }

        static void Opgave17(int x, int y)
        {
            Console.WriteLine("Angiv to tal du vil addere." + "\n");
            Console.Write("Tal 1: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tal 2: ");
            y = Convert.ToInt32(Console.ReadLine());
            int result = x + y;
            Console.Write("Summen er: ");
            Console.WriteLine(result);
            Console.ReadKey();

        } // Opgave 17

        static void Opgave18()
        {
            string omvendtString = Opgave18A("");
            Console.WriteLine(omvendtString);
        } // Opgave 18
        public static string Opgave18A(string m) // Opgave 18
        {
            m = Console.ReadLine();
            char[] charsArray = m.ToCharArray();
            Array.Reverse(charsArray);
            return new string (charsArray);
        }
        static void Opgave19()
        {
            int antalVokaler = 0;
            var vokaler = new HashSet<object>{ 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Enter a Sentence");
            string userInput = Console.ReadLine().ToLower();

            for (int i = 0; i < userInput.Length; i++)
            {
                if (vokaler.Contains(userInput[i]))
                {
                    antalVokaler++;
                }
            }
            Console.WriteLine("Der er: {0}", antalVokaler + " vokal(er) i den indtastede sætning.");

            Console.ReadKey();

        } // Opgave 19

        static void Opgave20()
        {
            int intSide = 2;
            double doubleRadius = 2.5;
            Console.WriteLine("Arealet af rektanglen er (int): " + Opgave20udregning(intSide));
            Console.WriteLine("Arealet af rektanglen er (double): " + Opgave20udregning(doubleRadius));
            Console.ReadKey();
        } // Opgave 20

        static int Opgave20udregning(int side)
        {
            return side * side;
        } // Opgave 20
        static double Opgave20udregning(double radius)
        {
            return Math.PI * radius * radius;
        } // Opgave 20

        static void Opgave21()
        {
            int intSide = 4;
            double doubleRadius = 2.5;
            double doubleHeight = 5.5;
            Console.WriteLine("Kubens areal er (int): " + Opgave21udregning(intSide));
            Console.WriteLine("Cylinderens areal er (double): " + Opgave21udregning(doubleRadius, doubleHeight));
            Console.ReadKey();
        } // Opgave 21

        static int Opgave21udregning(int side)
        {
            return 6 * side * side;
        } //Opgave 21
        static double Opgave21udregning(double radius, double height)
        {
            return 2 * Math.PI * radius * (radius + height);
        } // Opgave 21

        static void Opgave22()
        {
            int intSide = 5;
            int intHeight = 5;
            double doubleSide = 4.9;
            double doubleHeight = 4.9;
            Console.WriteLine("Trianglens rumfang er (int): " + Opgave22udregning(intSide, intHeight));
            Console.WriteLine("Trianglens rumfang er (double): " + Opgave22udregning(doubleSide, doubleHeight));
            Console.ReadKey();
        }
        static double Opgave22udregning(int baseL, int height) // Opgave 22
        {
            return 0.5 * baseL * height;
        }
        static double Opgave22udregning(double baseL, double height) // Opgave 22
        {
            return 0.5 * baseL * height;
        }

    }
}
