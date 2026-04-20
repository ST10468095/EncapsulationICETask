using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationICE
{
    internal class Course
    {
        private int grade;


        public int Grade
        {
            get { return grade; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
                else
                {
                    Console.WriteLine("Invalid grade. must be between 0 and 100.");
                }
            }
        }


        public bool IsPass
        {
            get { return grade >= 50; }
        }
    }
}