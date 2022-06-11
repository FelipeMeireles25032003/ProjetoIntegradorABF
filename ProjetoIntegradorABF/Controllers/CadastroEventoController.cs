using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradorABF.Controllers
{
    public class CadastroEventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
