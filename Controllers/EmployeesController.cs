using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingOfWorkers.Data.interfaces;
using AccountingOfWorkers.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AccountingOfWorkers.Controllers
{
    public class EmployeesController: Controller
    {
        private readonly IEmployees _employees;
        private readonly IWorkingDays _workingDays;

        public EmployeesController(IEmployees employees, IWorkingDays workingDays)
        {
            _employees = employees;
            _workingDays = workingDays;
        }

        public ViewResult MyEmployees()
        {
            EmployeesMyEmployeesViewModel model = new EmployeesMyEmployeesViewModel();
            model.GetMyEmployees = _employees.MyEmployees;
            return View(model);
        }
    }
}
