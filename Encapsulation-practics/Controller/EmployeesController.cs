using Encapsulation_practics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_practics.Controller
{
    internal class EmployeesController
    {
        private EmployeeServices employeeServices;
        public EmployeesController()
        {
            employeeServices = new EmployeeServices();
        }
        public void EmployeeSalary()
        {
      
            var result = employeeServices.GetSalaryEmployees(1000, 2000);
            foreach (var employee in result)
            {
                Console.WriteLine($"{employee.Name}-{employee.SurName}-{employee.Id}-{employee.Age}-{employee.Salary}");
            }

        }

    }
    }

