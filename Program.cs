using System;
using static System.Console;

namespace BonusApp
{
    class Program
    {
        static string buildHeader()
        {
            string result = string.Empty;
            result += string.Format("**************************************************\n");
            result += string.Format("\tBonus\n");
            result += string.Format("\tCalculate bonus for sales employees\n");
            result += string.Format("\tMatthew Obert\n");
            result += string.Format("\t{0}\n", DateTime.Now.ToString("MMMM dd yyyy"));
            result += string.Format("**************************************************\n");
            result += string.Format("This program will determine bonus for employees.\n\n");
            result += string.Format("You will be asked to enter sales name, sales,\n");
            result += string.Format("and employee code.\n\n");
            result += string.Format("**************************************************\n");

            return result;
        }
        static void Main(string[] args)
        {
            string inputValue;
            double sales;
            char code;

            // Display the header
            Write(buildHeader());

            // instantiate object by calling Bonus constructor method
            Bonus aBonus = new Bonus();

            // Get some values from the user interactively
            Write("Enter salesperson name: ");
            aBonus.SalespersonName = ReadLine();
            Write("Enter sales amount (in dollars): ");
            inputValue = ReadLine();
            // Validate input before attempting to cast string to double
            while (!double.TryParse(inputValue, out sales))
            {
                Write("System.FormatException: 'Input string was not in a correct format.'\n");
                Write("Enter sales amount (in dollars): ");
                inputValue = ReadLine();
            }
            aBonus.SalesAmount = sales;
            Write("Enter sales code (1, 2, 3, or 4 only): ");
            inputValue = ReadLine();
            // Validate input before attempting to cast string to char
            while (!char.TryParse(inputValue, out code))
            {
                Write("Value out of range.'\n");
                Write("Enter sales code (1, 2, 3, or 4 only): ");
                inputValue = ReadLine();
            }
            aBonus.SalesCode = char.Parse(inputValue);

            // generate output
            WriteLine("\n**************************************************\n");
            WriteLine(aBonus.ToString());
            ReadLine();
        }
    }
}
