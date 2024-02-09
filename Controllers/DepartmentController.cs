using Microsoft.AspNetCore.Mvc;
using MVC_Will.Models.ViewModel;
using System.Collections.Generic;
namespace MVC_Will.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id= 1, Name = "Games" });
            departments.Add(new Department { Id = 2, Name = "Consoles" });
            return View(departments);
        }
    }
}
