namespace VarDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave1();
            //Opgave2();
            //Opgave3();
            //Opgave4();
            //Opgave5();
            //Opgave6();


        }

        public const double PI = 3.1415926535897931;

        static void Opgave1()
        {
            int age = 37;
            float height = 1.73f;
            double weight = 67.5;
            char initial = 'J';
            string name = "John Doe";
            bool isStudent = true;

            Console.Write("Age: " + age + ", Height: " + height + ", Weight" + weight + ", Initial: " + initial + ", Name: " + name + ", Is Student: " + isStudent);
        }
        public static void Opgave2()
        {
            Console.WriteLine("Hvor varmt er det i Celsius grader?: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = Opgave2A(celsius);
            Console.WriteLine("Konverteret til Fahrenheit, lyder temperaturen: " + fahrenheit + "F");
            Console.ReadKey();

            Console.WriteLine("Hvor varmt er det i Fahrenheit grader?: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = Opgave2B(fahrenheit);
            Console.WriteLine("Konverteret til Fahrenheit, lyder temperaturen: " + celsius + "F");
            Console.ReadKey();
        }
        public static double Opgave2A(double celsius)
        {
            {
                return ((celsius * 9) / 5) + 32;
            }
        } // Opgave 2
        private static double Opgave2B(double fahrenheit)
        {
            {
                return (fahrenheit - 32) * 5 / 9;
            }
        } // Opgave 2

        static void Opgave3()
        {
            double weight;
            Console.WriteLine("Vægt(kg)?: ");
            weight = Convert.ToDouble(Console.ReadLine());
            double height;
            Console.WriteLine("Højde(m)?: ");
            height = Convert.ToDouble(Console.ReadLine());

            double underVægt = 18.5;
            double normalVægt = 24.9;
            double overVægt = 29.9;
            double fedme = 30;
            double bmi = Convert.ToDouble(weight / (height * height));

            if (bmi <= 18.5)
            {
                Console.WriteLine("BMI er: " + bmi + ", og du er derfor undervægtig.");
            }
            else if (bmi > underVægt && bmi <= normalVægt)
            {
                Console.WriteLine("BMI er: " + ", og du er derfor normal vægt.");
            }
            else if (bmi > normalVægt && bmi <= overVægt)
            {
                Console.WriteLine("BMI er: " + bmi + ", og du er derfor overvægtig.");
            }
            else if (bmi > overVægt && bmi <= fedme)
            {
                Console.WriteLine("BMI er: " + bmi + ", og du er derfor fedme.");
            }
            else
            {
                Console.WriteLine("Der gik noget galt. Prøv igen.");
            }

        }

        static void Opgave4()
        {
            int x = 15;
            int y = 25;

            int sum = x + y;
            int difference = x - y;
            int product = x * y;
            int quotient = y / x;
            int remainder = y % x;

            Console.WriteLine("Sum: " + sum + ", Difference: " + difference + ", Product: " + product + ", Quotient: " + quotient + ", Remainder: " + remainder);


        }

        static void Opgave5()
        {
            double radius;
            double diameter;
            double areal;
            double omkreds;

            Console.Write("Indtast radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            diameter = 2 * radius;
            areal = PI * (radius * radius);
            omkreds = diameter * PI;

            Console.WriteLine("Areal: " + areal + ", Circumference: " + omkreds);
        }

        static void Opgave6()
        {
            int x = 10;
            int y = 5;

            bool equal = x == y;
            bool notEqual = x != y;
            bool greaterThan = x > y;
            bool lessThan = x < y;
            bool greaterEqual = x >= y;
            bool lessEqual = x <= y;

            Console.WriteLine("Is Equal: " + equal + ", Not Equal: " + notEqual + ", Is Greater: " + greaterThan + ", Is Less: " + lessThan + ", Is Greater or Equal: " + greaterEqual + ", Is Less or Equal: " + lessEqual);

        }
    
    }
}

