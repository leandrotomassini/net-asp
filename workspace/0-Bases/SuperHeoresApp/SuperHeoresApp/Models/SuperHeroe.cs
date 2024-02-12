using SuperHeoresApp.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeoresApp.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        public int Id;
        private string _Nombre;
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public override string Nombre {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value.Trim();
            }
        }

        int ISuperHeroe.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ISuperHeroe.IdentidadSecreta { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{Nombre} esta usando el super poder {item.Nombre}");
            }

            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{Nombre} {IdentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            // return base.SalvarLaTierra();
            return $"{Nombre} {IdentidadSecreta} ha salvado la tierra";
        }
    }
}
