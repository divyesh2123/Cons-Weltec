using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class EmployeeInfo
    {
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }    

        public string FullName
        {
            get
            {

                return FirstName + " "+ LastName;

            }
        }
    }
}
