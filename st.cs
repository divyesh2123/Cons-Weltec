using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class st
    {
        public List<studentifo> studentifos;
          
        public st()
        {
            studentifos = new List<studentifo>();

        }
        public void add(studentifo studentifo)
        {
            studentifos.Add(studentifo);
        }

        public void display()
        {
            foreach (studentifo studentifo in studentifos)
            {
                Console.WriteLine(studentifo.per);
                Console.WriteLine(studentifo.total);
                Console.WriteLine(studentifo.studentName);
            }
        }
    }
}
