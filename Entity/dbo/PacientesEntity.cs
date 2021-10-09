using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PacientesEntity: EN
    {
        public int? PacientesId { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int? Nacionalidad { get; set; }
        public string Cedula { get; set; }
        public string Edad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public string Enfermedades { get; set; }
        public bool Alergias { get; set; }
    }
}
