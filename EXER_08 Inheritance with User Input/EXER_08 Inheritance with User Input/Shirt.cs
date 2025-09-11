using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_08_Inheritance_with_User_Input
{
    internal class Shirt // Base Class
    {
        //Fields
        private string size; 
        private string brand;

        //Properties
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        //Properties
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        //Methods to display
        public void ShirtInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nShirt Details:");
            Console.WriteLine("Size              :" + size);
            Console.WriteLine("Brand             :" + brand);
        }
    }

    class Jersey : Shirt // Derived Class (child)
    {
        //Fields
        private string material;
        private int price;

        //Public property for Material
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        //Public property for Price
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        //Method to display for Derived class
        public void JerseyInfo()
        {
            ShirtInfo();
            Console.WriteLine("Materials used    :" + material);
            Console.WriteLine("Price             :" + price);
        }
    }
    class Sleeveless : Shirt //Another Derived class (child)
    {
        //Fields
        private string quantity;
        private string color;

        //Public property for Quantity
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        //Public property for Color
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        //Method to display for Derived class
        public void SleevelessInfo()
        {
            ShirtInfo();
            Console.WriteLine("Quantity           :" + quantity);
            Console.WriteLine("Color              :" + color);
        }
    }
}
