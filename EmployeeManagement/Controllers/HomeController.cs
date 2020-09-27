using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _empRepository;

        public HomeController(IEmployeeRepository empRepository)
        {
            _empRepository = empRepository;
        }
        public string Index()
        {
            return _empRepository.getEmployee(1).Name;
        }

        public ViewResult Details()
        {
            Employee model = _empRepository.getEmployee(1);
            return View("MyViews/Test.cshtml");
        }
    }
}
