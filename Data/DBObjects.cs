using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingOfWorkers.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AccountingOfWorkers.Data
{
    public class DBObjects
    {
        public static void Initial(IApplicationBuilder applicationBuilder)
        {
            using var scope = applicationBuilder.ApplicationServices.CreateScope();
            AppDbContent content = scope
                .ServiceProvider
                .GetRequiredService<AppDbContent>();

            if (!content.Employees.Any())
                content.Employees.AddRange(Employees.Select(e => e.Value));
            if (!content.WorkingDays.Any())
                content.WorkingDays.AddRange(
                    new WorkingDay()
                    {
                        Date = DateTime.Today, EmployeeId = 1, Hours = 4, HoursPrice = 100,
                        Desc = "Посевная"
                    },
                    new WorkingDay()
                    {
                        Date = DateTime.Today,
                        EmployeeId = 2,
                        Hours = 5,
                        HoursPrice = 50,
                        Desc = "Посевная"
                    },
                    new WorkingDay()
                    {
                        Date = DateTime.Today,
                        EmployeeId = 1,
                        Hours = 4,
                        HoursPrice = 100,
                        Desc = "Посевная"
                    },
                    new WorkingDay()
                    {
                        Date = DateTime.Today,
                        EmployeeId = 2,
                        Hours = 4,
                        HoursPrice = 100,
                        Desc = "Посевная"
                    },
                    new WorkingDay()
                    {
                        Date = DateTime.Today,
                        EmployeeId = 1,
                        Hours = 6,
                        HoursPrice = 100,
                        Desc = "Посевная"
                    },
                    new WorkingDay()
                    {
                        Date = DateTime.Today,
                        EmployeeId = 2,
                        Hours = 7,
                        HoursPrice = 100,
                        Desc = "Посевная"
                    },
                    new WorkingDay()
                    {
                        Date = DateTime.Today,
                        EmployeeId = 1,
                        Hours = 8,
                        HoursPrice = 100,
                        Desc = "Посевная"
                    }
                );
            content.SaveChanges();
        }

        private static Dictionary<string, Employee> employees;
        public static Dictionary<string, Employee> Employees
        {
            get
            {
                if (employees == null)
                {
                    var _employees = new List<Employee>
                    {
                        new Employee(){FirstName = "1", Name = "Саня", PhoneNumber = "8 800 235 35 35"},
                        new Employee(){FirstName = "2", Name = "Саня2", PhoneNumber = "8 800 235 35 35"},
                        new Employee(){FirstName = "2", Name = "Саня4", PhoneNumber = "8 800 235 35 35"},
                        new Employee(){FirstName = "2", Name = "Саня6", PhoneNumber = "8 800 235 35 35"},
                        new Employee(){FirstName = "2", Name = "Саня7", PhoneNumber = "8 800 235 35 35"},
                        new Employee(){FirstName = "2", Name = "Саня8", PhoneNumber = "8 800 235 35 35"},
                    };

                    employees = new Dictionary<string, Employee>();
                    foreach (var employee in _employees)
                        employees.Add(employee.Name, employee);
                }

                return employees;
            }
        }
    }
}
