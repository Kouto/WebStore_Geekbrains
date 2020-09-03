using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore_Geekbrains.Interfaces.Infrastructure;
using WebStore_Geekbrains.ViewModels;

namespace WebStore_Geekbrains.Controllers
{
    //[Route("users/[action]")]
    [Route("users")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeesService _employeesService;
        public EmployeeController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }
        [Route("all")]
        public IActionResult Employees()
        {
            return View(_employeesService.GetAll());
        }
        [Route("id")]
        public IActionResult EmployeeDetails(int id)
        {
            var employee = _employeesService.GetById(id);

            if (employee==null)
            {
                return NotFound();
            }

            return View(employee);
        }
    }
}
