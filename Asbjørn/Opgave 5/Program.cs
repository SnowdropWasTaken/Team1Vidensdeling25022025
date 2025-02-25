namespace Opgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast radius: ");

            double radius = Convert.ToDouble(Console.ReadLine());
            double areal = double.Pi * (radius*radius);  
            double omkreds = 2 * double.Pi * radius;

            Console.WriteLine("Area: " + areal + ", " + "Circumference: " + omkreds);
        }
    }
}
