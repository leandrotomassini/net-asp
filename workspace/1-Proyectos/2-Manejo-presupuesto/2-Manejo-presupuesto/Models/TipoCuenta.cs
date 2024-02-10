using System.ComponentModel.DataAnnotations;
using _2_Manejo_presupuesto.Validaciones;
using Microsoft.AspNetCore.Mvc;

namespace _2_Manejo_presupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [PrimeraLetraMayuscula]
        [Remote(action:"VerficiarExisteTipoCuenta", controller: "TiposCuentas")]
        public string Nombre { get; set; }

        public int UsuarioId { get; set; }

        public int Orden { get; set; }

       
    }
}
