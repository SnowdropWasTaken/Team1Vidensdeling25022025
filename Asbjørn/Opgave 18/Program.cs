namespace Opgave_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et sætning: ");
            string userInput = Console.ReadLine();
            string reversedString = StringConversion(userInput);
            Console.WriteLine($"Omvendt sætning: {reversedString}");
            Console.ReadLine();
        }

        static string StringConversion(string userInput)
        {
            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}