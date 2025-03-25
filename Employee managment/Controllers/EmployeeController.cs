using EmployeeManagment.Application.Commans.Interfaces;
using EmployeeManagment.Infrastrucure.Reprosatories;
using EmployeeMangement.Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Employee_managment.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var AllEmployees = _repository.GetAll(null,includeProperty: "Department");
            return View(AllEmployees);
        }
    }
}
