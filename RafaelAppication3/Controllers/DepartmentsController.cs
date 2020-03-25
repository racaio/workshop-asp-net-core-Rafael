using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RafaelAppication3.Models;

namespace RafaelAppication3.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()


        {

            List<Department> list = new List<Department>();

            list.Add(new Department { Id = 1, Name = "Eltronicos" });
            list.Add(new Department { Id = 2, Name = "Moda" });

            return View(list);
        }
    }
}