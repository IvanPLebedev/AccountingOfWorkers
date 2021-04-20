using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingOfWorkers.Data.interfaces;
using AccountingOfWorkers.Data.Models;

namespace AccountingOfWorkers.Data.Mocks
{
    public class MockWorkingDays: IWorkingDays
    {
        private readonly List<WorkingDay> _workingDays = new List<WorkingDay>
        {
            new WorkingDay(){Id = 1, Date = DateTime.Today, EmployeeId = 1, Hours = 4, HoursPrice = 100, Desc = "Посевная"},
            new WorkingDay(){Id = 2, Date = DateTime.Today, EmployeeId = 2, Hours = 5, HoursPrice = 50, Desc = "Посевная"},
            new WorkingDay(){Id = 3, Date = DateTime.Today, EmployeeId = 1, Hours = 4, HoursPrice = 100, Desc = "Посевная"},
            new WorkingDay(){Id = 4, Date = DateTime.Today, EmployeeId = 2, Hours = 4, HoursPrice = 100, Desc = "Посевная"},
            new WorkingDay(){Id = 5, Date = DateTime.Today, EmployeeId = 1, Hours = 6, HoursPrice = 100, Desc = "Посевная"},
            new WorkingDay(){Id = 6, Date = DateTime.Today, EmployeeId = 2, Hours = 7, HoursPrice = 100, Desc = "Посевная"},
            new WorkingDay(){Id = 7, Date = DateTime.Today, EmployeeId = 1, Hours = 8, HoursPrice = 100, Desc = "Посевная"},
        };
        public IEnumerable<WorkingDay> GetWorkingDays(int employeeId)
        {
            return _workingDays.Where(d => d.Id == employeeId);
        }
    }
}
