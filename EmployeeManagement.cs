using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class EmployeeManagement
    {
        List<EmployeeInfo> employees;

        public EmployeeManagement()
        {
            employees= new List<EmployeeInfo>();    

        }



        public void AddEmployee(EmployeeInfo employeeInfo )
        {
            employees.Add( employeeInfo );  

        }

        public void Display()
        {
            foreach ( EmployeeInfo employee in employees )
            {

                Console.WriteLine( employee.FullName ); 
                Console.WriteLine(employee.EmployeeID);
            }
        }

    }
}
