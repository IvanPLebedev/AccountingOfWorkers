using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingOfWorkers.Data.interfaces;
using AccountingOfWorkers.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountingOfWorkers.Data.Repository
{
    public class WorkingDayRepository : IWorkingDays
    {
        private readonly AppDbContent appDbContent;

        public WorkingDayRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<WorkingDay> GetWorkingDays(int employeeId)
        {
            return appDbContent
                .WorkingDays
                .Where(d => d.EmployeeId == employeeId);
        }
    }
}
