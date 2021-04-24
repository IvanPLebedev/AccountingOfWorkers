using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingOfWorkers.Data.interfaces;
using AccountingOfWorkers.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountingOfWorkers.Data.Repository
{
    public class EmployeeRepository:IEmployees
    {
        private readonly AppDbContent appDbContent;

        public EmployeeRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Employee> MyEmployees => appDbContent.Employees;
    }
}
