using Microsoft.AspNetCore.Mvc;
using _2_Manejo_presupuesto.Models;

namespace _2_Manejo_presupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            if (!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }

            return View();
        }
    }
}
