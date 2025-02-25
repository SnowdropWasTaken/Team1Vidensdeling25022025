namespace Opgave_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i = 1;

            bool isEqual = i == 2;
            bool isNotEqual = i != 2;
            bool isGreaterThan = i > 2;
            bool isLessThan = i < 2;
            bool isGreaterThanOrEqual = i >= 2;
            bool isLessThanOrEqual = i <= 1;

            Console.WriteLine("Is equal: " + isEqual + ", " + "Is not equal: " + isNotEqual + ", " + "Is greater: " + isGreaterThan + ", " + "Is less: " + isLessThan + ", " + "Is greater or equal: " + isGreaterThanOrEqual + ", " + "Is less or equal: " + isLessThanOrEqual);
        }
    }
}
