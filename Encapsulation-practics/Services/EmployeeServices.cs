using Encapsulation_practics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_practics.Services
{
    internal class EmployeeServices
    {
        public Employee[] employees { get; set; }

        public EmployeeServices()
        {
           employees = GetAllEmployees();

        }


        private Employee[] GetAllEmployees()
        {
            Employee employee1 = new()
            {
                Id = 1,
                Name = "Arzu",
                SurName = "Kerimli",
                Age = 25,
                Salary = 1200,
            };
            Employee employee2 = new()
            {
                Id = 2,
                Name = "Tehmine",
                SurName = "Abbasli",
                Age = 23,
                Salary = 1100,
            };
            Employee employee3 = new()
            {
                Id = 3,
                Name = "Sara",
                SurName = "Eliyeva",
                Age = 35,
                Salary = 1500,
            };
            Employee employee4 = new()
            {
                Id = 4,
                Name = "Emin",
                SurName = "Memmedov",
                Age = 45,
                Salary = 500,
            };

            return new Employee[] { employee1, employee2, employee3, employee4 };

        }

        public Employee[] GetSalaryEmployees(int startSalary, int endSalary)
        {
            return employees.Where(m => m.Salary > startSalary && m.Salary < endSalary).ToArray();
        }

    }
}
