using System; // Provides console input and output.
using System.Globalization; // Provides consistent currency formatting.

class Program
{
    static void Main()
    {
        // Display the welcome message as the first line of output.
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask for the package weight and convert the input to a decimal.
        Console.WriteLine("Please enter the package weight:");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // End the program if the package exceeds the weight limit.
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Ask for the package width and convert the input to a decimal.
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Ask for the package height and convert the input to a decimal.
        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Ask for the package length and convert the input to a decimal.
        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // End the program if the sum of the dimensions exceeds 50.
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the shipping quote using the dimensions and weight.
        decimal quote = (height * width * length * weight) / 100m;

        // Display the quote with a dollar sign and two decimal places.
        Console.WriteLine(
            $"Your estimated total for shipping this package is: {quote.ToString("C2", CultureInfo.GetCultureInfo("en-US"))}");

        // Thank the user after displaying the quote.
        Console.WriteLine("Thank you!");
    }
}
