using Microsoft.AspNetCore.Mvc;
using _2_Manejo_presupuesto.Models;
using Dapper;
using _2_Manejo_presupuesto.Servicios;

namespace _2_Manejo_presupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {

        private readonly IRepositorioTiposCuentas repositorioTiposCuentas;

        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas)
        {
            this.repositorioTiposCuentas = repositorioTiposCuentas;
        }

        public async Task<IActionResult> Index()
        {
            var usuarioId = 1;
            var tiposCuentas = await repositorioTiposCuentas.Obtener(usuarioId);
            return View(tiposCuentas);
        }

        public IRepositorioTiposCuentas RepositorioTiposCuentas { get; }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(TipoCuenta tipoCuenta)
        {
            if (!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }

            tipoCuenta.UsuarioId = 1;

            var yaExisteTipoCuenta = await RepositorioTiposCuentas.Existe(tipoCuenta.Nombre, tipoCuenta.UsuarioId);

            if (yaExisteTipoCuenta)
            {
                ModelState.AddModelError(nameof(tipoCuenta.Nombre),
                    $"El nombre {tipoCuenta.Nombre} ya existe.");
                return View(tipoCuenta);
            }

            await RepositorioTiposCuentas.Crear(tipoCuenta);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> VerficiarExisteTipoCuenta(string nombre)
        {
            var usuarioId = 1;
            var yaExisteTipoCuenta = await RepositorioTiposCuentas.Existe(nombre, usuarioId);
            
            if (yaExisteTipoCuenta)
            {
                return Json($"El nombre {nombre} ya existe");
            }

            return Json(true);
        }
    }
}
