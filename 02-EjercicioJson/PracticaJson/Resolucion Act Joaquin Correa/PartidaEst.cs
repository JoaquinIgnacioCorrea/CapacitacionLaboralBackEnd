using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson.Resolucion_Act_Joaquin_Correa
{
    internal class PartidaEst
    {
        [JsonPropertyName("estadistica")]
        public List<Estadistica> Estadisticas { get; set; }
    }
}
