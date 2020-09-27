using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
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
            return _empRepository.getEmployee(1).Department;
        }

        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _empRepository.getEmployee(1),
                PageTitle = "Employee Details"
            };
            //Employee model = _empRepository.getEmployee(1);
            //ViewBag.Employee = model;
            //ViewBag.PageTitle = "Employee Details";
            return View(homeDetailsViewModel);
        }
    }
}
