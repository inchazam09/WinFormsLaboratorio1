using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DoctoresEntity: EN
    {
        public DoctoresEntity()
        {
            Pacientes = Pacientes ?? new PacientesEntity();
        }
        public int? DoctoresId { get; set; }

         public int? PacientesId { get; set; }

        public virtual PacientesEntity Pacientes { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public int? Especialidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}
