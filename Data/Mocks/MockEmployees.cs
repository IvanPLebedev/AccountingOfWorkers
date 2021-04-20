using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingOfWorkers.Data.interfaces;
using AccountingOfWorkers.Data.Models;

namespace AccountingOfWorkers.Data.Mocks
{
    public class MockEmployees: IEmployees
    {
        private readonly List<Employee> _employees = new List<Employee>
        {
            new Employee(){Id = 1, FirstName = "1", Name = "Саня", PhoneNumber = "8 800 235 35 35"},
            new Employee(){Id = 2, FirstName = "2", Name = "Саня2", PhoneNumber = "8 800 235 35 35"},
        };

        public IEnumerable<Employee> MyEmployees => _employees;
    }
}
