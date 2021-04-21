using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingOfWorkers.Data.Models;

namespace AccountingOfWorkers.ViewModels
{
    public class EmployeesMyEmployeesViewModel
    {
        public IEnumerable<Employee> GetMyEmployees { get; set; }
    }
}
