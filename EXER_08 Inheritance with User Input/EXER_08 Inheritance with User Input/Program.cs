using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_08_Inheritance_with_User_Input
{
    internal class Program
    {
        //Name: John Mark R. Okay                     Section: IT306
        //Title:EXER_08: Inheritance with User Input

        static void Main(string[] args)
        {
            //User Input for Jersey or Sleevless
            Console.WriteLine("Enter the Shirt Details:");
            Console.WriteLine("Jersey or Sleeveless");
            Console.Write("Enter your choice(Jersey or Sleeveless):\t");
            string choice = Console.ReadLine();


            if (choice == "Jersey")
            {
                //Initiate object for Jersey
                Jersey jersey = new Jersey();

                //User Input fot Jersey
                Console.Write("\nEnter the Size    :");
                jersey.Size = Console.ReadLine();
                Console.Write("Enter the Brand   :");
                jersey.Brand = Console.ReadLine();
                Console.Write("Enter the Material:");
                jersey.Material = Console.ReadLine();
                Console.Write("Enter the Price   :");
                jersey.Price = Convert.ToInt32(Console.ReadLine());

                //Call method to display Jersey Information
                jersey.JerseyInfo();
            }
            else if (choice == "Sleeveless")
            {
                //Initaite object for Sleeveless
                Sleeveless sleeveless = new Sleeveless();

                //User Input for Sleeveless
                Console.Write("\nEnter the Size    :");
                sleeveless.Size = Console.ReadLine();
                Console.Write("Enter the Brand   :");
                sleeveless.Brand = Console.ReadLine();
                Console.Write("Enter the Quantity:");
                sleeveless.Quantity = Console.ReadLine();
                Console.Write("Enter the Color   :");
                sleeveless.Color = Console.ReadLine();

                //Call method to display Sleeveless Information
                sleeveless.SleevelessInfo();

                Console.ReadKey();
            }
        }
    }
}
