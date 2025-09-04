using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Activity_1_Using_Control_Flow_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("\tIdentifying if you're in a Range, or out of the Range or in a Negative Side Range\t");
            Console.WriteLine("\tEnter a number that range 0 to 20 only \n");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 20)
            {
                Console.WriteLine("\tThe number you input is out of the range");
            }
            else if (num < 0)
            {
                Console.WriteLine("\tOut of the range on negative side");
            }
            else
            {
                Console.WriteLine("\tThe number you input is on the range");
            }
            Console.ReadKey();
        }
    }
}
