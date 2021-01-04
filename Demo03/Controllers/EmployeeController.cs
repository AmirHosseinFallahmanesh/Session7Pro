using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo03.Controllers
{
    public class EmployeeController :Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            
            ViewBag.Model = employeeRepository.GetEmployees();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}