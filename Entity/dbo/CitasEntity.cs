using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CitasEntity : EN
    {
        public CitasEntity()
        {
            Pacientes = Pacientes ?? new PacientesEntity();
        }
        public int? CitaId { get; set; }

        public int? PacientesId { get; set; }

        public virtual PacientesEntity Pacientes { get; set; }
        public string TipoServicio { get; set; }
        public string Paciente { get; set; }
        public string Fecha { get; set; }
        public int? Hora { get; set; }

    }
}
