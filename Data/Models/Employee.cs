using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountingOfWorkers.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        //public List<WorkingDay> Days { get; set; }
    }
}
