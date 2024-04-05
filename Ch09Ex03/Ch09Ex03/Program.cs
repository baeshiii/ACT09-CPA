using System;

namespace Ch09Ex03
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);

        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }

        static double Divide(double param1, double param2)
        {
            if (param2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero");
            }
            return param1 / param2;
        }

        static void Main(string[] args)
        {
            ProcessDelegate process;

            Console.WriteLine("Enter 2 numbers separated with a comma:");
            string input = Console.ReadLine();
            string[] parts = input.Split(',');
            double param1 = Convert.ToDouble(parts[0]);
            double param2 = Convert.ToDouble(parts[1]);

            Console.WriteLine("Enter M to multiply or D to divide:");
            input = Console.ReadLine();

            if (input == "M")
                process = Multiply;
            else if (input == "D")
                process = Divide;
            else
            {
                Console.WriteLine("Invalid operation.");
                return;
            }

            try
            {
                double result = process(param1, param2);
                Console.WriteLine($"Result: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
