using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace WinFormsApp
{
    public struct IApp
    {
        public static IPacientesService PacientesService => new PacientesService();
        public static IDoctoresService DoctoresService => new DoctoresService();
        public static IServiciosService ServiciosServices => new ServiciosService();
        public static ICitasService CitasServices => new CitasService();
    }
}
