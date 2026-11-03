using System;
using System.Globalization;

// Group the shipping application classes together.
namespace BranchingAssignment
{
    internal class Program
    {
        // Run the quote workflow, ending immediately when a limit is exceeded.
        private static void Main()
        {
            // Display the required welcome message before any other output.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Read the weight and reject packages weighing more than 50.
            decimal weight = ReadPositiveNumber("Please enter the package weight:");
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Request each dimension in the required order.
            decimal width = ReadPositiveNumber("Please enter the package width:");
            decimal height = ReadPositiveNumber("Please enter the package height:");
            decimal length = ReadPositiveNumber("Please enter the package length:");

            // Reject the package if the sum of its dimensions exceeds 50.
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate the quote by multiplying dimensions and weight, then dividing by 100.
            decimal quote = width * height * length * weight / 100m;

            // Display a dollar sign and exactly two decimal places, then thank the user.
            Console.WriteLine("Your estimated total for shipping this package is: $" +
                quote.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Thank you!");
        }

        // Keep prompting until the user enters a positive numeric measurement.
        private static decimal ReadPositiveNumber(string prompt)
        {
            while (true)
            {
                // Show the prompt and collect one line of input.
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                // Exit gracefully if no more console input is available.
                if (input == null)
                {
                    Environment.Exit(0);
                }

                // Accept positive whole numbers or decimals using a period as the decimal separator.
                decimal value;
                if (decimal.TryParse(input, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
                    CultureInfo.InvariantCulture, out value) && value > 0)
                {
                    return value;
                }

                // Explain invalid input and repeat the same measurement prompt.
                Console.WriteLine("Please enter a positive number (use a period for decimals).");
            }
        }
    }
}
