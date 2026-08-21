using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson.Resolucion_Act_Joaquin_Correa
{
    internal class Estadistica
    {
        public string Equipo { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public bool Campeon { get; set; }

        public Estadistica()
        {
            Jugadores = new List<Jugador>();
        }
    }
}
