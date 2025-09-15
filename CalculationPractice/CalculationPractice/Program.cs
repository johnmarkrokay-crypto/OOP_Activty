using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWhat do you want to buy?, \n\n\t100 DISCOUNT, \n\n\tAnd also have a discount if you have an any ID");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("\nDo you have an any ID?\t\t");
            Console.Write("\tJersey 250     and     Sleeveless 150:\t\t");
            string choice = Console.ReadLine();

            if (choice == "Jersey")
            {
                Shirt jersey = new Jersey(250, 100, 50);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tJersey Price Discounted:\t" + jersey.PriceDiscount);
            }
            else if (choice == "Sleeveless")
            {
                Shirt sleeveless = new Sleeveless(150, 100, 50);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\tSleeveless Price Discounted:\t" + sleeveless.PriceDiscount);

            }

            Console.ReadKey();
        }
    }
}
