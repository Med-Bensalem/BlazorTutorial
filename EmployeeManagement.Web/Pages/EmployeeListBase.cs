using EmployeeManagementModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
           
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Mohamed",
                LastName = "bensalem",
                Email = "bensalemmohamed70@gmail.com",
                DateOfBirth = new DateTime(2021, 12, 22),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "informatique" },
                PhotoPath = "images/john.png"


            };
            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Hatem",
                LastName = "Ghorbel",
                Email = "hatemghorbel@gmail.com",
                DateOfBirth = new DateTime(2021, 12, 22),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 2, DepartmentName = "Gestion" },
                PhotoPath = "images/sam.jpg"


            };
            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "sara",
                LastName = "jemli",
                Email = "sarajemli@gmail.com",
                DateOfBirth = new DateTime(2021, 12, 22),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 3, DepartmentName = "Mécanique" },
                PhotoPath = "images/sara.png"


            };
            Employees = new List<Employee> { e1, e2, e3 };
        }
    }
}
