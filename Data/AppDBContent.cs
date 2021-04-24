using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingOfWorkers.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountingOfWorkers.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkingDay> WorkingDays { get; set; }
    }
}
