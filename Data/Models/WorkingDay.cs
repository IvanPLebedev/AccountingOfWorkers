using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountingOfWorkers.Data.Models
{
    public class WorkingDay
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public int HoursPrice { get; set; }
        public string Desc { get; set; }

        public int EmployeeId { get; set; }
        //public virtual Employee Employee { get; set; }
    }
}
