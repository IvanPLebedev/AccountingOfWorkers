using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingOfWorkers.Data.Models;

namespace AccountingOfWorkers.Data.interfaces
{
    interface IEmployees
    {
        IEnumerable<Employee> MyEmployees { get; }
    }
}
