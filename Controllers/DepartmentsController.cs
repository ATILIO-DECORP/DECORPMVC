using DECORPMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DECORPMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "frutas", Descricao = "grandes" });
            list.Add(new Departament { Id = 2, Name = "legumes", Descricao = "verdes" });

            return View(list);
        }
    }
}
