using Microsoft.AspNetCore.Mvc;
using _2_Manejo_presupuesto.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using _2_Manejo_presupuesto.Servicios;

namespace _2_Manejo_presupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {


        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas)
        {
            RepositorioTiposCuentas = repositorioTiposCuentas;
        }

        public IRepositorioTiposCuentas RepositorioTiposCuentas { get; }

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

            tipoCuenta.UsuarioId = 1;
            RepositorioTiposCuentas.Crear(tipoCuenta);

            return View();
        }
    }
}
