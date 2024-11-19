using EmployeesMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeesMVC.Controllers
{
    public class EmployeesController : Controller
    {
        //private static DataService _dataService = new DataService();
        private readonly IDataService _dataService;
        public EmployeesController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var Model = await _dataService.GetAllAsync();
            return View(Model);
        }

        [HttpGet("Create")] 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]  
        public async Task<IActionResult> Create(Employee employee)
        {
            if (!ModelState.IsValid)
            return View(employee);

            await _dataService.AddAsync(employee);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/view-details/{id}")]
        public async  Task<IActionResult>Details(int id)
        {
            var employee = await _dataService.GetByIdAsync(id);
            return View(employee);
        }
    }
}
