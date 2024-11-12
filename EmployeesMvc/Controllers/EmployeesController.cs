using EmployeesMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesMvc.Controllers
{
    public class EmployeesController : Controller
    {
        private static DataService _dataService = new DataService();

        [HttpGet("/")]
        public IActionResult Index()
        {
            var employees = _dataService.GetAll();
            return View(employees);
        }

        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/create")]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _dataService.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        [HttpGet("/view-details/{id}")]
        public IActionResult Details(int id)
        {
            var employee = _dataService.GetById(id);
            return View(employee);
        }
    }
}
