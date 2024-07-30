using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class studentifo
    {
        public int studentId { get; set; }  
        public string studentName { get; set; }

        public int marks1 { get; set; }

        public int marks2 { get; set; }

        public int marks3 { get; set; }

        public int total
        {
            get
            {
                return marks1 + marks2 + marks3;
            }


        }

        public float per
        {
            get
            {
               return (float)total/3;
            }
        }

    }
}
