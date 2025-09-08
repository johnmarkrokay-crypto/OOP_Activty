using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_07Simple_Inheritance_with_Constructor
{
    internal class Student
    {
        public string name;
        public string program;


        public Student(string aName, string aProgram)
        {
            name = aName;
            program = aProgram;
        }

        public void BasicInfo()
        {
            Console.WriteLine("\n Student Information\n");
            Console.WriteLine("Name   :" + name);
            Console.WriteLine("Prpgram:" + program);
        }
    }
    class RegularStudent : Student
    {
        public string section;

        public RegularStudent(string aName, string aProgram, string aSection)
            : base(aName, aProgram)
        {

            name = aName;
            program = aProgram;
            section = aSection;
        }

        public void SectionEnrolled()
        {
            BasicInfo();
            Console.WriteLine("Section  :" + section);
        }
    }
    class IrregularStudent : Student
    {
        public string unitsEnrolled;

        public IrregularStudent(string aName, string aProgram, string aSection, string aUnitsEnrolled)
            : base(aName, aProgram)
        {

            unitsEnrolled = aUnitsEnrolled;


        }
        public void UnitsEnrolled()
        {
            BasicInfo();
            Console.WriteLine("Units Enrolled: " + unitsEnrolled);
        }
    }
}
