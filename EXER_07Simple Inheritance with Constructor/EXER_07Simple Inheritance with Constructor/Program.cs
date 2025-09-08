using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_07Simple_Inheritance_with_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegularStudent regstud = new RegularStudent("Okay", "BSIT", "IT306");
            regstud.SectionEnrolled();


            IrregularStudent irregstud = new IrregularStudent("John Mar Baculad", "BSIT", "", "19 units");
            irregstud.UnitsEnrolled();
            Console.ReadKey();
        }
    }
}
