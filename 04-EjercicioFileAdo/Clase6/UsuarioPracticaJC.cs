using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    internal class UsuarioPracticaJC
    {
        public UsuarioPracticaJC(string? idUsuario, string nombre, string apellido)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
        }

        public string? IdUsuario { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
    }
}
