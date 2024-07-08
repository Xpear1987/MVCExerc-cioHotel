using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Migração_Exercicio_Hotel.Controllers
{
    public class ReservaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Cancelar()
        {
            return View();
        }
    }
}
