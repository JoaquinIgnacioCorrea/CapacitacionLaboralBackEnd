using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson.Resolucion_Act_Joaquin_Correa
{
    class Usuarios
    {
        public string Usuario { get; set; }
        [JsonPropertyName("amigos_usuario")]
        public List<string> AmigosUsuario { get; set; }
        [JsonPropertyName("notificaciones_usuario")]
        public bool NotificacionesUsuario { get; set; }

        public StringBuilder MostrarAmigos()
        {
            StringBuilder ListaAmigos = new StringBuilder();
            foreach (var amigos in AmigosUsuario)
            {
                ListaAmigos.Append(amigos + " ");
            }
            return ListaAmigos;
        }
    }
}
