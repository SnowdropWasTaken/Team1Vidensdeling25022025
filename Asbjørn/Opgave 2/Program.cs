namespace Opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast temperatur: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Er temperaturen i (C)elsius eller (F)ahrenheit?");
            string unit = Console.ReadLine().ToUpper();

            if (unit == "C")
            {
                double fahrenheit = CelsiusToFahrenheit(temperature);
                Console.WriteLine($"{temperature}°C er {fahrenheit}°F");
            }
            else if (unit == "F")
            {
                double celsius = FahrenheitToCelsius(temperature);
                Console.WriteLine($"{temperature}°F er {celsius}°C");
            }
            else
            {
                Console.WriteLine("Ugyldigt input");
            }
            Console.ReadLine();
        }
        
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        

    }
}