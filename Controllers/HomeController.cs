using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingOfWorkers.Data.interfaces;
using AccountingOfWorkers.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AccountingOfWorkers.Controllers
{
    public class HomeController: Controller
    {
        private readonly IEmployees _employees;

        public HomeController(IEmployees employees)
        {
            _employees = employees;
        }

        public ViewResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.MyEmployees = _employees.MyEmployees;
            Console.WriteLine("homeController");
            return View(model);
        }
    }
}
