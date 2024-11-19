using EmployeesMVC.Models;
using EmployeesMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeesMVC.Controllers
{
    public class EmployeesController(IDataService _dataService) : Controller
    {
       

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
        public async Task<IActionResult> Create(CreateVM createVM)
        {
            if (!ModelState.IsValid)
            return View(createVM);

            await _dataService.AddAsync(createVM);
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
