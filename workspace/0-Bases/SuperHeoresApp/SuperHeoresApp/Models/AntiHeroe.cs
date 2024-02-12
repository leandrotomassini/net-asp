using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeoresApp.Models
{
    internal class AntiHeroe: SuperHeroe
    {
        public string RealizarAccionDeAntiheroe(string accion)
        {
            return $"El Antiheroe {IdentidadSecreta} ha realizado: {accion}";
        }
    }
}
