using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Manager 
    {
        public decimal CalculateSalary()
        {
            Employee[] employees = {
            new Employee("Islam", 3000),
            new Employee("Ahmed", 3500),
            new Employee("Fawaz", 4000)
        };

            decimal salary = 0;
            foreach (var employee in employees)
            {
                salary += employee.Salary;
            }

            return salary;
        }
    }
}
