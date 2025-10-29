using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobleCinco_BarberanCastillo.Models
{
    public class UsuarioSesion
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public int PerfilId { get; set; }
        public int rol { get; set; }
    }

    public static class Sesion
    {
        public static UsuarioSesion? UsuarioActual { get; set; }
    }
}
