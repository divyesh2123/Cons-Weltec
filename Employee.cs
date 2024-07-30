using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee
    {
        public int employeeId=0;
        string firstName;

        public Employee(int employeeId,string firstName)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
        }
        public Employee()
        {
            employeeId = 1;
            firstName = "";
        }

        public void input()
        {
            Console.WriteLine("Please Enter EmployeeId");
            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter FirstName");

            firstName = Console.ReadLine(); 

        }

        public void Output()
        {
            Console.WriteLine("employeeId"+employeeId);
            Console.WriteLine("name"+firstName);
        }
    }
}
    