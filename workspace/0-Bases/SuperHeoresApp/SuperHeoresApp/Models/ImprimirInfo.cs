using SuperHeoresApp.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeoresApp.Models
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHero)
        {
            Console.WriteLine($"Id: {superHero.Id}");
            Console.WriteLine($"Nombre: {superHero.nombre}");
            Console.WriteLine($"Identidad secreta: {superHero.IdentidadSecreta}");
        }
    }
}
