using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();

            course.Grade = 80;

            Console.WriteLine("Grade: " + course.Grade);
            Console.WriteLine("Passed: " + course.IsPass);
        }
    }
}
