using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Pais { get; set; }
        public bool Activo { get; set; }
    }
}
