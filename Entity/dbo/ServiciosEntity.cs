using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServiciosEntity: EN
    {
        public ServiciosEntity()
        {
            Pacientes = Pacientes ?? new PacientesEntity();
        }
        public int? ServicioId { get; set; }

        public int? PacientesId { get; set; }

        public virtual PacientesEntity Pacientes { get; set; }
        public string Servicio  { get; set; }
        public string Procedimiento { get; set; }
        public string Caracteristicas { get; set; }
        public int? Doctor { get; set; }
        public string Precio { get; set; }
        public string HorariosDisponibles { get; set; }

    }
}

