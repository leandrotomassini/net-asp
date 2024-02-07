using System.ComponentModel.DataAnnotations;
using _2_Manejo_presupuesto.Validaciones;

namespace _2_Manejo_presupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }

        public int UsuarioId { get; set; }

        public int Orden { get; set; }

       
    }
}
