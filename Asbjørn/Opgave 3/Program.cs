using System;

namespace Opgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast din højde i meter: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast vægt i kilogram: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            static double CalculateBMI(double height, double weight)
            {
                double bmi = weight / (height * height);
                Console.WriteLine("BMI: " + bmi);

                return bmi;
            }

            double bmi = CalculateBMI(height, weight);

            if (bmi >= 30)
            {
                Console.WriteLine("Du er svært overvægtig");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine("Du er overvægtig");
            }
            else if (bmi >= 18.5)
            {
                Console.WriteLine("Du har normalvægt");
            }
            else
            {
                Console.WriteLine("Du er undervægtig");
            }
            Console.ReadLine();

        }
    }
}
